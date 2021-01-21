using System;
using System.Windows.Forms;

namespace MyToolsForHer
{
    public partial class Main : Form
    {
        private ImgToWordForm wordForm = new ImgToWordForm();
        private WordReplaceForm wordReplaceForm = new WordReplaceForm();
        private ResetName resetDirName = new ResetName(true);
        private ResetName resetFileName = new ResetName(false);
        private FindAndCopyForm findCopyDir = new FindAndCopyForm(true);
        private FindAndCopyForm findCopyFile = new FindAndCopyForm(false);

        public Main()
        {
            InitializeComponent();
        }

        private void MenuItemWordReplace_Click(object sender, EventArgs e)
        {
            wordReplaceForm.MdiParent = this;
            wordReplaceForm.Show();
        }

        private void MenuItemReplaceHelp_Click(object sender, EventArgs e)
        {
            string strTemp = "1.配置文件有两列内容，第一列为被替换文本，第二列为替换文本，参考默认配置文件<须utf-8编码>进行配置\n" +
                             "2.进行替换过程中大小写不敏感";
            MessageBox.Show(strTemp, "提示");
        }

        private void MenuItemImgToWord_Click(object sender, EventArgs e)
        {
            wordForm.MdiParent = this;
            wordForm.Show();
        }

        private void MenuItemHelp_Click(object sender, EventArgs e)
        {
            string strTemp = "1.包含一级标题标记文字的图片名称，则生成对应的一级标题，二级标题同理\n" +
                             "2.此操作只可操作.jpg文件\n" +
                             "3.统计信息里面保存在图片目录中没有找到配置文件中配置的目录\n" +
                             "3.配置文件有一列内容，参考默认配置文件<须utf-8编码>进行配置";
            MessageBox.Show(strTemp, "提示");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void MenuItemDirResetName_Click(object sender, EventArgs e)
        {
            resetDirName.MdiParent = this;
            resetDirName.Show();
        }

        private void MenuItemFileResetName_Click(object sender, EventArgs e)
        {
            resetDirName.MdiParent = this;
            resetFileName.Show();
        }

        private void MenuItemDirFindCopy_Click(object sender, EventArgs e)
        {
            findCopyDir.MdiParent = this;
            findCopyDir.Show();
        }

        private void MenuItemFileFindCopy_Click(object sender, EventArgs e)
        {
            findCopyFile.MdiParent = this;
            findCopyFile.Show();
        }

        private void MenuItemResetNameHelp_Click(object sender, EventArgs e)
        {
            string strTemp = "1.配置文件有两列内容，第一列为被替换名字，第二列为替换名字，参考默认配置文件<须utf-8编码>进行配置\n" +
                             "2.如果重命名文件名，须配置完整的文件名<包含扩展名>";
            MessageBox.Show(strTemp, "提示");
        }

        private void MenuItemAbout_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.cnblogs.com/Yellow0-0River/p/7614932.html");
        }

        private void MenuItemNewDir_Click(object sender, EventArgs e)
        {
        }

        private void MenuItemFindCopyHelp_Click(object sender, EventArgs e)
        {
            string strTemp = "1.配置文件有一列内容，为需要查找并复制的目录或文件名，参考默认配置文件<须utf-8编码>进行配置\n" +
                             "2.如果查找复制文件名，须配置完整的文件名<包含扩展名>";
            MessageBox.Show(strTemp, "提示");
        }
    }
}