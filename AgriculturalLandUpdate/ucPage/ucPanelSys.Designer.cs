namespace AgriculturalLandUpdate
{
    partial class ucPanelSys
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChPwd = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnAuth = new System.Windows.Forms.Button();
            this.btnUserMan = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChPwd
            // 
            this.btnChPwd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnChPwd.FlatAppearance.BorderSize = 0;
            this.btnChPwd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChPwd.Image = global::AgriculturalLandUpdate.Properties.Resources.chpwd32;
            this.btnChPwd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChPwd.Location = new System.Drawing.Point(225, 0);
            this.btnChPwd.Name = "btnChPwd";
            this.btnChPwd.Size = new System.Drawing.Size(75, 64);
            this.btnChPwd.TabIndex = 13;
            this.btnChPwd.Text = "修改密码";
            this.btnChPwd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChPwd.UseVisualStyleBackColor = true;
            this.btnChPwd.Click += new System.EventHandler(this.btnChPwd_Click);
            // 
            // btnLog
            // 
            this.btnLog.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLog.FlatAppearance.BorderSize = 0;
            this.btnLog.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Image = global::AgriculturalLandUpdate.Properties.Resources.log32;
            this.btnLog.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLog.Location = new System.Drawing.Point(150, 0);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 64);
            this.btnLog.TabIndex = 11;
            this.btnLog.Text = "日志管理";
            this.btnLog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnAuth
            // 
            this.btnAuth.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAuth.FlatAppearance.BorderSize = 0;
            this.btnAuth.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuth.Image = global::AgriculturalLandUpdate.Properties.Resources.auth32;
            this.btnAuth.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAuth.Location = new System.Drawing.Point(75, 0);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(75, 64);
            this.btnAuth.TabIndex = 10;
            this.btnAuth.Text = "权限管理";
            this.btnAuth.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAuth.UseVisualStyleBackColor = true;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // btnUserMan
            // 
            this.btnUserMan.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUserMan.FlatAppearance.BorderSize = 0;
            this.btnUserMan.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUserMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserMan.Image = global::AgriculturalLandUpdate.Properties.Resources.userMan32;
            this.btnUserMan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUserMan.Location = new System.Drawing.Point(0, 0);
            this.btnUserMan.Name = "btnUserMan";
            this.btnUserMan.Size = new System.Drawing.Size(75, 64);
            this.btnUserMan.TabIndex = 9;
            this.btnUserMan.Text = "用户管理";
            this.btnUserMan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUserMan.UseVisualStyleBackColor = true;
            this.btnUserMan.Click += new System.EventHandler(this.btnUserMan_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = global::AgriculturalLandUpdate.Properties.Resources.logout32;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.Location = new System.Drawing.Point(300, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 64);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "注销登陆";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // ucPanelSys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnChPwd);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnAuth);
            this.Controls.Add(this.btnUserMan);
            this.Name = "ucPanelSys";
            this.Size = new System.Drawing.Size(632, 64);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.Button btnUserMan;
        private System.Windows.Forms.Button btnChPwd;
        private System.Windows.Forms.Button btnLogout;
    }
}
