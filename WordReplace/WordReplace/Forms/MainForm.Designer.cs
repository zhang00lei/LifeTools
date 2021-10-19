namespace MyToolsForHer
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.图片插入WordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemImgToWord = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuWordReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemWordReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemReplaceHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.重命名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDirResetName = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileResetName = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemResetNameHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.查找并复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDirFindCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileFindCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFindCopyHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.更多ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ForHer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查找并复制ToolStripMenuItem,
            this.重命名ToolStripMenuItem,
            this.图片插入WordToolStripMenuItem,
            this.MenuWordReplace,
            this.更多ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 图片插入WordToolStripMenuItem
            // 
            this.图片插入WordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemImgToWord,
            this.MenuItemHelp});
            this.图片插入WordToolStripMenuItem.Name = "图片插入WordToolStripMenuItem";
            this.图片插入WordToolStripMenuItem.Size = new System.Drawing.Size(101, 21);
            this.图片插入WordToolStripMenuItem.Text = "图片插入Word";
            // 
            // MenuItemImgToWord
            // 
            this.MenuItemImgToWord.Name = "MenuItemImgToWord";
            this.MenuItemImgToWord.Size = new System.Drawing.Size(100, 22);
            this.MenuItemImgToWord.Text = "执行";
            this.MenuItemImgToWord.Click += new System.EventHandler(this.MenuItemImgToWord_Click);
            // 
            // MenuItemHelp
            // 
            this.MenuItemHelp.Name = "MenuItemHelp";
            this.MenuItemHelp.Size = new System.Drawing.Size(100, 22);
            this.MenuItemHelp.Text = "帮助";
            this.MenuItemHelp.Click += new System.EventHandler(this.MenuItemHelp_Click);
            // 
            // MenuWordReplace
            // 
            this.MenuWordReplace.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemWordReplace,
            this.MenuItemReplaceHelp});
            this.MenuWordReplace.Name = "MenuWordReplace";
            this.MenuWordReplace.Size = new System.Drawing.Size(101, 21);
            this.MenuWordReplace.Text = "Word文字替换";
            // 
            // MenuItemWordReplace
            // 
            this.MenuItemWordReplace.Name = "MenuItemWordReplace";
            this.MenuItemWordReplace.Size = new System.Drawing.Size(100, 22);
            this.MenuItemWordReplace.Text = "执行";
            this.MenuItemWordReplace.Click += new System.EventHandler(this.MenuItemWordReplace_Click);
            // 
            // MenuItemReplaceHelp
            // 
            this.MenuItemReplaceHelp.Name = "MenuItemReplaceHelp";
            this.MenuItemReplaceHelp.Size = new System.Drawing.Size(100, 22);
            this.MenuItemReplaceHelp.Text = "帮助";
            this.MenuItemReplaceHelp.Click += new System.EventHandler(this.MenuItemReplaceHelp_Click);
            // 
            // 重命名ToolStripMenuItem
            // 
            this.重命名ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemDirResetName,
            this.MenuItemFileResetName,
            this.MenuItemResetNameHelp});
            this.重命名ToolStripMenuItem.Name = "重命名ToolStripMenuItem";
            this.重命名ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.重命名ToolStripMenuItem.Text = "重命名";
            // 
            // MenuItemDirResetName
            // 
            this.MenuItemDirResetName.Name = "MenuItemDirResetName";
            this.MenuItemDirResetName.Size = new System.Drawing.Size(180, 22);
            this.MenuItemDirResetName.Text = "目录重命名";
            this.MenuItemDirResetName.Click += new System.EventHandler(this.MenuItemDirResetName_Click);
            // 
            // MenuItemFileResetName
            // 
            this.MenuItemFileResetName.Name = "MenuItemFileResetName";
            this.MenuItemFileResetName.Size = new System.Drawing.Size(180, 22);
            this.MenuItemFileResetName.Text = "文件重命名";
            this.MenuItemFileResetName.Click += new System.EventHandler(this.MenuItemFileResetName_Click);
            // 
            // MenuItemResetNameHelp
            // 
            this.MenuItemResetNameHelp.Name = "MenuItemResetNameHelp";
            this.MenuItemResetNameHelp.Size = new System.Drawing.Size(180, 22);
            this.MenuItemResetNameHelp.Text = "帮助";
            this.MenuItemResetNameHelp.Click += new System.EventHandler(this.MenuItemResetNameHelp_Click);
            // 
            // 查找并复制ToolStripMenuItem
            // 
            this.查找并复制ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemDirFindCopy,
            this.MenuItemFileFindCopy,
            this.MenuItemFindCopyHelp});
            this.查找并复制ToolStripMenuItem.Name = "查找并复制ToolStripMenuItem";
            this.查找并复制ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.查找并复制ToolStripMenuItem.Text = "查找并复制";
            // 
            // MenuItemDirFindCopy
            // 
            this.MenuItemDirFindCopy.Name = "MenuItemDirFindCopy";
            this.MenuItemDirFindCopy.Size = new System.Drawing.Size(180, 22);
            this.MenuItemDirFindCopy.Text = "目录";
            this.MenuItemDirFindCopy.Click += new System.EventHandler(this.MenuItemDirFindCopy_Click);
            // 
            // MenuItemFileFindCopy
            // 
            this.MenuItemFileFindCopy.Name = "MenuItemFileFindCopy";
            this.MenuItemFileFindCopy.Size = new System.Drawing.Size(180, 22);
            this.MenuItemFileFindCopy.Text = "文件";
            this.MenuItemFileFindCopy.Click += new System.EventHandler(this.MenuItemFileFindCopy_Click);
            // 
            // MenuItemFindCopyHelp
            // 
            this.MenuItemFindCopyHelp.Name = "MenuItemFindCopyHelp";
            this.MenuItemFindCopyHelp.Size = new System.Drawing.Size(180, 22);
            this.MenuItemFindCopyHelp.Text = "帮助";
            this.MenuItemFindCopyHelp.Click += new System.EventHandler(this.MenuItemFindCopyHelp_Click);
            // 
            // 更多ToolStripMenuItem
            // 
            this.更多ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ForHer});
            this.更多ToolStripMenuItem.Name = "更多ToolStripMenuItem";
            this.更多ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.更多ToolStripMenuItem.Text = "更多";
            // 
            // ForHer
            // 
            this.ForHer.Name = "ForHer";
            this.ForHer.Size = new System.Drawing.Size(180, 22);
            this.ForHer.Text = "关于csv配置文件";
            this.ForHer.Click += new System.EventHandler(this.MenuItemAbout_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 377);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tools";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 图片插入WordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemImgToWord;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuWordReplace;
        private System.Windows.Forms.ToolStripMenuItem MenuItemWordReplace;
        private System.Windows.Forms.ToolStripMenuItem MenuItemReplaceHelp;
        private System.Windows.Forms.ToolStripMenuItem 重命名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDirResetName;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileResetName;
        private System.Windows.Forms.ToolStripMenuItem MenuItemResetNameHelp;
        private System.Windows.Forms.ToolStripMenuItem 更多ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ForHer;
        private System.Windows.Forms.ToolStripMenuItem 查找并复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDirFindCopy;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileFindCopy;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFindCopyHelp;
    }
}