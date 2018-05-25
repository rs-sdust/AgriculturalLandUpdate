// ***********************************************************************
// Assembly         : AgriculturalLandUpdate
// Author           : RickerYan
// Created          : 05-23-2018
//
// Last Modified By : RickerYan
// Last Modified On : 05-23-2018
// ***********************************************************************
// <copyright file="frmEditUser.cs" company="SunGolden">
//     Copyright ©  2018
// </copyright>
// <summary>编辑用户界面</summary>
// ***********************************************************************
using System;
using System.Windows.Forms;
using AgriculturalLandUpdate.Common;
using AgriculturalLandUpdate.Db;
using MaterialSkin.Controls;

namespace AgriculturalLandUpdate
{
    public partial class frmEditUser : MaterialForm
    {
        private User selectedUser=null;
        public frmEditUser(User user)
        {
            InitializeComponent();
            ConstDef.materialSkinManager.AddFormToManage(this);
            selectedUser = user;
        }

        private void frmEditUser_Load(object sender, EventArgs e)
        {
            this.msltUser.Text = selectedUser.UserName;
            UIIni.LoadRoles(cmbRole);
            cmbRole.SelectedIndex = selectedUser.RoleId-2;
        }

        private void mrbOK_Click(object sender, EventArgs e)
        {
            int newRoleId = cmbRole.SelectedIndex + 2;
            try
            {
                if (newRoleId != selectedUser.RoleId)
                {
                    selectedUser.RoleId = newRoleId;
                    selectedUser.Update(true);
                    LogMan.Log2Sqlite(new Log(LogLevel.Info, EventType.用户管理, "修改用户角色：" + selectedUser.UserName+"("+selectedUser.Role.Name+"->"+cmbRole.Text+")", DateTime.Now));
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                LogMan.Log2File(null,ex);
            }
        }

        private void mrbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
