// ***********************************************************************
// Assembly         : AgriculturalLandUpdate
// Author           : RickerYan
// Created          : 05-23-2018
//
// Last Modified By : RickerYan
// Last Modified On : 05-23-2018
// ***********************************************************************
// <copyright file="frmChPwd.cs" company="SunGolden">
//     Copyright ©  2018
// </copyright>
// <summary>密码修改界面</summary>
// ***********************************************************************
using System;
using System.Windows.Forms;
using AgriculturalLandUpdate.Db;
using MaterialSkin.Controls;

namespace AgriculturalLandUpdate
{
    public partial class frmChPwd : MaterialForm
    {
        public frmChPwd()
        {
            InitializeComponent();
            ConstDef.materialSkinManager.AddFormToManage(this);
        }
        private void frmChPwd_Load(object sender, EventArgs e)
        {
            if (ConstDef.curUser != null)
            {
                this.msltUser.Text = ConstDef.curUser.UserName;
                this.msltRole.Text = ConstDef.curUser.Role.Name;
            }
        }
        private void mrbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mrbAdd_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("确定要修改密码吗？", ConstMsg.Msg00, MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                string oldPwd = this.msltOldPwd.Text;
                string newPwd = this.msltNewPwd.Text;
                string confimPwd = this.msltConfimPwd.Text;
                if (string.IsNullOrEmpty(oldPwd) || SunGolden.Encryption.DEncrypt.Encrypt(oldPwd) != ConstDef.curUser.Password)
                {
                    MessageBox.Show("原密码错误，请重新输入！", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (string.IsNullOrEmpty(newPwd) || string.IsNullOrEmpty(confimPwd) || newPwd != confimPwd)
                {
                    MessageBox.Show("新密码为空或不一致，请重新输入！", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    ConstDef.curUser.Password = SunGolden.Encryption.DEncrypt.Encrypt(newPwd);
                    try
                    {
                        if (ConstDef.curUser.Update(true))
                        {
                            //消息提示
                            MessageBox.Show("修改成功，下次登陆请使用新密码。", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            //记录操作日志
                            LogMan.Log2Sqlite(new Log(LogLevel.Info, EventType.用户管理, "修改密码", DateTime.Now));
                        }
                    }
                    catch (Exception ex)
                    {
                        //提示错误信息
                        MessageBox.Show("修改失败："+ex.Message, ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //记录错误日志
                        Db.LogMan.Log2File(null, ex);
                    }
                }
                
            }
        }

    }
}
