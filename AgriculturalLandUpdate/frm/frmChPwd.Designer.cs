namespace AgriculturalLandUpdate
{
    partial class frmChPwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChPwd));
            this.mrbCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mrbAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mlRole = new MaterialSkin.Controls.MaterialLabel();
            this.msltNewPwd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mlNewPwd = new MaterialSkin.Controls.MaterialLabel();
            this.msltOldPwd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.msltRole = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.msltConfimPwd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mlConfimPwd = new MaterialSkin.Controls.MaterialLabel();
            this.mlOldPwd = new MaterialSkin.Controls.MaterialLabel();
            this.msltUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mlUser = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrbCancel
            // 
            this.mrbCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mrbCancel.AutoSize = true;
            this.mrbCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mrbCancel.Depth = 0;
            this.mrbCancel.Icon = null;
            this.mrbCancel.Location = new System.Drawing.Point(122, 197);
            this.mrbCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbCancel.Name = "mrbCancel";
            this.mrbCancel.Primary = true;
            this.mrbCancel.Size = new System.Drawing.Size(51, 36);
            this.mrbCancel.TabIndex = 7;
            this.mrbCancel.Text = "取消";
            this.mrbCancel.UseVisualStyleBackColor = true;
            this.mrbCancel.Click += new System.EventHandler(this.mrbCancel_Click);
            // 
            // mrbAdd
            // 
            this.mrbAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mrbAdd.AutoSize = true;
            this.mrbAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mrbAdd.Depth = 0;
            this.mrbAdd.Icon = null;
            this.mrbAdd.Location = new System.Drawing.Point(221, 197);
            this.mrbAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbAdd.Name = "mrbAdd";
            this.mrbAdd.Primary = true;
            this.mrbAdd.Size = new System.Drawing.Size(51, 36);
            this.mrbAdd.TabIndex = 6;
            this.mrbAdd.Text = "修改";
            this.mrbAdd.UseVisualStyleBackColor = true;
            this.mrbAdd.Click += new System.EventHandler(this.mrbAdd_Click);
            // 
            // mlRole
            // 
            this.mlRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mlRole.AutoSize = true;
            this.mlRole.Depth = 0;
            this.mlRole.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlRole.Location = new System.Drawing.Point(27, 51);
            this.mlRole.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlRole.Name = "mlRole";
            this.mlRole.Size = new System.Drawing.Size(89, 19);
            this.mlRole.TabIndex = 4;
            this.mlRole.Text = "角        色：";
            // 
            // msltNewPwd
            // 
            this.msltNewPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msltNewPwd.Depth = 0;
            this.msltNewPwd.Hint = "";
            this.msltNewPwd.Location = new System.Drawing.Point(122, 117);
            this.msltNewPwd.MaxLength = 32767;
            this.msltNewPwd.MouseState = MaterialSkin.MouseState.HOVER;
            this.msltNewPwd.Name = "msltNewPwd";
            this.msltNewPwd.PasswordChar = '*';
            this.msltNewPwd.SelectedText = "";
            this.msltNewPwd.SelectionLength = 0;
            this.msltNewPwd.SelectionStart = 0;
            this.msltNewPwd.Size = new System.Drawing.Size(150, 23);
            this.msltNewPwd.TabIndex = 5;
            this.msltNewPwd.TabStop = false;
            this.msltNewPwd.UseSystemPasswordChar = false;
            // 
            // mlNewPwd
            // 
            this.mlNewPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mlNewPwd.AutoSize = true;
            this.mlNewPwd.Depth = 0;
            this.mlNewPwd.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlNewPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlNewPwd.Location = new System.Drawing.Point(27, 121);
            this.mlNewPwd.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlNewPwd.Name = "mlNewPwd";
            this.mlNewPwd.Size = new System.Drawing.Size(89, 19);
            this.mlNewPwd.TabIndex = 4;
            this.mlNewPwd.Text = "新  密  码：";
            // 
            // msltOldPwd
            // 
            this.msltOldPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msltOldPwd.Depth = 0;
            this.msltOldPwd.Hint = "";
            this.msltOldPwd.Location = new System.Drawing.Point(122, 82);
            this.msltOldPwd.MaxLength = 32767;
            this.msltOldPwd.MouseState = MaterialSkin.MouseState.HOVER;
            this.msltOldPwd.Name = "msltOldPwd";
            this.msltOldPwd.PasswordChar = '*';
            this.msltOldPwd.SelectedText = "";
            this.msltOldPwd.SelectionLength = 0;
            this.msltOldPwd.SelectionStart = 0;
            this.msltOldPwd.Size = new System.Drawing.Size(150, 23);
            this.msltOldPwd.TabIndex = 3;
            this.msltOldPwd.TabStop = false;
            this.msltOldPwd.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.msltRole);
            this.panel1.Controls.Add(this.mrbCancel);
            this.panel1.Controls.Add(this.mrbAdd);
            this.panel1.Controls.Add(this.mlRole);
            this.panel1.Controls.Add(this.msltConfimPwd);
            this.panel1.Controls.Add(this.mlConfimPwd);
            this.panel1.Controls.Add(this.msltNewPwd);
            this.panel1.Controls.Add(this.mlNewPwd);
            this.panel1.Controls.Add(this.msltOldPwd);
            this.panel1.Controls.Add(this.mlOldPwd);
            this.panel1.Controls.Add(this.msltUser);
            this.panel1.Controls.Add(this.mlUser);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 253);
            this.panel1.TabIndex = 3;
            // 
            // msltRole
            // 
            this.msltRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msltRole.Depth = 0;
            this.msltRole.Enabled = false;
            this.msltRole.Hint = "";
            this.msltRole.Location = new System.Drawing.Point(122, 47);
            this.msltRole.MaxLength = 32767;
            this.msltRole.MouseState = MaterialSkin.MouseState.HOVER;
            this.msltRole.Name = "msltRole";
            this.msltRole.PasswordChar = '\0';
            this.msltRole.SelectedText = "";
            this.msltRole.SelectionLength = 0;
            this.msltRole.SelectionStart = 0;
            this.msltRole.Size = new System.Drawing.Size(150, 23);
            this.msltRole.TabIndex = 8;
            this.msltRole.TabStop = false;
            this.msltRole.UseSystemPasswordChar = false;
            // 
            // msltConfimPwd
            // 
            this.msltConfimPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msltConfimPwd.Depth = 0;
            this.msltConfimPwd.Hint = "";
            this.msltConfimPwd.Location = new System.Drawing.Point(122, 152);
            this.msltConfimPwd.MaxLength = 32767;
            this.msltConfimPwd.MouseState = MaterialSkin.MouseState.HOVER;
            this.msltConfimPwd.Name = "msltConfimPwd";
            this.msltConfimPwd.PasswordChar = '*';
            this.msltConfimPwd.SelectedText = "";
            this.msltConfimPwd.SelectionLength = 0;
            this.msltConfimPwd.SelectionStart = 0;
            this.msltConfimPwd.Size = new System.Drawing.Size(150, 23);
            this.msltConfimPwd.TabIndex = 5;
            this.msltConfimPwd.TabStop = false;
            this.msltConfimPwd.UseSystemPasswordChar = false;
            // 
            // mlConfimPwd
            // 
            this.mlConfimPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mlConfimPwd.AutoSize = true;
            this.mlConfimPwd.Depth = 0;
            this.mlConfimPwd.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlConfimPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlConfimPwd.Location = new System.Drawing.Point(27, 156);
            this.mlConfimPwd.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlConfimPwd.Name = "mlConfimPwd";
            this.mlConfimPwd.Size = new System.Drawing.Size(89, 19);
            this.mlConfimPwd.TabIndex = 4;
            this.mlConfimPwd.Text = "确认密码：";
            // 
            // mlOldPwd
            // 
            this.mlOldPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mlOldPwd.AutoSize = true;
            this.mlOldPwd.Depth = 0;
            this.mlOldPwd.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlOldPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlOldPwd.Location = new System.Drawing.Point(27, 86);
            this.mlOldPwd.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlOldPwd.Name = "mlOldPwd";
            this.mlOldPwd.Size = new System.Drawing.Size(89, 19);
            this.mlOldPwd.TabIndex = 2;
            this.mlOldPwd.Text = "旧  密  码：";
            // 
            // msltUser
            // 
            this.msltUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msltUser.Depth = 0;
            this.msltUser.Enabled = false;
            this.msltUser.Hint = "";
            this.msltUser.Location = new System.Drawing.Point(122, 12);
            this.msltUser.MaxLength = 32767;
            this.msltUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.msltUser.Name = "msltUser";
            this.msltUser.PasswordChar = '\0';
            this.msltUser.SelectedText = "";
            this.msltUser.SelectionLength = 0;
            this.msltUser.SelectionStart = 0;
            this.msltUser.Size = new System.Drawing.Size(150, 23);
            this.msltUser.TabIndex = 1;
            this.msltUser.TabStop = false;
            this.msltUser.UseSystemPasswordChar = false;
            // 
            // mlUser
            // 
            this.mlUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mlUser.AutoSize = true;
            this.mlUser.Depth = 0;
            this.mlUser.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlUser.Location = new System.Drawing.Point(27, 16);
            this.mlUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlUser.Name = "mlUser";
            this.mlUser.Size = new System.Drawing.Size(89, 19);
            this.mlUser.TabIndex = 0;
            this.mlUser.Text = "用  户  名：";
            // 
            // frmChPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 320);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChPwd";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.frmChPwd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton mrbCancel;
        private MaterialSkin.Controls.MaterialRaisedButton mrbAdd;
        private MaterialSkin.Controls.MaterialLabel mlRole;
        private MaterialSkin.Controls.MaterialSingleLineTextField msltNewPwd;
        private MaterialSkin.Controls.MaterialLabel mlNewPwd;
        private MaterialSkin.Controls.MaterialSingleLineTextField msltOldPwd;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel mlOldPwd;
        private MaterialSkin.Controls.MaterialLabel mlUser;
        private MaterialSkin.Controls.MaterialSingleLineTextField msltRole;
        private MaterialSkin.Controls.MaterialSingleLineTextField msltUser;
        private MaterialSkin.Controls.MaterialSingleLineTextField msltConfimPwd;
        private MaterialSkin.Controls.MaterialLabel mlConfimPwd;
    }
}