// ***********************************************************************
// Assembly         : AgriculturalLandUpdate
// Author           : RickerYan
// Created          : 05-22-2018
//
// Last Modified By : RickerYan
// Last Modified On : 05-24-2018
// ***********************************************************************
// <copyright file="ucPanelSys.cs" company="SunGolden">
//     Copyright ©  2018
// </copyright>
// <summary>系统管理菜单</summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AgriculturalLandUpdate.Db;

namespace AgriculturalLandUpdate
{
    public partial class ucPanelSys : UserControl
    {
        public ucPanelSys()
        {
            InitializeComponent();
        }

        private void btnUserMan_Click(object sender, EventArgs e)
        {
            if (ConstDef.curUser.RoleId > 2)
            {
                MessageBox.Show("权限不足", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmUserMan frm = new frmUserMan();
            frm.ShowDialog();
        }
        private void btnAuth_Click(object sender, EventArgs e)
        {
            if (!Authority.CheckAuth((sender as Button).Text))
            {
                MessageBox.Show("权限不足！", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmAuthorityMan frm = new frmAuthorityMan();
            frm.ShowDialog();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (!Authority.CheckAuth((sender as Button).Text))
            {
                MessageBox.Show("权限不足！", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmLogMan frm = new frmLogMan();
            frm.ShowDialog();
        }
        private void btnChPwd_Click(object sender, EventArgs e)
        {
            frmChPwd frm = new frmChPwd();
            frm.ShowDialog();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("确定要注销当前用户吗？", ConstMsg.Msg00, MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                Application.Restart();
            }
        }




    }
}
