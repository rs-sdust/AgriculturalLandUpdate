// ***********************************************************************
// Assembly         : AgriculturalLandUpdate
// Author           : RickerYan
// Created          : 05-22-2018
//
// Last Modified By : RickerYan
// Last Modified On : 05-24-2018
// ***********************************************************************
// <copyright file="ucPanelUpdate.cs" company="SunGolden">
//     Copyright ©  2018
// </copyright>
// <summary>农业用地更新菜单</summary>
// ***********************************************************************
using System;
using System.Windows.Forms;
using AgriculturalLandUpdate.Db;

namespace AgriculturalLandUpdate
{
    public partial class ucPanelUpdate : UserControl
    {
        public ucPanelUpdate()
        {
            InitializeComponent();
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            if (!Authority.CheckAuth((sender as Button).Text))
            {
                MessageBox.Show("权限不足！", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnClassify_Click(object sender, EventArgs e)
        {
            if (!Authority.CheckAuth((sender as Button).Text))
            {
                MessageBox.Show("权限不足！", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!Authority.CheckAuth((sender as Button).Text))
            {
                MessageBox.Show("权限不足！", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnAccuracy_Click(object sender, EventArgs e)
        {
            if (!Authority.CheckAuth((sender as Button).Text))
            {
                MessageBox.Show("权限不足！", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
