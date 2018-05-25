// ***********************************************************************
// Assembly         : AgriculturalLandUpdate
// Author           : RickerYan
// Created          : 05-23-2018
//
// Last Modified By : RickerYan
// Last Modified On : 05-24-2018
// ***********************************************************************
// <copyright file="frmUserMan.cs" company="SunGolden">
//     Copyright ©  2018
// </copyright>
// <summary>用户管理界面</summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;
using AgriculturalLandUpdate.Db;

namespace AgriculturalLandUpdate
{
    public partial class frmUserMan : MaterialForm
    {
        private DataTable dtUsers=null;
        public frmUserMan()
        {
            InitializeComponent();
            ConstDef.materialSkinManager.AddFormToManage(this);
        }
        private void frmUserMan_Load(object sender, EventArgs e)
        {
            dtUsers = new DataTable();
            DataColumn dataColumn0 = this.dtUsers.Columns.Add("username", Type.GetType("System.String"));
            DataColumn dataColumn1 = this.dtUsers.Columns.Add("rolename", Type.GetType("System.String"));
            DataColumn dataColumn2 = this.dtUsers.Columns.Add("delete", Type.GetType("System.String"));
            DataColumn dataColumn3 = this.dtUsers.Columns.Add("edit", Type.GetType("System.String"));
            LoadUsers("");
        }
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            frmAddUser frm = new frmAddUser();
            if (DialogResult.OK == frm.ShowDialog())
            {
                LoadUsers("");
            }
        }

        private void mfbFind_Click(object sender, EventArgs e)
        {
            string name = this.msltFind.Text.Trim();
            if (string.IsNullOrEmpty(name) || name == "请输入用户名")
            {
                this.LoadUsers("");
            }
            else
            {
                this.LoadUsers("username like '%" + name + "%'");
            }
        }

        private void dgvUser_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewCell selectedCell=dgvUser.SelectedCells[0];
                string text = selectedCell.Value.ToString();
                string uName = dgvUser.Rows[selectedCell.RowIndex].Cells[0].Value.ToString();
                User user = User.Find(uName);
                if(user!=null)
                {
                    EditUser(user,text);
                }
            //    if (text == "删除")
            //    {
            //        string uName = dgvUser.Rows[selectedCell.RowIndex].Cells[0].Value.ToString();
            //        string uRole = dgvUser.Rows[selectedCell.RowIndex].Cells[1].Value.ToString();
            //        if (uRole == "超级管理员")
            //        {
            //            MessageBox.Show("不能删除超级管理员账户", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }
            //        else if (uRole == "管理员")
            //        {
            //            if (ConstDef.curUser.RoleId == 1)
            //            {
            //                if (DialogResult.OK == MessageBox.Show(string.Format("删除账户：{0} ？", uName), ConstMsg.Msg00, MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            //                {
            //                    User user = User.Find(uName);
            //                    user.Delete();
            //                    LogMan.Log2Sqlite(new Log(LogLevel.Info, EventType.用户管理, "删除用户：" + uName, DateTime.Now));
            //                    LoadUsers("");
            //                }
            //            }
            //            else
            //            {
            //                if (uName != ConstDef.curUser.UserName)
            //                {
            //                    MessageBox.Show("权限不足：删除其他管理员账户请使用超级管理员登陆！", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                }
            //                else
            //                {
            //                    if (DialogResult.OK == MessageBox.Show("已使用所选账户登陆，是否删除？", ConstMsg.Msg00, MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            //                    {
            //                        ConstDef.curUser.Delete();
            //                        LogMan.Log2Sqlite(new Log(LogLevel.Info, EventType.用户管理, "删除用户：" + uName, DateTime.Now));
            //                        Application.Restart();
            //                    }
            //                }
            //            }
            //        }
            //        else
            //        {
            //            if (DialogResult.OK == MessageBox.Show(string.Format("删除账户：{0} ？",uName), ConstMsg.Msg00, MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            //            {
            //                User user = User.Find(uName);
            //                user.Delete();
            //                LogMan.Log2Sqlite(new Log(LogLevel.Info, EventType.用户管理, "删除用户：" + uName, DateTime.Now));
            //                LoadUsers("");
            //            }
            //        }

