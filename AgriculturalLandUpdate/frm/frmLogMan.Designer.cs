namespace AgriculturalLandUpdate
{
    partial class frmLogMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogMan));
            this.mldate = new MaterialSkin.Controls.MaterialLabel();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.mlUser = new MaterialSkin.Controls.MaterialLabel();
            this.msltUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mfbQuery = new MaterialSkin.Controls.MaterialFlatButton();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.SuspendLayout();
            // 
            // mldate
            // 
            this.mldate.AutoSize = true;
            this.mldate.Depth = 0;
            this.mldate.Font = new System.Drawing.Font("Roboto", 11F);
            this.mldate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mldate.Location = new System.Drawing.Point(10, 14);
            this.mldate.MouseState = MaterialSkin.MouseState.HOVER;
            this.mldate.Name = "mldate";
            this.mldate.Size = new System.Drawing.Size(89, 19);
            this.mldate.TabIndex = 6;
            this.mldate.Text = "操作时间：";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(105, 12);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(150, 21);
            this.dtpStart.TabIndex = 1;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(261, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(41, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "至：";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(308, 12);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(150, 21);
            this.dtpEnd.TabIndex = 2;
            // 
            // mlUser
            // 
            this.mlUser.AutoSize = true;
            this.mlUser.Depth = 0;
            this.mlUser.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlUser.Location = new System.Drawing.Point(10, 49);
            this.mlUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlUser.Name = "mlUser";
            this.mlUser.Size = new System.Drawing.Size(89, 19);
            this.mlUser.TabIndex = 6;
            this.mlUser.Text = "操作用户：";
            // 
            // msltUser
            // 
            this.msltUser.Depth = 0;
            this.msltUser.Hint = "";
            this.msltUser.Location = new System.Drawing.Point(105, 45);
            this.msltUser.MaxLength = 32767;
            this.msltUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.msltUser.Name = "msltUser";
            this.msltUser.PasswordChar = '\0';
            this.msltUser.SelectedText = "";
            this.msltUser.SelectionLength = 0;
            this.msltUser.SelectionStart = 0;
            this.msltUser.Size = new System.Drawing.Size(150, 23);
            this.msltUser.TabIndex = 0;
            this.msltUser.TabStop = false;
            this.msltUser.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.mfbQuery);
            this.panel1.Controls.Add(this.dgvLog);
            this.panel1.Controls.Add(this.dtpStart);
            this.panel1.Controls.Add(this.msltUser);
            this.panel1.Controls.Add(this.dtpEnd);
            this.panel1.Controls.Add(this.mldate);
            this.panel1.Controls.Add(this.mlUser);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 448);
            this.panel1.TabIndex = 9;
            // 
            // mfbQuery
            // 
            this.mfbQuery.AutoSize = true;
            this.mfbQuery.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mfbQuery.Depth = 0;
            this.mfbQuery.Icon = null;
            this.mfbQuery.Location = new System.Drawing.Point(308, 42);
            this.mfbQuery.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mfbQuery.MouseState = MaterialSkin.MouseState.HOVER;
            this.mfbQuery.Name = "mfbQuery";
            this.mfbQuery.Primary = false;
            this.mfbQuery.Size = new System.Drawing.Size(102, 36);
            this.mfbQuery.TabIndex = 10;
            this.mfbQuery.Text = "立  即  查  询";
            this.mfbQuery.UseVisualStyleBackColor = true;
            this.mfbQuery.Click += new System.EventHandler(this.mfbQuery_Click);
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.AllowUserToOrderColumns = true;
            this.dgvLog.AllowUserToResizeRows = false;
            this.dgvLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLog.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.GridColor = System.Drawing.SystemColors.Control;
            this.dgvLog.Location = new System.Drawing.Point(5, 84);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.ReadOnly = true;
            this.dgvLog.RowHeadersVisible = false;
            this.dgvLog.RowTemplate.Height = 23;
            this.dgvLog.Size = new System.Drawing.Size(500, 354);
            this.dgvLog.TabIndex = 9;
            // 
            // frmLogMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 512);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogMan";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "日志管理";
            this.Load += new System.EventHandler(this.frmLogMan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel mldate;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private MaterialSkin.Controls.MaterialLabel mlUser;
        private MaterialSkin.Controls.MaterialSingleLineTextField msltUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvLog;
        private MaterialSkin.Controls.MaterialFlatButton mfbQuery;
    }
}