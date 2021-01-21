namespace MyToolsForHer
{
    partial class ResetName
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
            this.TbConfgPath = new System.Windows.Forms.TextBox();
            this.BtnSelectConfig = new System.Windows.Forms.Button();
            this.BtnSelectDir = new System.Windows.Forms.Button();
            this.TbTarget = new System.Windows.Forms.TextBox();
            this.BtnResetName = new System.Windows.Forms.Button();
            this.DirectoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.BtnOpenConfig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TbInfo = new System.Windows.Forms.TextBox();
            this.BtnStat = new System.Windows.Forms.Button();
            this.SelectFileDia = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // TbConfgPath
            // 
            this.TbConfgPath.Location = new System.Drawing.Point(142, 25);
            this.TbConfgPath.Name = "TbConfgPath";
            this.TbConfgPath.ReadOnly = true;
            this.TbConfgPath.Size = new System.Drawing.Size(262, 21);
            this.TbConfgPath.TabIndex = 1;
            // 
            // BtnSelectConfig
            // 
            this.BtnSelectConfig.Location = new System.Drawing.Point(12, 24);
            this.BtnSelectConfig.Name = "BtnSelectConfig";
            this.BtnSelectConfig.Size = new System.Drawing.Size(116, 23);
            this.BtnSelectConfig.TabIndex = 2;
            this.BtnSelectConfig.Text = "选择配置文件";
            this.BtnSelectConfig.UseVisualStyleBackColor = true;
            this.BtnSelectConfig.Click += new System.EventHandler(this.BtnSelectConfig_Click);
            // 
            // BtnSelectDir
            // 
            this.BtnSelectDir.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSelectDir.Location = new System.Drawing.Point(12, 83);
            this.BtnSelectDir.Name = "BtnSelectDir";
            this.BtnSelectDir.Size = new System.Drawing.Size(117, 23);
            this.BtnSelectDir.TabIndex = 2;
            this.BtnSelectDir.Text = "选择目标目录/文件";
            this.BtnSelectDir.UseVisualStyleBackColor = true;
            this.BtnSelectDir.Click += new System.EventHandler(this.BtnSelectDir_Click);
            // 
            // TbTarget
            // 
            this.TbTarget.Location = new System.Drawing.Point(142, 80);
            this.TbTarget.Name = "TbTarget";
            this.TbTarget.ReadOnly = true;
            this.TbTarget.Size = new System.Drawing.Size(344, 21);
            this.TbTarget.TabIndex = 1;
            // 
            // BtnResetName
            // 
            this.BtnResetName.Location = new System.Drawing.Point(217, 179);
            this.BtnResetName.Name = "BtnResetName";
            this.BtnResetName.Size = new System.Drawing.Size(75, 23);
            this.BtnResetName.TabIndex = 3;
            this.BtnResetName.Text = "重命名";
            this.BtnResetName.UseVisualStyleBackColor = true;
            this.BtnResetName.Click += new System.EventHandler(this.BtnResetName_Click);
            // 
            // BtnOpenConfig
            // 
            this.BtnOpenConfig.Location = new System.Drawing.Point(411, 23);
            this.BtnOpenConfig.Name = "BtnOpenConfig";
            this.BtnOpenConfig.Size = new System.Drawing.Size(75, 23);
            this.BtnOpenConfig.TabIndex = 4;
            this.BtnOpenConfig.Text = "打开";
            this.BtnOpenConfig.UseVisualStyleBackColor = true;
            this.BtnOpenConfig.Click += new System.EventHandler(this.BtnOpenConfig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "统计信息";
            // 
            // TbInfo
            // 
            this.TbInfo.Location = new System.Drawing.Point(142, 137);
            this.TbInfo.Name = "TbInfo";
            this.TbInfo.ReadOnly = true;
            this.TbInfo.Size = new System.Drawing.Size(262, 21);
            this.TbInfo.TabIndex = 5;
            // 
            // BtnStat
            // 
            this.BtnStat.Location = new System.Drawing.Point(410, 135);
            this.BtnStat.Name = "BtnStat";
            this.BtnStat.Size = new System.Drawing.Size(75, 23);
            this.BtnStat.TabIndex = 4;
            this.BtnStat.Text = "打开";
            this.BtnStat.UseVisualStyleBackColor = true;
            this.BtnStat.Click += new System.EventHandler(this.BtnStat_Click);
            // 
            // SelectFileDia
            // 
            this.SelectFileDia.FileName = "openFileDialog1";
            // 
            // ResetName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 214);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbInfo);
            this.Controls.Add(this.BtnStat);
            this.Controls.Add(this.BtnOpenConfig);
            this.Controls.Add(this.BtnResetName);
            this.Controls.Add(this.BtnSelectDir);
            this.Controls.Add(this.BtnSelectConfig);
            this.Controls.Add(this.TbTarget);
            this.Controls.Add(this.TbConfgPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ResetName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "重命名";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResetName_FormClosing);
            this.Load += new System.EventHandler(this.ResetName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbConfgPath;
        private System.Windows.Forms.Button BtnSelectConfig;
        private System.Windows.Forms.Button BtnSelectDir;
        private System.Windows.Forms.TextBox TbTarget;
        private System.Windows.Forms.Button BtnResetName;
        private System.Windows.Forms.FolderBrowserDialog DirectoryDialog;
        private System.Windows.Forms.Button BtnOpenConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbInfo;
        private System.Windows.Forms.Button BtnStat;
        private System.Windows.Forms.OpenFileDialog SelectFileDia;
    }
}