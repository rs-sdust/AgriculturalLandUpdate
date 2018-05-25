// ***********************************************************************
// Assembly         : AgriculturalLandUpdate
// Author           : RickerYan
// Created          : 05-23-2018
//
// Last Modified By : RickerYan
// Last Modified On : 05-23-2018
// ***********************************************************************
// <copyright file="frmAddUser.cs" company="SunGolden">
//     Copyright ©  2018
// </copyright>
// <summary>添加用户界面</summary>
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
using AgriculturalLandUpdate.Db;
using AgriculturalLandUpdate.Common;

namespace AgriculturalLandUpdate
{
    /// <summary>
    /// Class frmAddUser.
    /// </summary>
    /// <seealso cref="MaterialSkin.Controls.MaterialForm" />
    public partial class frmAddUser : MaterialForm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="frmAddUser"/> class.
        /// </summary>
        public frmAddUser()
        {
            InitializeComponent();
            ConstDef.materialSkinManager.AddFormToManage(this);
        }

        /// <summary>
        /// Handles the Click event of the mrbAdd control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mrbAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = this.msltUser.Text.Trim();
                string pwd = this.msltPwd.Text.Trim();
                string confirm = this.msltConfirm.Text.Trim();
                int roleId = cmbRole.SelectedIndex + 2;
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("用户名不能为空！", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (string.IsNullOrEmpty(pwd) || string.IsNullOrEmpty(confirm))
                {
                    MessageBox.Show("密码不能为空！", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (pwd != confirm)
                {
                    MessageBox.Show("两次输入密码不一致！", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    User user = User.Find(name);
                    if (user != null)
                    {
                        MessageBox.Show("用户已存在！", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        user = new User();
                        user.UserName = name;
                        user.Password =SunGolden.Encryption.DEncrypt.Encrypt(pwd);
                        user.RoleId = roleId;
                        if (!user.Insert())
                        {
                            MessageBox.Show("添加用户失败！", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("添加用户成功！", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            LogMan.Log2Sqlite(new Log(LogLevel.Info,EventType.用户管理,"添加用户："+name,DateTime.Now));
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogMan.Log2File(null, ex);
            }
        }

        /// <summary>
        /// Handles the Click event of the mrbCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void mrbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Load event of the frmAddUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void frmAddUser_Load(object sender, EventArgs e)
        {
            UIIni.LoadRoles(cmbRole);
        }


    }
}
