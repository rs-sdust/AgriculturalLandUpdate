namespace AgriculturalLandUpdate
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.axTOCControl = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.panelMap = new System.Windows.Forms.Panel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbFull = new System.Windows.Forms.ToolStripButton();
            this.tsbPan = new System.Windows.Forms.ToolStripButton();
            this.tsbZoomIn = new System.Windows.Forms.ToolStripButton();
            this.tsbZoomOut = new System.Windows.Forms.ToolStripButton();
            this.tsbFixedIn = new System.Windows.Forms.ToolStripButton();
            this.tsbFixedOut = new System.Windows.Forms.ToolStripButton();
            this.tsbPreview = new System.Windows.Forms.ToolStripButton();
            this.tsbNext = new System.Windows.Forms.ToolStripButton();
            this.tsbIdentity = new System.Windows.Forms.ToolStripButton();
            this.axMapControl = new ESRI.ArcGIS.Controls.AxMapControl();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCoordinate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslXY = new System.Windows.Forms.ToolStripStatusLabel();
            this.axToolbarControl = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.materialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tpFile = new System.Windows.Forms.TabPage();
            this.tpPreprocess = new System.Windows.Forms.TabPage();
            this.tpUpdate = new System.Windows.Forms.TabPage();
            this.tpSys = new System.Windows.Forms.TabPage();
            this.materialTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.mcmsLayer = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.tsmiZoom2Lyr = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRemoveLyr = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenTable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRender = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTransparent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLyrAttr = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZom2Pixel = new System.Windows.Forms.ToolStripMenuItem();
            this.mcmsFrame = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReset = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl)).BeginInit();
            this.panelMap.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl)).BeginInit();
            this.materialTabControl.SuspendLayout();
            this.mcmsLayer.SuspendLayout();
            this.mcmsFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.axToolbarControl, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 132);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(638, 377);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(3, 37);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer.Panel1.Controls.Add(this.axTOCControl);
            this.splitContainer.Panel1MinSize = 100;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer.Panel2.Controls.Add(this.panelMap);
            this.splitContainer.Panel2.Controls.Add(this.axMapControl);
            this.splitContainer.Panel2MinSize = 256;
            this.splitContainer.Size = new System.Drawing.Size(632, 317);
            this.splitContainer.SplitterDistance = 115;
            this.splitContainer.TabIndex = 0;
            // 
            // axTOCControl
            // 
            this.axTOCControl.Location = new System.Drawing.Point(23, 114);
            this.axTOCControl.Name = "axTOCControl";
            this.axTOCControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl.OcxState")));
            this.axTOCControl.Size = new System.Drawing.Size(68, 71);
            this.axTOCControl.TabIndex = 0;
            // 
            // panelMap
            // 
            this.panelMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMap.Controls.Add(this.toolStrip);
            this.panelMap.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMap.Location = new System.Drawing.Point(0, 0);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(513, 27);
            this.panelMap.TabIndex = 1;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbFull,
            this.tsbPan,
            this.tsbZoomIn,
            this.tsbZoomOut,
            this.tsbFixedIn,
            this.tsbFixedOut,
            this.tsbPreview,
            this.tsbNext,
            this.tsbIdentity});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(511, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = global::AgriculturalLandUpdate.Properties.Resources.add;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd.Tag = "ControlToolsGeneric_AddData";
            this.tsbAdd.Text = "添加数据";
            this.tsbAdd.Click += new System.EventHandler(this.tsb_Click);
            // 
            // tsbFull
            // 
            this.tsbFull.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFull.Image = global::AgriculturalLandUpdate.Properties.Resources.FullExtent;
            this.tsbFull.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFull.Name = "tsbFull";
            this.tsbFull.Size = new System.Drawing.Size(23, 22);
            this.tsbFull.Tag = "ControlToolsMapNavigation_FullExtent";
            this.tsbFull.Text = "全图";
            this.tsbFull.Click += new System.EventHandler(this.tsb_Click);
            // 
            // tsbPan
            // 
            this.tsbPan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPan.Image = global::AgriculturalLandUpdate.Properties.Resources.Pan;
            this.tsbPan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPan.Name = "tsbPan";
            this.tsbPan.Size = new System.Drawing.Size(23, 22);
            this.tsbPan.Tag = "ControlToolsMapNavigation_Pan";
            this.tsbPan.Text = "漫游";
            this.tsbPan.Click += new System.EventHandler(this.tsb_Click);
            // 
            // tsbZoomIn
            // 
            this.tsbZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbZoomIn.Image = global::AgriculturalLandUpdate.Properties.Resources.ZoomIn;
            this.tsbZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbZoomIn.Name = "tsbZoomIn";
            this.tsbZoomIn.Size = new System.Drawing.Size(23, 22);
            this.tsbZoomIn.Tag = "ControlToolsMapNavigation_ZoomIn";
            this.tsbZoomIn.Text = "放大";
            this.tsbZoomIn.Click += new System.EventHandler(this.tsb_Click);
            // 
            // tsbZoomOut
            // 
            this.tsbZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbZoomOut.Image = global::AgriculturalLandUpdate.Properties.Resources.ZoomOut;
            this.tsbZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbZoomOut.Name = "tsbZoomOut";
            this.tsbZoomOut.Size = new System.Drawing.Size(23, 22);
            this.tsbZoomOut.Tag = "ControlToolsMapNavigation_ZoomOut";
            this.tsbZoomOut.Text = "缩小";
            this.tsbZoomOut.Click += new System.EventHandler(this.tsb_Click);
            // 
            // tsbFixedIn
            // 
            this.tsbFixedIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFixedIn.Image = global::AgriculturalLandUpdate.Properties.Resources.fixZomIn;
            this.tsbFixedIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFixedIn.Name = "tsbFixedIn";
            this.tsbFixedIn.Size = new System.Drawing.Size(23, 22);
            this.tsbFixedIn.Tag = "ControlToolsMapNavigation_ZoomInFixed";
            this.tsbFixedIn.Text = "固定比例放大";
            this.tsbFixedIn.Click += new System.EventHandler(this.tsb_Click);
            // 
            // tsbFixedOut
            // 
            this.tsbFixedOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFixedOut.Image = global::AgriculturalLandUpdate.Properties.Resources.fixZomOut;
            this.tsbFixedOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFixedOut.Name = "tsbFixedOut";
            this.tsbFixedOut.Size = new System.Drawing.Size(23, 22);
            this.tsbFixedOut.Tag = "ControlToolsMapNavigation_ZoomOutFixed";
            this.tsbFixedOut.Text = "固定比例缩小";
            this.tsbFixedOut.Click += new System.EventHandler(this.tsb_Click);
            // 
            // tsbPreview
            // 
            this.tsbPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPreview.Image = global::AgriculturalLandUpdate.Properties.Resources.preView;
            this.tsbPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPreview.Name = "tsbPreview";
            this.tsbPreview.Size = new System.Drawing.Size(23, 22);
            this.tsbPreview.Tag = "ControlToolsMapNavigation_ZoomToLastExtentBack";
            this.tsbPreview.Text = "上一视图";
            this.tsbPreview.Click += new System.EventHandler(this.tsb_Click);
            // 
            // tsbNext
            // 
            this.tsbNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNext.Image = global::AgriculturalLandUpdate.Properties.Resources.nextView;
            this.tsbNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNext.Name = "tsbNext";
            this.tsbNext.Size = new System.Drawing.Size(23, 22);
            this.tsbNext.Tag = "ControlToolsMapNavigation_ZoomToLastExtentForward";
            this.tsbNext.Text = "下一视图";
            this.tsbNext.Click += new System.EventHandler(this.tsb_Click);
            // 
            // tsbIdentity
            // 
            this.tsbIdentity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbIdentity.Image = global::AgriculturalLandUpdate.Properties.Resources.identity;
            this.tsbIdentity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIdentity.Name = "tsbIdentity";
            this.tsbIdentity.Size = new System.Drawing.Size(23, 22);
            this.tsbIdentity.Tag = "ControlToolsMapInquiry_Identify";
            this.tsbIdentity.Text = "识别要素";
            this.tsbIdentity.Click += new System.EventHandler(this.tsb_Click);
            // 
            // axMapControl
            // 
            this.axMapControl.Location = new System.Drawing.Point(212, 114);
            this.axMapControl.Name = "axMapControl";
            this.axMapControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl.OcxState")));
            this.axMapControl.Size = new System.Drawing.Size(74, 71);
            this.axMapControl.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslUser,
            this.tsslCoordinate,
            this.tsslXY});
            this.statusStrip.Location = new System.Drawing.Point(0, 357);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(638, 20);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tsslUser
            // 
            this.tsslUser.ForeColor = System.Drawing.SystemColors.Window;
            this.tsslUser.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsslUser.Name = "tsslUser";
            this.tsslUser.Size = new System.Drawing.Size(153, 16);
            this.tsslUser.Text = "当前用户：admin - 管理员";
            // 
            // tsslCoordinate
            // 
            this.tsslCoordinate.ForeColor = System.Drawing.SystemColors.Window;
            this.tsslCoordinate.Margin = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.tsslCoordinate.Name = "tsslCoordinate";
            this.tsslCoordinate.Size = new System.Drawing.Size(50, 16);
            this.tsslCoordinate.Text = "WGS84";
            // 
            // tsslXY
            // 
            this.tsslXY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsslXY.ForeColor = System.Drawing.SystemColors.Window;
            this.tsslXY.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.tsslXY.Name = "tsslXY";
            this.tsslXY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsslXY.Size = new System.Drawing.Size(410, 16);
            this.tsslXY.Spring = true;
            this.tsslXY.Text = "X,Y";
            this.tsslXY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // axToolbarControl
            // 
            this.axToolbarControl.Location = new System.Drawing.Point(3, 3);
            this.axToolbarControl.Name = "axToolbarControl";
            this.axToolbarControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl.OcxState")));
            this.axToolbarControl.Size = new System.Drawing.Size(265, 28);
            this.axToolbarControl.TabIndex = 3;
            this.axToolbarControl.Visible = false;
            // 
            // materialTabControl
            // 
            this.materialTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.materialTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl.Controls.Add(this.tpFile);
            this.materialTabControl.Controls.Add(this.tpPreprocess);
            this.materialTabControl.Controls.Add(this.tpUpdate);
            this.materialTabControl.Controls.Add(this.tpSys);
            this.materialTabControl.Depth = 0;
            this.materialTabControl.Location = new System.Drawing.Point(4, 66);
            this.materialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl.Multiline = true;
            this.materialTabControl.Name = "materialTabControl";
            this.materialTabControl.SelectedIndex = 0;
            this.materialTabControl.Size = new System.Drawing.Size(632, 64);
            this.materialTabControl.TabIndex = 1;
            // 
            // tpFile
            // 
            this.tpFile.Location = new System.Drawing.Point(76, 4);
            this.tpFile.Name = "tpFile";
            this.tpFile.Padding = new System.Windows.Forms.Padding(3);
            this.tpFile.Size = new System.Drawing.Size(552, 56);
            this.tpFile.TabIndex = 0;
            this.tpFile.Text = "文件管理";
            this.tpFile.UseVisualStyleBackColor = true;
            // 
            // tpPreprocess
            // 
            this.tpPreprocess.Location = new System.Drawing.Point(76, 4);
            this.tpPreprocess.Name = "tpPreprocess";
            this.tpPreprocess.Padding = new System.Windows.Forms.Padding(3);
            this.tpPreprocess.Size = new System.Drawing.Size(552, 56);
            this.tpPreprocess.TabIndex = 1;
            this.tpPreprocess.Text = "标准化预处理";
            this.tpPreprocess.UseVisualStyleBackColor = true;
            // 
            // tpUpdate
            // 
            this.tpUpdate.Location = new System.Drawing.Point(76, 4);
            this.tpUpdate.Name = "tpUpdate";
            this.tpUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpdate.Size = new System.Drawing.Size(552, 56);
            this.tpUpdate.TabIndex = 2;
            this.tpUpdate.Text = "农业用地更新";
            this.tpUpdate.UseVisualStyleBackColor = true;
            // 
            // tpSys
            // 
            this.tpSys.Location = new System.Drawing.Point(76, 4);
            this.tpSys.Name = "tpSys";
            this.tpSys.Padding = new System.Windows.Forms.Padding(3);
            this.tpSys.Size = new System.Drawing.Size(552, 56);
            this.tpSys.TabIndex = 3;
            this.tpSys.Text = "系统管理";
            this.tpSys.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector
            // 
            this.materialTabSelector.BaseTabControl = this.materialTabControl;
            this.materialTabSelector.Depth = 0;
            this.materialTabSelector.Location = new System.Drawing.Point(0, 26);
            this.materialTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector.Name = "materialTabSelector";
            this.materialTabSelector.Size = new System.Drawing.Size(640, 36);
            this.materialTabSelector.TabIndex = 2;
            this.materialTabSelector.Text = "materialTabSelector1";
            // 
            // mcmsLayer
            // 
            this.mcmsLayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcmsLayer.Depth = 0;
            this.mcmsLayer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiZoom2Lyr,
            this.tsmiRemoveLyr,
            this.tsmiOpenTable,
            this.tsmiRender,
            this.tsmiTransparent,
            this.tsmiLyrAttr,
            this.tsmiZom2Pixel});
            this.mcmsLayer.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcmsLayer.Name = "mcmsLayer";
            this.mcmsLayer.Size = new System.Drawing.Size(161, 158);
            // 
            // tsmiZoom2Lyr
            // 
            this.tsmiZoom2Lyr.Image = global::AgriculturalLandUpdate.Properties.Resources.zom2Lyr;
            this.tsmiZoom2Lyr.Name = "tsmiZoom2Lyr";
            this.tsmiZoom2Lyr.Size = new System.Drawing.Size(160, 22);
            this.tsmiZoom2Lyr.Text = "缩放到图层";
            // 
            // tsmiRemoveLyr
            // 
            this.tsmiRemoveLyr.Image = global::AgriculturalLandUpdate.Properties.Resources.remove;
            this.tsmiRemoveLyr.Name = "tsmiRemoveLyr";
            this.tsmiRemoveLyr.Size = new System.Drawing.Size(160, 22);
            this.tsmiRemoveLyr.Text = "移除图层";
            // 
            // tsmiOpenTable
            // 
            this.tsmiOpenTable.Image = global::AgriculturalLandUpdate.Properties.Resources.table;
            this.tsmiOpenTable.Name = "tsmiOpenTable";
            this.tsmiOpenTable.Size = new System.Drawing.Size(160, 22);
            this.tsmiOpenTable.Text = "打开属性表";
            // 
            // tsmiRender
            // 
            this.tsmiRender.Image = global::AgriculturalLandUpdate.Properties.Resources.render;
            this.tsmiRender.Name = "tsmiRender";
            this.tsmiRender.Size = new System.Drawing.Size(160, 22);
            this.tsmiRender.Text = "图层渲染";
            // 
            // tsmiTransparent
            // 
            this.tsmiTransparent.Image = global::AgriculturalLandUpdate.Properties.Resources.trans;
            this.tsmiTransparent.Name = "tsmiTransparent";
            this.tsmiTransparent.Size = new System.Drawing.Size(160, 22);
            this.tsmiTransparent.Text = "图层透明度";
            // 
            // tsmiLyrAttr
            // 
            this.tsmiLyrAttr.Image = global::AgriculturalLandUpdate.Properties.Resources.attr;
            this.tsmiLyrAttr.Name = "tsmiLyrAttr";
            this.tsmiLyrAttr.Size = new System.Drawing.Size(160, 22);
            this.tsmiLyrAttr.Text = "图层属性";
            // 
            // tsmiZom2Pixel
            // 
            this.tsmiZom2Pixel.Image = global::AgriculturalLandUpdate.Properties.Resources.pixel;
            this.tsmiZom2Pixel.Name = "tsmiZom2Pixel";
            this.tsmiZom2Pixel.Size = new System.Drawing.Size(160, 22);
            this.tsmiZom2Pixel.Text = "缩放到实际像素";
            // 
            // mcmsFrame
            // 
            this.mcmsFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcmsFrame.Depth = 0;
            this.mcmsFrame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdd,
            this.tsmiReset});
            this.mcmsFrame.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcmsFrame.Name = "mcmsLayer";
            this.mcmsFrame.Size = new System.Drawing.Size(125, 48);
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.Image = global::AgriculturalLandUpdate.Properties.Resources.add;
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.Size = new System.Drawing.Size(124, 22);
            this.tsmiAdd.Tag = "ControlToolsGeneric_AddData";
            this.tsmiAdd.Text = "加载数据";
            // 
            // tsmiReset
            // 
            this.tsmiReset.Image = global::AgriculturalLandUpdate.Properties.Resources.reset;
            this.tsmiReset.Name = "tsmiReset";
            this.tsmiReset.Size = new System.Drawing.Size(124, 22);
            this.tsmiReset.Text = "重置图框";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 512);
            this.Controls.Add(this.materialTabControl);
            this.Controls.Add(this.materialTabSelector);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "农业用地更新子系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl)).EndInit();
            this.panelMap.ResumeLayout(false);
            this.panelMap.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl)).EndInit();
            this.materialTabControl.ResumeLayout(false);
            this.mcmsLayer.ResumeLayout(false);
            this.mcmsFrame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl;
        private System.Windows.Forms.TabPage tpFile;
        private System.Windows.Forms.TabPage tpPreprocess;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl;
        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbFull;
        private System.Windows.Forms.ToolStripButton tsbPan;
        private System.Windows.Forms.ToolStripButton tsbZoomIn;
        private System.Windows.Forms.ToolStripButton tsbZoomOut;
        private System.Windows.Forms.ToolStripButton tsbFixedIn;
        private System.Windows.Forms.ToolStripButton tsbFixedOut;
        private System.Windows.Forms.ToolStripButton tsbPreview;
        private System.Windows.Forms.ToolStripButton tsbNext;
        private System.Windows.Forms.TabPage tpUpdate;
        private System.Windows.Forms.TabPage tpSys;
        private System.Windows.Forms.ToolStripButton tsbIdentity;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.ToolStripStatusLabel tsslCoordinate;
        private System.Windows.Forms.ToolStripStatusLabel tsslXY;
        private MaterialSkin.Controls.MaterialContextMenuStrip mcmsLayer;
        private System.Windows.Forms.ToolStripMenuItem tsmiZoom2Lyr;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemoveLyr;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenTable;
        private System.Windows.Forms.ToolStripMenuItem tsmiTransparent;
        private System.Windows.Forms.ToolStripMenuItem tsmiRender;
        private System.Windows.Forms.ToolStripMenuItem tsmiLyrAttr;
        private MaterialSkin.Controls.MaterialContextMenuStrip mcmsFrame;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiReset;
        private System.Windows.Forms.ToolStripMenuItem tsmiZom2Pixel;

    }
}

