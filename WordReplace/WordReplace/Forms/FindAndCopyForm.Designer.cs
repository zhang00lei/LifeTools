namespace MyToolsForHer
{
    partial class FindAndCopyForm
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
            this.btnConfigPath = new System.Windows.Forms.Button();
            this.TbConfigPath = new System.Windows.Forms.TextBox();
            this.BtnOpenConfig = new System.Windows.Forms.Button();
            this.BtnSelectDir = new System.Windows.Forms.Button();
            this.TbTarget = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbInfo = new System.Windows.Forms.TextBox();
            this.BtnStat = new System.Windows.Forms.Button();
            this.SelectFileDia = new System.Windows.Forms.OpenFileDialog();
            this.DirectoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.BtnExec = new System.Windows.Forms.Button();
            this.TbCopyTo = new System.Windows.Forms.TextBox();
            this.BtnCopyTo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConfigPath
            // 
            this.btnConfigPath.Location = new System.Drawing.Point(12, 32);
            this.btnConfigPath.Name = "btnConfigPath";
            this.btnConfigPath.Size = new System.Drawing.Size(90, 23);
            this.btnConfigPath.TabIndex = 15;
            this.btnConfigPath.Text = "选择配置文件";
            this.btnConfigPath.UseVisualStyleBackColor = true;
            this.btnConfigPath.Click += new System.EventHandler(this.btnConfigPath_Click);
            // 
            // TbConfigPath
            // 
            this.TbConfigPath.Location = new System.Drawing.Point(120, 33);
            this.TbConfigPath.Name = "TbConfigPath";
            this.TbConfigPath.ReadOnly = true;
            this.TbConfigPath.Size = new System.Drawing.Size(294, 21);
            this.TbConfigPath.TabIndex = 14;
            // 
            // BtnOpenConfig
            // 
            this.BtnOpenConfig.Location = new System.Drawing.Point(420, 33);
            this.BtnOpenConfig.Name = "BtnOpenConfig";
            this.BtnOpenConfig.Size = new System.Drawing.Size(75, 23);
            this.BtnOpenConfig.TabIndex = 16;
            this.BtnOpenConfig.Text = "打开";
            this.BtnOpenConfig.UseVisualStyleBackColor = true;
            this.BtnOpenConfig.Click += new System.EventHandler(this.BtnOpenConfig_Click);
            // 
            // BtnSelectDir
            // 
            this.BtnSelectDir.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSelectDir.Location = new System.Drawing.Point(12, 81);
            this.BtnSelectDir.Name = "BtnSelectDir";
            this.BtnSelectDir.Size = new System.Drawing.Size(90, 23);
            this.BtnSelectDir.TabIndex = 18;
            this.BtnSelectDir.Text = "选择目录";
            this.BtnSelectDir.UseVisualStyleBackColor = true;
            this.BtnSelectDir.Click += new System.EventHandler(this.BtnSelectDir_Click);
            // 
            // TbTarget
            // 
            this.TbTarget.Location = new System.Drawing.Point(120, 81);
            this.TbTarget.Name = "TbTarget";
            this.TbTarget.ReadOnly = true;
            this.TbTarget.Size = new System.Drawing.Size(344, 21);
            this.TbTarget.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "统计信息";
            // 
            // TbInfo
            // 
            this.TbInfo.Location = new System.Drawing.Point(120, 181);
            this.TbInfo.Name = "TbInfo";
            this.TbInfo.ReadOnly = true;
            this.TbInfo.Size = new System.Drawing.Size(294, 21);
            this.TbInfo.TabIndex = 20;
            // 
            // BtnStat
            // 
            this.BtnStat.Location = new System.Drawing.Point(420, 179);
            this.BtnStat.Name = "BtnStat";
            this.BtnStat.Size = new System.Drawing.Size(75, 23);
            this.BtnStat.TabIndex = 19;
            this.BtnStat.Text = "打开";
            this.BtnStat.UseVisualStyleBackColor = true;
            this.BtnStat.Click += new System.EventHandler(this.BtnStat_Click);
            // 
            // SelectFileDia
            // 
            this.SelectFileDia.FileName = "openFileDialog1";
            // 
            // BtnExec
            // 
            this.BtnExec.Location = new System.Drawing.Point(214, 222);
            this.BtnExec.Name = "BtnExec";
            this.BtnExec.Size = new System.Drawing.Size(75, 23);
            this.BtnExec.TabIndex = 22;
            this.BtnExec.Text = "执行";
            this.BtnExec.UseVisualStyleBackColor = true;
            this.BtnExec.Click += new System.EventHandler(this.BtnExec_Click);
            // 
            // TbCopyTo
            // 
            this.TbCopyTo.Location = new System.Drawing.Point(120, 128);
            this.TbCopyTo.Name = "TbCopyTo";
            this.TbCopyTo.ReadOnly = true;
            this.TbCopyTo.Size = new System.Drawing.Size(344, 21);
            this.TbCopyTo.TabIndex = 17;
            // 
            // BtnCopyTo
            // 
            this.BtnCopyTo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCopyTo.Location = new System.Drawing.Point(12, 128);
            this.BtnCopyTo.Name = "BtnCopyTo";
            this.BtnCopyTo.Size = new System.Drawing.Size(90, 23);
            this.BtnCopyTo.TabIndex = 18;
            this.BtnCopyTo.Text = "复制到此目录";
            this.BtnCopyTo.UseVisualStyleBackColor = true;
            this.BtnCopyTo.Click += new System.EventHandler(this.BtnCopyTo_Click);
            // 
            // FindAndCopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 260);
            this.Controls.Add(this.BtnExec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbInfo);
            this.Controls.Add(this.BtnStat);
            this.Controls.Add(this.BtnCopyTo);
            this.Controls.Add(this.BtnSelectDir);
            this.Controls.Add(this.TbCopyTo);
            this.Controls.Add(this.TbTarget);
            this.Controls.Add(this.BtnOpenConfig);
            this.Controls.Add(this.btnConfigPath);
            this.Controls.Add(this.TbConfigPath);
            this.Name = "FindAndCopyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindAndCopy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindAndCopy_FormClosing);
            this.Load += new System.EventHandler(this.FindAndCopy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfigPath;
        private System.Windows.Forms.TextBox TbConfigPath;
        private System.Windows.Forms.Button BtnOpenConfig;
        private System.Windows.Forms.Button BtnSelectDir;
        private System.Windows.Forms.TextBox TbTarget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbInfo;
        private System.Windows.Forms.Button BtnStat;
        private System.Windows.Forms.OpenFileDialog SelectFileDia;
        private System.Windows.Forms.FolderBrowserDialog DirectoryDialog;
        private System.Windows.Forms.Button BtnExec;
        private System.Windows.Forms.TextBox TbCopyTo;
        private System.Windows.Forms.Button BtnCopyTo;
    }
}