namespace AgriculturalLandUpdate
{
    partial class frmEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditUser));
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.mrbCancel = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mrbOK = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mlRole = new MaterialSkin.Controls.MaterialLabel();
            this.msltUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mlUser = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(122, 54);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(150, 20);
            this.cmbRole.TabIndex = 8;
            // 
            // mrbCancel
            // 
            this.mrbCancel.AutoSize = true;
            this.mrbCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mrbCancel.Depth = 0;
            this.mrbCancel.Icon = null;
            this.mrbCancel.Location = new System.Drawing.Point(122, 98);
            this.mrbCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbCancel.Name = "mrbCancel";
            this.mrbCancel.Primary = true;
            this.mrbCancel.Size = new System.Drawing.Size(51, 36);
            this.mrbCancel.TabIndex = 7;
            this.mrbCancel.Text = "取消";
            this.mrbCancel.UseVisualStyleBackColor = true;
            this.mrbCancel.Click += new System.EventHandler(this.mrbCancel_Click);
            // 
            // mrbOK
            // 
            this.mrbOK.AutoSize = true;
            this.mrbOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mrbOK.Depth = 0;
            this.mrbOK.Icon = null;
            this.mrbOK.Location = new System.Drawing.Point(221, 98);
            this.mrbOK.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbOK.Name = "mrbOK";
            this.mrbOK.Primary = true;
            this.mrbOK.Size = new System.Drawing.Size(51, 36);
            this.mrbOK.TabIndex = 6;
            this.mrbOK.Text = "修改";
            this.mrbOK.UseVisualStyleBackColor = true;
            this.mrbOK.Click += new System.EventHandler(this.mrbOK_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbRole);
            this.panel1.Controls.Add(this.mrbCancel);
            this.panel1.Controls.Add(this.mrbOK);
            this.panel1.Controls.Add(this.mlRole);
            this.panel1.Controls.Add(this.msltUser);
            this.panel1.Controls.Add(this.mlUser);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 162);
            this.panel1.TabIndex = 3;
            // 
            // mlRole
            // 
            this.mlRole.AutoSize = true;
            this.mlRole.Depth = 0;
            this.mlRole.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlRole.Location = new System.Drawing.Point(27, 55);
            this.mlRole.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlRole.Name = "mlRole";
            this.mlRole.Size = new System.Drawing.Size(89, 19);
            this.mlRole.TabIndex = 4;
            this.mlRole.Text = "角        色：";
            // 
            // msltUser
            // 
            this.msltUser.Depth = 0;
            this.msltUser.Enabled = false;
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
            // mlUser
            // 
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
            // frmEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 229);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditUser";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编辑用户";
            this.Load += new System.EventHandler(this.frmEditUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRole;
        private MaterialSkin.Controls.MaterialRaisedButton mrbCancel;
        private MaterialSkin.Controls.MaterialRaisedButton mrbOK;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel mlRole;
        private MaterialSkin.Controls.MaterialSingleLineTextField msltUser;
        private MaterialSkin.Controls.MaterialLabel mlUser;
    }
}