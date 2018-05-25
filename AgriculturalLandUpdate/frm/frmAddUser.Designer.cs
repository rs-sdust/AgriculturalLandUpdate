namespace AgriculturalLandUpdate
{
    partial class frmAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUser));
            this.mlUser = new MaterialSkin.Controls.MaterialLabel();
            this.msltUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.mrbCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mrbAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mlRole = new MaterialSkin.Controls.MaterialLabel();
            this.msltConfirm = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.msltPwd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mlPwd = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mlUser
            // 
            this.mlUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mlUser.AutoSize = true;
            this.mlUser.Depth = 0;
            this.mlUser.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlUser.Location = new System.Drawing.Point(27, 20);
            this.mlUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlUser.Name = "mlUser";
            this.mlUser.Size = new System.Drawing.Size(89, 19);
            this.mlUser.TabIndex = 0;
            this.mlUser.Text = "用  户  名：";
            // 
            // msltUser
            // 
            this.msltUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msltUser.Depth = 0;
            this.msltUser.Hint = "";
            this.msltUser.Location = new System.Drawing.Point(122, 16);
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbRole);
            this.panel1.Controls.Add(this.mrbCancel);
            this.panel1.Controls.Add(this.mrbAdd);
            this.panel1.Controls.Add(this.mlRole);
            this.panel1.Controls.Add(this.msltConfirm);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.msltPwd);
            this.panel1.Controls.Add(this.mlPwd);
            this.panel1.Controls.Add(this.msltUser);
            this.panel1.Controls.Add(this.mlUser);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 233);
            this.panel1.TabIndex = 2;
            // 
            // cmbRole
            // 
            this.cmbRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(122, 124);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(150, 20);
            this.cmbRole.TabIndex = 8;
            // 
            // mrbCancel
            // 
            this.mrbCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mrbCancel.AutoSize = true;
            this.mrbCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mrbCancel.Depth = 0;
            this.mrbCancel.Icon = null;
            this.mrbCancel.Location = new System.Drawing.Point(122, 170);
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
            this.mrbAdd.Location = new System.Drawing.Point(221, 170);
            this.mrbAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbAdd.Name = "mrbAdd";
            this.mrbAdd.Primary = true;
            this.mrbAdd.Size = new System.Drawing.Size(51, 36);
            this.mrbAdd.TabIndex = 6;
            this.mrbAdd.Text = "添加";
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
            this.mlRole.Location = new System.Drawing.Point(27, 125);
            this.mlRole.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlRole.Name = "mlRole";
            this.mlRole.Size = new System.Drawing.Size(89, 19);
            this.mlRole.TabIndex = 4;
            this.mlRole.Text = "角        色：";
            // 
            // msltConfirm
            // 
            this.msltConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msltConfirm.Depth = 0;
            this.msltConfirm.Hint = "";
            this.msltConfirm.Location = new System.Drawing.Point(122, 86);
            this.msltConfirm.MaxLength = 32767;
            this.msltConfirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.msltConfirm.Name = "msltConfirm";
            this.msltConfirm.PasswordChar = '*';
            this.msltConfirm.SelectedText = "";
            this.msltConfirm.SelectionLength = 0;
            this.msltConfirm.SelectionStart = 0;
            this.msltConfirm.Size = new System.Drawing.Size(150, 23);
            this.msltConfirm.TabIndex = 5;
            this.msltConfirm.TabStop = false;
            this.msltConfirm.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(27, 90);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(89, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "确认密码：";
            // 
            // msltPwd
            // 
            this.msltPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msltPwd.Depth = 0;
            this.msltPwd.Hint = "";
            this.msltPwd.Location = new System.Drawing.Point(122, 51);
            this.msltPwd.MaxLength = 32767;
            this.msltPwd.MouseState = MaterialSkin.MouseState.HOVER;
            this.msltPwd.Name = "msltPwd";
            this.msltPwd.PasswordChar = '*';
            this.msltPwd.SelectedText = "";
            this.msltPwd.SelectionLength = 0;
            this.msltPwd.SelectionStart = 0;
            this.msltPwd.Size = new System.Drawing.Size(150, 23);
            this.msltPwd.TabIndex = 3;
            this.msltPwd.TabStop = false;
            this.msltPwd.UseSystemPasswordChar = false;
            // 
            // mlPwd
            // 
            this.mlPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mlPwd.AutoSize = true;
            this.mlPwd.Depth = 0;
            this.mlPwd.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlPwd.Location = new System.Drawing.Point(27, 55);
            this.mlPwd.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlPwd.Name = "mlPwd";
            this.mlPwd.Size = new System.Drawing.Size(89, 19);
            this.mlPwd.TabIndex = 2;
            this.mlPwd.Text = "密        码：";
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddUser";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加用户";
            this.Load += new System.EventHandler(this.frmAddUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel mlUser;
        private MaterialSkin.Controls.MaterialSingleLineTextField msltUser;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton mrbCancel;
        private MaterialSkin.Controls.MaterialRaisedButton mrbAdd;
        private MaterialSkin.Controls.MaterialLabel mlRole;
        private MaterialSkin.Controls.MaterialSingleLineTextField msltConfirm;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField msltPwd;
        private MaterialSkin.Controls.MaterialLabel mlPwd;
        private System.Windows.Forms.ComboBox cmbRole;
    }
}