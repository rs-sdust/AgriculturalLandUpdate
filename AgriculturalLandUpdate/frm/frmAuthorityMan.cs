// ***********************************************************************
// Assembly         : AgriculturalLandUpdate
// Author           : RickerYan
// Created          : 05-23-2018
//
// Last Modified By : RickerYan
// Last Modified On : 05-24-2018
// ***********************************************************************
// <copyright file="frmAuthorityMan.cs" company="SunGolden">
//     Copyright ©  2018
// </copyright>
// <summary>权限管理界面</summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using AgriculturalLandUpdate.Db;
using MaterialSkin.Controls;

namespace AgriculturalLandUpdate
{
    public partial class frmAuthorityMan : MaterialForm
    {
        private ComboBox cmbRole = new ComboBox();
        private DataTable dtAuth = null;
        public frmAuthorityMan()
        {
            InitializeComponent();
            ConstDef.materialSkinManager.AddFormToManage(this);
            dgvAuth.CurrentCellChanged += new EventHandler(dgvAuth_CurrentCellChanged);
            dgvAuth.Scroll += new ScrollEventHandler(dgvAuth_Scroll);
            dgvAuth.ColumnWidthChanged += new DataGridViewColumnEventHandler(dgvAuth_ColumnWidthChanged);
            cmbRole.SelectedIndexChanged += new EventHandler(cmbRole_SelectedIndexChanged);

        }

        private void frmAuthorityMan_Load(object sender, EventArgs e)
        {
            //下拉框初始化
            cmbRole.Visible = false;
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            Common.UIIni.LoadRoles(cmbRole);
            this.dgvAuth.Controls.Add(cmbRole);
            //数据表初始化
            loadAuth();
        }
        //加载数据
        private void loadAuth()
        {
            dtAuth = new DataTable();
            DataColumn dataColumn0 = this.dtAuth.Columns.Add("id", Type.GetType("System.Int32"));
            DataColumn dataColumn1 = this.dtAuth.Columns.Add("name", Type.GetType("System.String"));
            DataColumn dataColumn2 = this.dtAuth.Columns.Add("roleId", Type.GetType("System.Int32"));
            DataColumn dataColumn3 = this.dtAuth.Columns.Add("roleName", Type.GetType("System.String"));
            List<Db.Authority> authList = Db.Authority.Query("");
            dtAuth.Rows.Clear();
            foreach (Db.Authority auth in authList)
            {
                dtAuth.Rows.Add(auth.Id,auth.Name,auth.Role.Id,auth.Role.Name);
            }
            dgvAuth.DataSource = dtAuth;
            dgvAuth.Columns[0].HeaderText = "编号";
            dgvAuth.Columns[1].HeaderText = "模块名称";
            dgvAuth.Columns[2].HeaderText = "角色编号";
            dgvAuth.Columns[3].HeaderText = "角色名";
            dgvAuth.Columns[2].Visible = false;

            dgvAuth.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvAuth.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAuth.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        //下拉框选择逻辑
        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            int roleId = cmbRole.SelectedIndex+2;
            string roleName=cmbRole.Text;
            string oldName = string.Empty;
            DataGridViewCell cell = dgvAuth.CurrentCell;
            if (cell != null)
            {
                try
                {
                    oldName = cell.Value.ToString();
                    cell.Value = roleName;
                    int row = cell.RowIndex;
                    dgvAuth.Rows[row].Cells[2].Value = roleId;
                    Db.Authority auth = new Db.Authority();
                    auth.Id = Convert.ToInt32(dtAuth.Rows[row]["id"]);
                    auth.Name = dtAuth.Rows[row]["name"].ToString();
                    Role role = new Role(roleId, roleName);
                    auth.Role = role;
                    if (auth.Update())
                    {
                        LogMan.Log2Sqlite(new Log(LogLevel.Info, EventType.权限管理, "修改权限：" + dtAuth.Rows[row]["name"].ToString() + "(" + oldName + "->" + roleName + ")", DateTime.Now));
                    }

                }
                catch (Exception ex)
                {
                    LogMan.Log2File(null, ex);
                }
            }
        }
        //选中角色列时显示下拉框
        private void dgvAuth_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvAuth.CurrentCell.ColumnIndex == 3)
                {
                    Rectangle rect = dgvAuth.GetCellDisplayRectangle(dgvAuth.CurrentCell.ColumnIndex, dgvAuth.CurrentCell.RowIndex, false);
                    string roleName = dgvAuth.CurrentCell.Value.ToString();
                    int selected = cmbRole.Items.IndexOf(roleName);
                    cmbRole.SelectedIndex = selected;
                    cmbRole.Left = rect.Left;
                    cmbRole.Top = rect.Top+1;
                    cmbRole.Width = rect.Width;
                    cmbRole.Height = rect.Height;
                    cmbRole.Visible = true;
                }
                else
                {
                    cmbRole.Visible = false;
                }
            }
            catch
            {
            }
        }
        //滚动或修改列宽时隐藏下拉框
        private void dgvAuth_Scroll(object sender, ScrollEventArgs e)
        {
            this.cmbRole.Visible = false;
        }
        private void dgvAuth_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            this.cmbRole.Visible = false;
        }

        private void mfbOK_Click(object sender, EventArgs e)
        {
            
        }
    }
}
