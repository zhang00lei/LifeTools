using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace MyToolsForHer
{
    public partial class FindAndCopyForm : Form
    {
        private bool findCopyDir;

        public FindAndCopyForm(bool isDir)
        {
            findCopyDir = isDir;
            InitializeComponent();
            Text = findCopyDir ? "查找并复制目录" : "查找并复制文件";
        }

        private void btnConfigPath_Click(object sender, EventArgs e)
        {
            SelectFileDia.Filter = "Config (*.csv)|*.csv";
            DialogResult dr = SelectFileDia.ShowDialog();
            if (dr == DialogResult.OK)
            {
                TbConfigPath.Text = SelectFileDia.FileName;
            }
        }

        private void FindAndCopy_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void FindAndCopy_Load(object sender, EventArgs e)
        {
            string exePath = Assembly.GetExecutingAssembly().Location;
            string directoryInfo = Path.GetDirectoryName(exePath);

            TbConfigPath.Text = Path.Combine(directoryInfo, "FindAndCopy\\config.csv");
            TbInfo.Text = Path.Combine(directoryInfo, "FindAndCopy\\Stat.txt");
        }

        private void BtnOpenConfig_Click(object sender, EventArgs e)
        {
            if (File.Exists(TbConfigPath.Text))
            {
                System.Diagnostics.Process.Start(TbConfigPath.Text);
            }
            else
            {
                MessageBox.Show("配置表不存在");
            }
        }

        private void BtnSelectDir_Click(object sender, EventArgs e)
        {
            DialogResult dr = DirectoryDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                TbTarget.Text = DirectoryDialog.SelectedPath;
            }
        }

        private void BtnExec_Click(object sender, EventArgs e)
        {
            FindAndCopy findAndCopy = new FindAndCopy();
            List<string> infoList =
                findAndCopy.ExecFindCopy(TbTarget.Text, TbCopyTo.Text, TbConfigPath.Text, findCopyDir);

            infoList.Insert(0, "以下目录或文件未发现:");
            File.WriteAllLines(TbInfo.Text, infoList.ToArray());
        }

        private void BtnCopyTo_Click(object sender, EventArgs e)
        {
            DialogResult dr = DirectoryDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                TbCopyTo.Text = DirectoryDialog.SelectedPath;
            }
        }

        private void BtnStat_Click(object sender, EventArgs e)
        {
            if (File.Exists(TbInfo.Text))
            {
                System.Diagnostics.Process.Start(TbInfo.Text);
            }
            else
            {
                MessageBox.Show("统计信息不存在");
            }
        }
    }
}