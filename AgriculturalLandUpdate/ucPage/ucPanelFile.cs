// ***********************************************************************
// Assembly         : AgriculturalLandUpdate
// Author           : RickerYan
// Created          : 05-22-2018
//
// Last Modified By : RickerYan
// Last Modified On : 05-24-2018
// ***********************************************************************
// <copyright file="ucPanelFile.cs" company="SunGolden">
//     Copyright ©  2018
// </copyright>
// <summary>文件管理菜单</summary>
// ***********************************************************************
using System;
using System.Windows.Forms;
using AgriculturalLandUpdate.Db;

namespace AgriculturalLandUpdate
{
    public partial class ucPanelFile : UserControl
    {
        public ucPanelFile()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (!Authority.CheckAuth((sender as Button).Text))
            {
                MessageBox.Show("权限不足！", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (!Authority.CheckAuth((sender as Button).Text))
            {
                MessageBox.Show("权限不足！", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Authority.CheckAuth((sender as Button).Text))
            {
                MessageBox.Show("权限不足！", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
    }
}
