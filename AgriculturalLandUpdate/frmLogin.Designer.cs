namespace AgriculturalLandUpdate
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mrbCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mrbLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mcbRember = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.msltPwd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.msltUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBoxBG = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mrbCancel);
            this.panel1.Controls.Add(this.mrbLogin);
            this.panel1.Controls.Add(this.mcbRember);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.msltPwd);
            this.panel1.Controls.Add(this.msltUser);
            this.panel1.Location = new System.Drawing.Point(183, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 260);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(66, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "用户登陆";
            // 
            // mrbCancel
            // 
            this.mrbCancel.AutoSize = true;
            this.mrbCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mrbCancel.Depth = 0;
            this.mrbCancel.Icon = null;
            this.mrbCancel.Location = new System.Drawing.Point(23, 202);
            this.mrbCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbCancel.Name = "mrbCancel";
            this.mrbCancel.Primary = true;
            this.mrbCancel.Size = new System.Drawing.Size(58, 36);
            this.mrbCancel.TabIndex = 20;
            this.mrbCancel.Text = "退  出  ";
            this.mrbCancel.UseVisualStyleBackColor = true;
            this.mrbCancel.Click += new System.EventHandler(this.mrbCancel_Click);
            // 
            // mrbLogin
            // 
            this.mrbLogin.AutoSize = true;
            this.mrbLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mrbLogin.Depth = 0;
            this.mrbLogin.Icon = null;
            this.mrbLogin.Location = new System.Drawing.Point(180, 202);
            this.mrbLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbLogin.Name = "mrbLogin";
            this.mrbLogin.Primary = true;
            this.mrbLogin.Size = new System.Drawing.Size(58, 36);
            this.mrbLogin.TabIndex = 19;
            this.mrbLogin.Text = "登  陆  ";
            this.mrbLogin.UseVisualStyleBackColor = true;
            this.mrbLogin.Click += new System.EventHandler(this.mrbLogin_Click);
            // 
            // mcbRember
            // 
            this.mcbRember.AutoSize = true;
            this.mcbRember.Checked = true;
            this.mcbRember.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mcbRember.Depth = 0;
            this.mcbRember.Font = new System.Drawing.Font("Roboto", 10F);
            this.mcbRember.Location = new System.Drawing.Point(98, 155);
            this.mcbRember.Margin = new System.Windows.Forms.Padding(0);
            this.mcbRember.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcbRember.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcbRember.Name = "mcbRember";
            this.mcbRember.Ripple = true;
            this.mcbRember.Size = new System.Drawing.Size(90, 30);
            this.mcbRember.TabIndex = 18;
            this.mcbRember.Text = "记住密码";
            this.mcbRember.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(19, 120);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(73, 19);
            this.materialLabel2.TabIndex = 15;
            this.materialLabel2.Text = "密    码：";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(19, 74);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(73, 19);
            this.materialLabel3.TabIndex = 16;
            this.materialLabel3.Text = "用户名：";
            // 
            // msltPwd
            // 
            this.msltPwd.Depth = 0;
            this.msltPwd.Hint = "";
            this.msltPwd.Location = new System.Drawing.Point(98, 119);
            this.msltPwd.MaxLength = 32767;
            this.msltPwd.MouseState = MaterialSkin.MouseState.HOVER;
            this.msltPwd.Name = "msltPwd";
            this.msltPwd.PasswordChar = '*';
            this.msltPwd.SelectedText = "";
            this.msltPwd.SelectionLength = 0;
            this.msltPwd.SelectionStart = 0;
            this.msltPwd.Size = new System.Drawing.Size(140, 23);
            this.msltPwd.TabIndex = 17;
            this.msltPwd.TabStop = false;
            this.msltPwd.UseSystemPasswordChar = false;
            // 
            // msltUser
            // 
            this.msltUser.Depth = 0;
            this.msltUser.Hint = "";
            this.msltUser.Location = new System.Drawing.Point(98, 74);
            this.msltUser.MaxLength = 32767;
            this.msltUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.msltUser.Name = "msltUser";
            this.msltUser.PasswordChar = '\0';
            this.msltUser.SelectedText = "";
            this.msltUser.SelectionLength = 0;
            this.msltUser.SelectionStart = 0;
            this.msltUser.Size = new System.Drawing.Size(140, 23);
            this.msltUser.TabIndex = 14;
            this.msltUser.TabStop = false;
            this.msltUser.UseSystemPasswordChar = false;
            // 
            // pictureBoxBG
            // 
            this.pictureBoxBG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxBG.BackgroundImage = global::AgriculturalLandUpdate.Properties.Resources.login;
            this.pictureBoxBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBG.Location = new System.Drawing.Point(1, 64);
            this.pictureBoxBG.Name = "pictureBoxBG";
            this.pictureBoxBG.Size = new System.Drawing.Size(638, 415);
            this.pictureBoxBG.TabIndex = 0;
            this.pictureBoxBG.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxBG);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "农业用地更新子系统";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton mrbCancel;
        private MaterialSkin.Controls.MaterialRaisedButton mrbLogin;
        private MaterialSkin.Controls.MaterialCheckBox mcbRember;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField msltPwd;
        private MaterialSkin.Controls.MaterialSingleLineTextField msltUser;



    }
}