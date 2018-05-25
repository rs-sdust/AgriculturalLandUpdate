namespace AgriculturalLandUpdate
{
    partial class ucPanelPrepro
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
            this.btnCloudPath = new System.Windows.Forms.Button();
            this.btnCloudDetect = new System.Windows.Forms.Button();
            this.btnSampleCut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCloudPath
            // 
            this.btnCloudPath.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloudPath.FlatAppearance.BorderSize = 0;
            this.btnCloudPath.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCloudPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloudPath.Image = global::AgriculturalLandUpdate.Properties.Resources.CloudPatch32;
            this.btnCloudPath.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCloudPath.Location = new System.Drawing.Point(80, 0);
            this.btnCloudPath.Name = "btnCloudPath";
            this.btnCloudPath.Size = new System.Drawing.Size(80, 64);
            this.btnCloudPath.TabIndex = 4;
            this.btnCloudPath.Text = "云/阴影修复";
            this.btnCloudPath.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCloudPath.UseVisualStyleBackColor = true;
            this.btnCloudPath.Click += new System.EventHandler(this.btnCloudPath_Click);
            // 
            // btnCloudDetect
            // 
            this.btnCloudDetect.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloudDetect.FlatAppearance.BorderSize = 0;
            this.btnCloudDetect.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCloudDetect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloudDetect.Image = global::AgriculturalLandUpdate.Properties.Resources.CloudDet32;
            this.btnCloudDetect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCloudDetect.Location = new System.Drawing.Point(0, 0);
            this.btnCloudDetect.Name = "btnCloudDetect";
            this.btnCloudDetect.Size = new System.Drawing.Size(80, 64);
            this.btnCloudDetect.TabIndex = 3;
            this.btnCloudDetect.Text = "云/阴影检测";
            this.btnCloudDetect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCloudDetect.UseVisualStyleBackColor = true;
            this.btnCloudDetect.Click += new System.EventHandler(this.btnCloudDetect_Click);
            // 
            // btnSampleCut
            // 
            this.btnSampleCut.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSampleCut.FlatAppearance.BorderSize = 0;
            this.btnSampleCut.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSampleCut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSampleCut.Image = global::AgriculturalLandUpdate.Properties.Resources.cut32;
            this.btnSampleCut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSampleCut.Location = new System.Drawing.Point(160, 0);
            this.btnSampleCut.Name = "btnSampleCut";
            this.btnSampleCut.Size = new System.Drawing.Size(80, 64);
            this.btnSampleCut.TabIndex = 5;
            this.btnSampleCut.Text = "样本分块";
            this.btnSampleCut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSampleCut.UseVisualStyleBackColor = true;
            this.btnSampleCut.Click += new System.EventHandler(this.btnSampleCut_Click);
            // 
            // ucPanelPrepro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnSampleCut);
            this.Controls.Add(this.btnCloudPath);
            this.Controls.Add(this.btnCloudDetect);
            this.Name = "ucPanelPrepro";
            this.Size = new System.Drawing.Size(632, 64);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCloudPath;
        private System.Windows.Forms.Button btnCloudDetect;
        private System.Windows.Forms.Button btnSampleCut;
    }
}
