// ***********************************************************************
// Assembly         : AgriculturalLandUpdate
// Author           : RickerYan
// Created          : 05-23-2018
//
// Last Modified By : RickerYan
// Last Modified On : 05-24-2018
// ***********************************************************************
// <copyright file="frmLogMan.cs" company="SunGolden">
//     Copyright ©  2018
// </copyright>
// <summary>日志管理界面</summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using AgriculturalLandUpdate.Db;
using MaterialSkin.Controls;

namespace AgriculturalLandUpdate
{
    public partial class frmLogMan : MaterialForm
    {
        private DataTable dtLog = null;
        public frmLogMan()
        {
            InitializeComponent();
            ConstDef.materialSkinManager.AddFormToManage(this);
        }

        private void frmLogMan_Load(object sender, EventArgs e)
        {
            dtLog = new DataTable();
            DataColumn dataColumn0 = this.dtLog.Columns.Add("loglevel", Type.GetType("System.String"));
            DataColumn dataColumn1 = this.dtLog.Columns.Add("user", Type.GetType("System.String"));
            DataColumn dataColumn2 = this.dtLog.Columns.Add("eventtype", Type.GetType("System.String"));
            DataColumn dataColumn3 = this.dtLog.Columns.Add("message", Type.GetType("System.String"));
            DataColumn dataColumn4 = this.dtLog.Columns.Add("logtime", Type.GetType("System.DateTime"));
            //dtpStart.Value=dtpStart.Value.AddDays(-1.0);
            dtpEnd.Value = dtpEnd.Value.AddDays(1.0);
            queryLog();
        }
        private void mfbQuery_Click(object sender, EventArgs e)
        {
            queryLog();
        }
        private void queryLog()
        {
            string userName="";
            if(!string.IsNullOrEmpty(msltUser.Text.Trim()))
            {
                userName=msltUser.Text.Trim();
            }
            List<object[]> list = Log.Query( dtpStart.Value,dtpEnd.Value,userName);
            this.dtLog.Rows.Clear();
            foreach (object[] item in list)
            {
                this.dtLog.Rows.Add(item);
            }
            dgvLog.DataSource = dtLog;
            dgvLog.Columns[0].HeaderText = "日志级别";
            dgvLog.Columns[1].HeaderText = "操作用户";
            dgvLog.Columns[2].HeaderText = " 操作类型";
            dgvLog.Columns[3].HeaderText = "日志信息";
            dgvLog.Columns[4].HeaderText = " 操作时间";
            //动态列宽
            dgvLog.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvLog.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvLog.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvLog.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvLog.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }


    }
}
