using System;
using System.IO;
using System.Windows.Forms;

namespace MyToolsForHer
{
    public partial class ResetName : Form
    {
        private bool isResetDir;
        public ResetName(bool isResetDir)
        {
            this.isResetDir = isResetDir;
            InitializeComponent();
        }

        private void ResetName_Load(object sender, EventArgs e)
        {
            string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string directoryInfo = Path.GetDirectoryName(exePath);
            TbConfgPath.Text = Path.Combine(directoryInfo, "ResetName/config.csv");
            TbInfo.Text = Path.Combine(directoryInfo, "ResetName/Stat.txt");
        }

        private void BtnSelectConfig_Click(object sender, EventArgs e)
        {
            SelectFileDia.Filter = "Config (*.csv)|*.csv";
            DialogResult dr = SelectFileDia.ShowDialog();
            if (dr == DialogResult.OK)
            {
                TbConfgPath.Text = SelectFileDia.FileName;
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

        private void BtnOpenConfig_Click(object sender, EventArgs e)
        {
            if (File.Exists(TbConfgPath.Text))
            {
                System.Diagnostics.Process.Start(TbConfgPath.Text);
            }
            else
            {
                MessageBox.Show("配置表不存在");
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

        private void BtnResetName_Click(object sender, EventArgs e)
        {
            ResetFileName rfn = new ResetFileName();
            rfn.ResetName(TbTarget.Text, TbConfgPath.Text, TbInfo.Text, isResetDir);
        }

        private void ResetName_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
