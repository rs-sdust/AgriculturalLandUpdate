// ***********************************************************************
// Assembly         : AgriculturalLandUpdate
// Author           : RickerYan
// Created          : 05-22-2018
//
// Last Modified By : RickerYan
// Last Modified On : 05-24-2018
// ***********************************************************************
// <copyright file="ucPanelPrepro.cs" company="SunGolden">
//     Copyright ©  2018
// </copyright>
// <summary>预处理菜单</summary>
// ***********************************************************************
using System;
using System.Windows.Forms;
using AgriculturalLandUpdate.Db;

namespace AgriculturalLandUpdate
{
    public partial class ucPanelPrepro : UserControl
    {
        public ucPanelPrepro()
        {
            InitializeComponent();
        }

        private void btnCloudDetect_Click(object sender, EventArgs e)
        {
            if (!Authority.CheckAuth((sender as Button).Text))
            {
                MessageBox.Show("权限不足！", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnCloudPath_Click(object sender, EventArgs e)
        {
            if (!Authority.CheckAuth((sender as Button).Text))
            {
                MessageBox.Show("权限不足！", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnSampleCut_Click(object sender, EventArgs e)
        {
            if (!Authority.CheckAuth((sender as Button).Text))
            {
                MessageBox.Show("权限不足！", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
