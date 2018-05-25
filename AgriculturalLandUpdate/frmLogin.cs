// ***********************************************************************
// Assembly         : AgriculturalLandUpdate
// Author           : RickerYan
// Created          : 05-21-2018
//
// Last Modified By : RickerYan
// Last Modified On : 05-24-2018
// ***********************************************************************
// <copyright file="frmLogin.cs" company="SunGolden">
//     Copyright ©  2018
// </copyright>
// <summary>登陆界面</summary>
// ***********************************************************************
using System;
using System.Configuration;
using System.Windows.Forms;
using AgriculturalLandUpdate.Db;
using MaterialSkin.Controls;

namespace AgriculturalLandUpdate
{
    public partial class frmLogin : MaterialForm
    {

        public frmLogin()
        {
            InitializeComponent();
            ConstDef.materialSkinManager.AddFormToManage(this);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //加载本地记录用户
            try
            {
                string user = ConfigurationManager.AppSettings["User"];
                if (string.IsNullOrEmpty(user))
                    return;
                this.msltUser.Text = user;
                string password = SunGolden.Encryption.DEncrypt.Decrypt(ConfigurationManager.AppSettings["Password"]);
                if (string.IsNullOrEmpty(password))
                    return;
                this.msltPwd.Text = password;
            }
            catch (Exception ex)
            {
                LogMan.Log2File(null, ex);
            }

        }

        private void mrbLogin_Click(object sender, EventArgs e)
        {

            if(!Login())
            {
                return;
            }
            if (this.mcbRember.Checked)
            {
                //打开配置文件
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["User"].Value = this.msltUser.Text;
                config.AppSettings.Settings["Password"].Value = SunGolden.Encryption.DEncrypt.Encrypt(this.msltPwd.Text);
                //保存配置
                config.Save();
                ConfigurationManager.RefreshSection("AppSettings");
            }
            LogMan.Log2Sqlite(new Log(LogLevel.Info, EventType.用户管理, "用户登陆：" + this.msltUser.Text, DateTime.Now));
            this.DialogResult = DialogResult.OK;
            
        }
        private void mrbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool Login()
        {
            if (string.IsNullOrEmpty(msltUser.Text))
            {
                MessageBox.Show("用户名不能为空！", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (string.IsNullOrEmpty(this.msltPwd.Text))
            {
                MessageBox.Show("密码不能为空！", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else 
            {
                Db.User user = null;
                try
                {
                    user = Db.User.Find(msltUser.Text.Trim());
                }
                catch(Exception ex) 
                {
                    LogMan.Log2File(null, ex);
                }
                if (user == null)
                {
                    MessageBox.Show("用户不存在！", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return false;
                }
                else if (user.Password != SunGolden.Encryption.DEncrypt.Encrypt(msltPwd.Text))
                {
                    MessageBox.Show("密码错误！", ConstMsg.Msg00, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return false;
                }
                else
                {
                    ConstDef.curUser = user;
                    return true;
                }
            }
        }
    }
}
