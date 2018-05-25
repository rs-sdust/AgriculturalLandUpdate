// ***********************************************************************
// Assembly         : AgriculturalLandUpdate
// Author           : RickerYan
// Created          : 05-21-2018
//
// Last Modified By : RickerYan
// Last Modified On : 05-22-2018
// ***********************************************************************
// <copyright file="frmMain.cs" company="SunGolden">
//     Copyright ©  2018
// </copyright>
// <summary>主窗体</summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Configuration;
using AgriculturalLandUpdate.Db;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Carto;


namespace AgriculturalLandUpdate
{
    /// <summary>
    /// Class frmMain.
    /// </summary>
    /// <seealso cref="MaterialSkin.Controls.MaterialForm" />
    public partial class frmMain : MaterialForm
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="frmMain"/> class.
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
            //添加当前窗体到皮肤管理器
            ConstDef.materialSkinManager.AddFormToManage(this);
            (axMapControl.Object as IMapControlEvents2_Event).OnMouseDown += new IMapControlEvents2_OnMouseDownEventHandler(this.mapControl_OnMouseDown);
            (axMapControl.Object as IMapControlEvents2_Event).OnMouseMove += new IMapControlEvents2_OnMouseMoveEventHandler(this.mapControl_OnMouseMove);
            (axMapControl.Object as IMapControlEvents2_Event).OnAfterScreenDraw += new IMapControlEvents2_OnAfterScreenDrawEventHandler(this.mapControl_OnAfterScreenDraw);
            (axTOCControl.Object as ITOCControlEvents_Event).OnMouseDown += new ITOCControlEvents_OnMouseDownEventHandler(this.tocControl_OnMouseDown);
        }

        /// <summary>
        /// Handles the Load event of the frmMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            IniUC();
        }
        /// <summary>
        /// Handles the FormClosing event of the frmMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveUISet();
        }
        /// <summary>
        /// 初始化主界面控件.
        /// </summary>
        private void IniUC()
        {
            //ribbon菜单初始化
            ucPanelFile panelFile = new ucPanelFile();
            ucPanelPrepro panelCloud = new ucPanelPrepro();
            ucPanelUpdate panelUpdate = new ucPanelUpdate();
            ucPanelSys panelSys = new ucPanelSys();
            this.tpFile.Controls.Add(panelFile);
            this.tpPreprocess.Controls.Add(panelCloud);
            this.tpUpdate.Controls.Add(panelUpdate);
            this.tpSys.Controls.Add(panelSys);
            panelFile.Anchor = panelCloud.Anchor = panelUpdate.Anchor = panelSys.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;

            //gis控件初始化
            this.axTOCControl.Dock = DockStyle.Fill;
            this.axMapControl.Dock = DockStyle.Fill;
            axMapControl.Map.Name = "图层";

            //修改状态栏用户信息
            if(ConstDef.curUser!=null)
            {
                this.tsslUser.Text = "当前用户：" + ConstDef.curUser.UserName + "-" + ConstDef.curUser.Role.Name;
            }

            //主界面大小位置初始化
            string sizeStr = ConfigurationManager.AppSettings["Size"].Trim();
            if (!string.IsNullOrEmpty(sizeStr))
            {
                try
                {
                    string[] size = sizeStr.Split(',');
                    if (size.Length == 5)
                    {
                        int width = int.Parse(size[2]);
                        if (width == 1920 || width == 1366)
                        {
                            this.Size = new Size(1024, 768);
                            this.CenterToScreen();
                        }
                        else
                        {
                            this.Location = new System.Drawing.Point(int.Parse(size[0]), int.Parse(size[1]));
                            this.Size = new Size(int.Parse(size[2]), int.Parse(size[3]));
                            this.splitContainer.SplitterDistance = int.Parse(size[4]);
                        }
                    }
                    else
                    {
                        this.CenterToScreen();
                    }
                }
                catch (Exception ex)
                {
                    LogMan.Log2File(null, ex);
                }
            }
        }

        /// <summary>
        /// 保存界面相关配置.
        /// </summary>
        private void saveUISet()
        {
            //打开配置文件
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //保存当前主界面宽高和分割器位置
            config.AppSettings.Settings["Size"].Value = this.Location.X+","+this.Location.Y+","+
                this.Size.Width.ToString() + "," + this.Size.Height.ToString() + "," + this.splitContainer.SplitterDistance.ToString();
            //保存配置
            config.Save();
        }

        #region Gis控件事件
        //Gis Command click
        private void tsb_Click(object sender, EventArgs e)
        {
            object tag = (sender as ToolStripButton).Tag;
            if(tag==null)
                return;
            string cmdName = tag.ToString();
            if(string.IsNullOrEmpty(cmdName))
                return;

            ICommand pCmd;
            ICommandPool pCmdPool=axToolbarControl.CommandPool;
            for (int i=0;i<pCmdPool.Count;i++)
            {
                pCmd=pCmdPool.get_Command(i);
                if(pCmd.Name==cmdName)
                {
                    if (pCmd is ITool)
                    {
                        (axToolbarControl.Buddy as IMapControl3).CurrentTool = pCmd as ITool;
                    }
                    pCmd.OnClick();
                    break;
                }
            }
        }
        private void mapControl_OnMouseDown(int button, int shift, int x, int y, double mapX, double mapY)
        {
            //按下中键绑定移动图层命令
            ITool tool = null;
            if (button == 4)
            {
                //清空地图工具，防止误操作
                tool = this.axMapControl.CurrentTool;
                this.axMapControl.CurrentTool = null;
                //更改鼠标样式
                axMapControl.MousePointer = esriControlsMousePointer.esriPointerPan;
                //拖动图层
                axMapControl.Pan();
            }
            this.axMapControl.MousePointer = esriControlsMousePointer.esriPointerArrow;
        }
        private void mapControl_OnMouseMove(int button, int shift, int x, int y, double mapX, double mapY)
        {
            this.GetStatusXY(mapX, mapY);
        }
        private void mapControl_OnAfterScreenDraw(int hdc)
        {
            this.GetSpRf(this.axMapControl.SpatialReference);
            this.SetCmdEnabled();
        }
        private void tocControl_OnMouseDown(int button, int shift, int x, int y)
        {
            esriTOCControlItem esriTOCControlItem = esriTOCControlItem.esriTOCControlItemNone;
            object obj = null;
            object obj2 = null;
            IBasicMap basicMap = null;
            ILayer layer = null;
            this.axTOCControl.HitTest(x, y, ref esriTOCControlItem, ref basicMap, ref layer, ref obj, ref obj2);
            if (button == 2)
            {
                switch (esriTOCControlItem)
                {
                    case esriTOCControlItem.esriTOCControlItemMap:
                        this.axTOCControl.SelectItem(basicMap, null);
                        this.axMapControl.CustomProperty = basicMap;
                        this.mcmsFrame.Show(System.Windows.Forms.Control.MousePosition);
                        break;
                    case esriTOCControlItem.esriTOCControlItemLayer:
                        this.axTOCControl.SelectItem(layer, null);
                        this.axMapControl.CustomProperty = layer;
                        //this.SetBarItemEnabled();
                        this.SetCmdEnabled();
                        this.mcmsLayer.Show(System.Windows.Forms.Control.MousePosition);
                        break;
                }
            }
        }
        //
        //获取鼠标位置坐标
        //
        private void GetStatusXY(double mapX, double mapY)
        {
            try
            {
                ISpatialReference spatialReference = this.axMapControl.SpatialReference;
                if (spatialReference != null)
                {
                    if (spatialReference is IProjectedCoordinateSystem)
                    {
                        IProjectedCoordinateSystem projectedCoordinateSystem = spatialReference as IProjectedCoordinateSystem;
                        IPoint point = new PointClass();
                        point.SpatialReference = spatialReference;
                        point.X = mapX;
                        point.Y = mapY;
                        point.Project(projectedCoordinateSystem.GeographicCoordinateSystem);
                        double lon = point.X;
                        double lat = point.Y;
                        int lon_degree = (int)Math.Floor(Convert.ToDecimal(lon));
                        int lat_degree = (int)Math.Floor(Convert.ToDecimal(lat));
                        lon = (lon - lon_degree)*60;
                        lat = (lat - lat_degree) * 60;
                        int lon_m = (int)Math.Floor(Convert.ToDecimal(lon));
                        int lat_m = (int)Math.Floor(Convert.ToDecimal(lat));
                        lon = (lon - lon_m) * 60;
                        lat = (lat - lat_m) * 60;
                        int lon_s = (int)Math.Floor(Convert.ToDecimal(lon));
                        int lat_s = (int)Math.Floor(Convert.ToDecimal(lat));
                        string strLon = "";
                        string strLat = "";
                        if (lon_degree > 0)
                        {
                            strLon = lon_degree + "° " + lon_m + "′ " + lon_s + "″ E";                      
                        }
                        else 
                        {
                            strLon = lon_degree + "° " + lon_m + "′ " + lon_s + "″ E";
                        }
                        if (lat_degree > 0)
                        {
                            strLat = lat_degree + "° " + lat_m + "′ " + lat_s + "″ N";
                        }
                        else
                        {
                            strLat = lat_degree + "° " + lat_m + "′ " + lat_s + "″ N";
                        }
                        this.tsslXY.Text = string.Format("坐标：{0},{1}", strLon, strLat);
                    }
                }
                else
                    this.tsslXY.Text = string.Format("坐标：{0},{1}", mapX, mapY);
                }
            catch (Exception ex)
            {
                LogMan.Log2File(null, ex);
            }
        }
        //
        //获取当前空间参考
        //
        private void GetSpRf(ISpatialReference spatialReference)
        {
                string arg = "未知参考系";
                if (spatialReference != null)
                {
                    if (!(spatialReference is IUnknownCoordinateSystem))
                    {
                        if (string.IsNullOrEmpty(spatialReference.Alias))
                        {
                            arg = spatialReference.Name;
                        }
                        else
                        {
                            arg = spatialReference.Alias;
                        }
                    }
                }
                this.tsslCoordinate.Text = string.Format("空间参考： {0}", arg);
        }
        //设置command按钮是否激活
        private void SetCmdEnabled()
        {
            Dictionary<string, bool> dictionary = new Dictionary<string, bool>();
            for (int i = 0; i < this.axToolbarControl.CommandPool.Count; i++)
            {
                ICommand command = this.axToolbarControl.CommandPool.get_Command(i);
                dictionary.Add(command.Name, command.Enabled);
            }
            //工具条按钮
            foreach (ToolStripButton btn in toolStrip.Items)
            {
                if (btn.Tag != null)
                {
                    string cmdName = btn.Tag.ToString();
                    if (!string.IsNullOrWhiteSpace(cmdName) && dictionary.ContainsKey(cmdName))
                    {
                        btn.Enabled = dictionary[cmdName];
                    }
                }
            }
            //图框右键菜单
            foreach (ToolStripMenuItem btn in mcmsFrame.Items)
            {
                if (btn.Tag != null)
                {
                    string cmdName = btn.Tag.ToString();
                    if (!string.IsNullOrWhiteSpace(cmdName) && dictionary.ContainsKey(cmdName))
                    {
                        btn.Enabled = dictionary[cmdName];
                    }
                }
            }
            //图层右键菜单
            foreach (ToolStripMenuItem btn in mcmsLayer.Items)
            {
                if (btn.Tag != null)
                {
                    string cmdName = btn.Tag.ToString();
                    if (!string.IsNullOrWhiteSpace(cmdName) && dictionary.ContainsKey(cmdName))
                    {
                        btn.Enabled = dictionary[cmdName];
                    }
                }
            }
        }
        #endregion


    }
}
