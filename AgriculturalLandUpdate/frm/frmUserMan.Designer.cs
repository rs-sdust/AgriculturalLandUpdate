namespace AgriculturalLandUpdate
{
    partial class frmUserMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserMan));
            this.msltFind = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mfbFind = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mfbAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // msltFind
            // 
            this.msltFind.Depth = 0;
            this.msltFind.Hint = "";
            this.msltFind.Location = new System.Drawing.Point(9, 21);
            this.msltFind.MaxLength = 32767;
            this.msltFind.MouseState = MaterialSkin.MouseState.HOVER;
            this.msltFind.Name = "msltFind";
            this.msltFind.PasswordChar = '\0';
            this.msltFind.SelectedText = "";
            this.msltFind.SelectionLength = 0;
            this.msltFind.SelectionStart = 0;
            this.msltFind.Size = new System.Drawing.Size(281, 23);
            this.msltFind.TabIndex = 0;
            this.msltFind.TabStop = false;
            this.msltFind.Text = "请输入用户名";
            this.msltFind.UseSystemPasswordChar = false;
            // 
            // mfbFind
            // 
            this.mfbFind.AutoSize = true;
            this.mfbFind.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mfbFind.Depth = 0;
            this.mfbFind.Icon = null;
            this.mfbFind.Location = new System.Drawing.Point(326, 8);
            this.mfbFind.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mfbFind.MouseState = MaterialSkin.MouseState.HOVER;
            this.mfbFind.Name = "mfbFind";
            this.mfbFind.Primary = true;
            this.mfbFind.Size = new System.Drawing.Size(81, 36);
            this.mfbFind.TabIndex = 1;
            this.mfbFind.Text = "查找用户";
            this.mfbFind.UseVisualStyleBackColor = true;
            this.mfbFind.Click += new System.EventHandler(this.mfbFind_Click);
            // 
            // mfbAdd
            // 
            this.mfbAdd.AutoSize = true;
            this.mfbAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mfbAdd.Depth = 0;
            this.mfbAdd.Icon = null;
            this.mfbAdd.Location = new System.Drawing.Point(417, 8);
            this.mfbAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mfbAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.mfbAdd.Name = "mfbAdd";
            this.mfbAdd.Primary = true;
            this.mfbAdd.Size = new System.Drawing.Size(81, 36);
            this.mfbAdd.TabIndex = 2;
            this.mfbAdd.Text = "添加用户";
            this.mfbAdd.UseVisualStyleBackColor = true;
            this.mfbAdd.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvUser);
            this.panel1.Controls.Add(this.mfbAdd);
            this.panel1.Controls.Add(this.msltFind);
            this.panel1.Controls.Add(this.mfbFind);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 447);
            this.panel1.TabIndex = 3;
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.AllowUserToOrderColumns = true;
            this.dgvUser.AllowUserToResizeColumns = false;
            this.dgvUser.AllowUserToResizeRows = false;
            this.dgvUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUser.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.GridColor = System.Drawing.SystemColors.Control;
            this.dgvUser.Location = new System.Drawing.Point(5, 50);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.RowTemplate.Height = 23;
            this.dgvUser.Size = new System.Drawing.Size(500, 390);
            this.dgvUser.TabIndex = 3;
            this.dgvUser.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUser_CellMouseDoubleClick);
            // 
            // frmUserMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 512);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserMan";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.frmUserMan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField msltFind;
        private MaterialSkin.Controls.MaterialRaisedButton mfbFind;
        private MaterialSkin.Controls.MaterialRaisedButton mfbAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvUser;
    }
}