            //    }
            //    else if(text)
            }
            catch (Exception ex)
            {
                LogMan.Log2File(null, ex);
            }
        }

        private void EditUser(User user,string opration)
        {
            if (opration == "删除")
            {
                if (user.RoleId == 1)
                {
                    MessageBox.Show("不能删除超级管理员账户", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (user.RoleId == 2)
                {
                    if (ConstDef.curUser.RoleId == 1)
                    {
                        if (DialogResult.OK == MessageBox.Show(string.Format("删除账户：{0} ？", user.UserName), ConstMsg.Msg00, MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                        {
                            user.Delete();
                            LogMan.Log2Sqlite(new Log(LogLevel.Info, EventType.用户管理, "删除用户：" + user.UserName, DateTime.Now));
                            LoadUsers("");
                        }
                    }
                    else
                    {
                        if (user.UserName != ConstDef.curUser.UserName)
                        {
                            MessageBox.Show("权限不足：删除其他管理员账户请使用超级管理员登陆！", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (DialogResult.OK == MessageBox.Show("已使用所选账户登陆，是否删除？", ConstMsg.Msg00, MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                            {
                                ConstDef.curUser.Delete();
                                LogMan.Log2Sqlite(new Log(LogLevel.Info, EventType.用户管理, "删除用户：" + user.UserName, DateTime.Now));
                                Application.Restart();
                            }
                        }
                    }
                }
                else
                {
                    if (DialogResult.OK == MessageBox.Show(string.Format("删除账户：{0} ？", user.UserName), ConstMsg.Msg00, MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                    {
                        user.Delete();
                        LogMan.Log2Sqlite(new Log(LogLevel.Info, EventType.用户管理, "删除用户：" + user.UserName, DateTime.Now));
                        LoadUsers("");
                    }
                }

            }
            else if (opration == "编辑")
            {
                if (user.RoleId == 1)
                {
                    MessageBox.Show("不能编辑超级管理员账户", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (user.RoleId == 2)
                {
                    if (ConstDef.curUser.RoleId == 1)
                    {
                        //su编辑管理员角色
                        if (DialogResult.OK ==new frmEditUser(user).ShowDialog())
                        {
                            LoadUsers("");
                        }
                    }
                    else
                    {
                        if (user.UserName  != ConstDef.curUser.UserName)
                        {
                            MessageBox.Show("权限不足：编辑其他管理员账户请使用超级管理员登陆！", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            //管理员用户编辑自己角色
                            if (DialogResult.OK == new frmEditUser(user).ShowDialog())
                            {
                                if (user.UserName == ConstDef.curUser.UserName)
                                {
                                    ConstDef.curUser = User.Find(user.UserName);
                                }
                                if (ConstDef.curUser.RoleId > 2)
                                {
                                    this.Close();
                                }
                                else
                                {
                                    LoadUsers("");
                                }
                            }
                        }
                    }
                }
                //管理员编辑普通用户
                else
                {
                    if (DialogResult.OK == new frmEditUser(user).ShowDialog())
                    {
                        LoadUsers("");
                    }
                }
            }
        }

        private void LoadUsers(string where)
        {
            try
            {
                List<User> list = User.Query(where);
                dtUsers.Rows.Clear();
                foreach (User item in list)
                {
                    string roleName = item.Role.Name;
                    dtUsers.Rows.Add(item.UserName, roleName, "删除","编辑");
                }
                dgvUser.DataSource = dtUsers;
                dgvUser.Columns[0].HeaderText = "用户名";
                dgvUser.Columns[1].HeaderText = "角色名";
                dgvUser.Columns[2].HeaderText = "删除";
                dgvUser.Columns[3].HeaderText = "编辑";
                Font font= new Font("宋体", 9f, (System.Drawing.FontStyle)System.Drawing.FontStyle.Underline);
                dgvUser.Columns[2].DefaultCellStyle.Font = dgvUser.Columns[3].DefaultCellStyle.Font = font;
                dgvUser.Columns[2].DefaultCellStyle.ForeColor = dgvUser.Columns[3].DefaultCellStyle.ForeColor = Color.Blue;
                //dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //动态列宽
                dgvUser.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvUser.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvUser.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvUser.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                LogMan.Log2File(null, ex);
            }
        }


    }
}
