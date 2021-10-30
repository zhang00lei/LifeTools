namespace MyToolsForHer
{
    partial class ImgToWordForm
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
            this.btnStart = new System.Windows.Forms.Button();
            this.OpenImgDir = new System.Windows.Forms.FolderBrowserDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.btnGenWordPath = new System.Windows.Forms.Button();
            this.btnImgPath = new System.Windows.Forms.Button();
            this.btnConfigPath = new System.Windows.Forms.Button();
            this.TBStatistical = new System.Windows.Forms.TextBox();
            this.TBWordPath = new System.Windows.Forms.TextBox();
            this.TbImgPath = new System.Windows.Forms.TextBox();
            this.TBConfigPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnOpenConfig = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TbSecondTitle = new System.Windows.Forms.TextBox();
            this.TbThirdTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbWordName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(217, 277);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(118, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "生成";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "config.csv";
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(468, 140);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(65, 23);
            this.BtnOpen.TabIndex = 9;
            this.BtnOpen.Text = "打开";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // btnGenWordPath
            // 
            this.btnGenWordPath.Location = new System.Drawing.Point(16, 96);
            this.btnGenWordPath.Name = "btnGenWordPath";
            this.btnGenWordPath.Size = new System.Drawing.Size(90, 23);
            this.btnGenWordPath.TabIndex = 11;
            this.btnGenWordPath.Text = "生成word路径";
            this.btnGenWordPath.UseVisualStyleBackColor = true;
            this.btnGenWordPath.Click += new System.EventHandler(this.btnGenWordPath_Click);
            // 
            // btnImgPath
            // 
            this.btnImgPath.Location = new System.Drawing.Point(16, 58);
            this.btnImgPath.Name = "btnImgPath";
            this.btnImgPath.Size = new System.Drawing.Size(90, 23);
            this.btnImgPath.TabIndex = 12;
            this.btnImgPath.Text = "图片路径";
            this.btnImgPath.UseVisualStyleBackColor = true;
            this.btnImgPath.Click += new System.EventHandler(this.btnImgPath_Click);
            // 
            // btnConfigPath
            // 
            this.btnConfigPath.Location = new System.Drawing.Point(16, 20);
            this.btnConfigPath.Name = "btnConfigPath";
            this.btnConfigPath.Size = new System.Drawing.Size(90, 23);
            this.btnConfigPath.TabIndex = 13;
            this.btnConfigPath.Text = "配置表路径";
            this.btnConfigPath.UseVisualStyleBackColor = true;
            this.btnConfigPath.Click += new System.EventHandler(this.btnConfigPath_Click);
            // 
            // TBStatistical
            // 
            this.TBStatistical.Location = new System.Drawing.Point(124, 141);
            this.TBStatistical.Name = "TBStatistical";
            this.TBStatistical.ReadOnly = true;
            this.TBStatistical.Size = new System.Drawing.Size(338, 21);
            this.TBStatistical.TabIndex = 5;
            // 
            // TBWordPath
            // 
            this.TBWordPath.Location = new System.Drawing.Point(124, 97);
            this.TBWordPath.Name = "TBWordPath";
            this.TBWordPath.ReadOnly = true;
            this.TBWordPath.Size = new System.Drawing.Size(409, 21);
            this.TBWordPath.TabIndex = 6;
            // 
            // TbImgPath
            // 
            this.TbImgPath.Location = new System.Drawing.Point(124, 59);
            this.TbImgPath.Name = "TbImgPath";
            this.TbImgPath.ReadOnly = true;
            this.TbImgPath.Size = new System.Drawing.Size(409, 21);
            this.TbImgPath.TabIndex = 7;
            // 
            // TBConfigPath
            // 
            this.TBConfigPath.Location = new System.Drawing.Point(124, 21);
            this.TBConfigPath.Name = "TBConfigPath";
            this.TBConfigPath.ReadOnly = true;
            this.TBConfigPath.Size = new System.Drawing.Size(338, 21);
            this.TBConfigPath.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "统计信息路径：";
            // 
            // BtnOpenConfig
            // 
            this.BtnOpenConfig.Location = new System.Drawing.Point(468, 20);
            this.BtnOpenConfig.Name = "BtnOpenConfig";
            this.BtnOpenConfig.Size = new System.Drawing.Size(65, 23);
            this.BtnOpenConfig.TabIndex = 9;
            this.BtnOpenConfig.Text = "打开";
            this.BtnOpenConfig.UseVisualStyleBackColor = true;
            this.BtnOpenConfig.Click += new System.EventHandler(this.BtnOpenConfig_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "二级标题标记：";
            // 
            // TbSecondTitle
            // 
            this.TbSecondTitle.Location = new System.Drawing.Point(124, 184);
            this.TbSecondTitle.Name = "TbSecondTitle";
            this.TbSecondTitle.Size = new System.Drawing.Size(103, 21);
            this.TbSecondTitle.TabIndex = 5;
            this.TbSecondTitle.Text = "合同扫描件";
            // 
            // TbThirdTitle
            // 
            this.TbThirdTitle.Location = new System.Drawing.Point(390, 185);
            this.TbThirdTitle.Name = "TbThirdTitle";
            this.TbThirdTitle.Size = new System.Drawing.Size(103, 21);
            this.TbThirdTitle.TabIndex = 5;
            this.TbThirdTitle.Text = "记账联";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "三级标题标记：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "生成word名字：";
            // 
            // TbWordName
            // 
            this.TbWordName.Location = new System.Drawing.Point(124, 230);
            this.TbWordName.Name = "TbWordName";
            this.TbWordName.Size = new System.Drawing.Size(103, 21);
            this.TbWordName.TabIndex = 5;
            this.TbWordName.Text = "MyWord";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = ".doc";
            // 
            // ImgToWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 317);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.BtnOpenConfig);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.btnGenWordPath);
            this.Controls.Add(this.btnImgPath);
            this.Controls.Add(this.btnConfigPath);
            this.Controls.Add(this.TbThirdTitle);
            this.Controls.Add(this.TbWordName);
            this.Controls.Add(this.TbSecondTitle);
            this.Controls.Add(this.TBStatistical);
            this.Controls.Add(this.TBWordPath);
            this.Controls.Add(this.TbImgPath);
            this.Controls.Add(this.TBConfigPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ImgToWordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图片转化Word";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImgToWordForm_FormClosing);
            this.Load += new System.EventHandler(this.ImgToWordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.FolderBrowserDialog OpenImgDir;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Button btnGenWordPath;
        private System.Windows.Forms.Button btnImgPath;
        private System.Windows.Forms.Button btnConfigPath;
        private System.Windows.Forms.TextBox TBStatistical;
        private System.Windows.Forms.TextBox TBWordPath;
        private System.Windows.Forms.TextBox TbImgPath;
        private System.Windows.Forms.TextBox TBConfigPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnOpenConfig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbSecondTitle;
        private System.Windows.Forms.TextBox TbThirdTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbWordName;
        private System.Windows.Forms.Label label5;
    }
}