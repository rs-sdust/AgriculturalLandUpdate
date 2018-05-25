namespace AgriculturalLandUpdate
{
    partial class ucPanelUpdate
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
            this.btnClassify = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAccuracy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClassify
            // 
            this.btnClassify.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClassify.FlatAppearance.BorderSize = 0;
            this.btnClassify.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClassify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClassify.Image = global::AgriculturalLandUpdate.Properties.Resources.classify32;
            this.btnClassify.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClassify.Location = new System.Drawing.Point(75, 0);
            this.btnClassify.Name = "btnClassify";
            this.btnClassify.Size = new System.Drawing.Size(90, 64);
            this.btnClassify.TabIndex = 7;
            this.btnClassify.Text = "农业用地分类";
            this.btnClassify.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClassify.UseVisualStyleBackColor = true;
            this.btnClassify.Click += new System.EventHandler(this.btnClassify_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTrain.FlatAppearance.BorderSize = 0;
            this.btnTrain.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrain.Image = global::AgriculturalLandUpdate.Properties.Resources.train32;
            this.btnTrain.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTrain.Location = new System.Drawing.Point(0, 0);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(75, 64);
            this.btnTrain.TabIndex = 6;
            this.btnTrain.Text = "模型训练";
            this.btnTrain.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Image = global::AgriculturalLandUpdate.Properties.Resources.update32;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.Location = new System.Drawing.Point(165, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 64);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "图斑更新";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAccuracy
            // 
            this.btnAccuracy.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAccuracy.FlatAppearance.BorderSize = 0;
            this.btnAccuracy.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAccuracy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccuracy.Image = global::AgriculturalLandUpdate.Properties.Resources.verify32;
            this.btnAccuracy.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAccuracy.Location = new System.Drawing.Point(240, 0);
            this.btnAccuracy.Name = "btnAccuracy";
            this.btnAccuracy.Size = new System.Drawing.Size(75, 64);
            this.btnAccuracy.TabIndex = 9;
            this.btnAccuracy.Text = "精度验证";
            this.btnAccuracy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAccuracy.UseVisualStyleBackColor = true;
            this.btnAccuracy.Click += new System.EventHandler(this.btnAccuracy_Click);
            // 
            // ucPanelUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnAccuracy);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClassify);
            this.Controls.Add(this.btnTrain);
            this.Name = "ucPanelUpdate";
            this.Size = new System.Drawing.Size(632, 64);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClassify;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAccuracy;
    }
}
