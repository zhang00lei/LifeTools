namespace MyToolsForHer
{
    partial class WordReplaceForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TbConfigPath = new System.Windows.Forms.TextBox();
            this.BtnSelectConfig = new System.Windows.Forms.Button();
            this.BtnSelectWord = new System.Windows.Forms.Button();
            this.TbWordPath = new System.Windows.Forms.TextBox();
            this.BtnReplace = new System.Windows.Forms.Button();
            this.SelectFileDia = new System.Windows.Forms.OpenFileDialog();
            this.TbInfo = new System.Windows.Forms.TextBox();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnOpenConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbConfigPath
            // 
            this.TbConfigPath.Location = new System.Drawing.Point(108, 34);
            this.TbConfigPath.Name = "TbConfigPath";
            this.TbConfigPath.ReadOnly = true;
            this.TbConfigPath.Size = new System.Drawing.Size(333, 21);
            this.TbConfigPath.TabIndex = 1;
            // 
            // BtnSelectConfig
            // 
            this.BtnSelectConfig.Location = new System.Drawing.Point(12, 34);
            this.BtnSelectConfig.Name = "BtnSelectConfig";
            this.BtnSelectConfig.Size = new System.Drawing.Size(90, 23);
            this.BtnSelectConfig.TabIndex = 2;
            this.BtnSelectConfig.Text = "选择配置文件";
            this.BtnSelectConfig.UseVisualStyleBackColor = true;
            this.BtnSelectConfig.Click += new System.EventHandler(this.BtnSelectConfig_Click);
            // 
            // BtnSelectWord
            // 
            this.BtnSelectWord.Location = new System.Drawing.Point(12, 95);
            this.BtnSelectWord.Name = "BtnSelectWord";
            this.BtnSelectWord.Size = new System.Drawing.Size(90, 23);
            this.BtnSelectWord.TabIndex = 2;
            this.BtnSelectWord.Text = "选择word文件";
            this.BtnSelectWord.UseVisualStyleBackColor = true;
            this.BtnSelectWord.Click += new System.EventHandler(this.BtnSelectWord_Click);
            // 
            // TbWordPath
            // 
            this.TbWordPath.Location = new System.Drawing.Point(108, 95);
            this.TbWordPath.Name = "TbWordPath";
            this.TbWordPath.ReadOnly = true;
            this.TbWordPath.Size = new System.Drawing.Size(414, 21);
            this.TbWordPath.TabIndex = 1;
            // 
            // BtnReplace
            // 
            this.BtnReplace.Location = new System.Drawing.Point(224, 215);
            this.BtnReplace.Name = "BtnReplace";
            this.BtnReplace.Size = new System.Drawing.Size(75, 23);
            this.BtnReplace.TabIndex = 3;
            this.BtnReplace.Text = "替换";
            this.BtnReplace.UseVisualStyleBackColor = true;
            this.BtnReplace.Click += new System.EventHandler(this.BtnReplace_Click);
            // 
            // TbInfo
            // 
            this.TbInfo.Location = new System.Drawing.Point(108, 156);
            this.TbInfo.Name = "TbInfo";
            this.TbInfo.ReadOnly = true;
            this.TbInfo.Size = new System.Drawing.Size(333, 21);
            this.TbInfo.TabIndex = 1;
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(447, 156);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(75, 23);
            this.BtnOpen.TabIndex = 3;
            this.BtnOpen.Text = "打开";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "统计信息";
            // 
            // BtnOpenConfig
            // 
            this.BtnOpenConfig.Location = new System.Drawing.Point(447, 34);
            this.BtnOpenConfig.Name = "BtnOpenConfig";
            this.BtnOpenConfig.Size = new System.Drawing.Size(75, 23);
            this.BtnOpenConfig.TabIndex = 3;
            this.BtnOpenConfig.Text = "打开";
            this.BtnOpenConfig.UseVisualStyleBackColor = true;
            this.BtnOpenConfig.Click += new System.EventHandler(this.BtnOpenConfig_Click);
            // 
            // WordReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 257);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnOpenConfig);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.BtnReplace);
            this.Controls.Add(this.BtnSelectWord);
            this.Controls.Add(this.BtnSelectConfig);
            this.Controls.Add(this.TbInfo);
            this.Controls.Add(this.TbWordPath);
            this.Controls.Add(this.TbConfigPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WordReplaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word文字替换";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WordReplaceForm_FormClosing);
            this.Load += new System.EventHandler(this.WordReplaceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbConfigPath;
        private System.Windows.Forms.Button BtnSelectConfig;
        private System.Windows.Forms.Button BtnSelectWord;
        private System.Windows.Forms.TextBox TbWordPath;
        private System.Windows.Forms.Button BtnReplace;
        private System.Windows.Forms.OpenFileDialog SelectFileDia;
        private System.Windows.Forms.TextBox TbInfo;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnOpenConfig;
    }
}

