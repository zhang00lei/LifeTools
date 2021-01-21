using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyToolsForHer
{
    public partial class ImgToWordForm : Form
    {
        public ImgToWordForm()
        {
            InitializeComponent();
        }
        private bool _checkInfo()
        {
            if (!File.Exists(TBConfigPath.Text))
            {
                MessageBox.Show("配置表路径不存在，请核实");
                return false;
            }
            else if (!Directory.Exists(TbImgPath.Text))
            {
                MessageBox.Show("图片目录路径不存在，请核实");
                return false;
            }
            else if (!Directory.Exists(TBWordPath.Text))
            {
                MessageBox.Show("word路径不存在，请核实");
                return false;
            }
            else if (string.IsNullOrEmpty(TbWordName.Text))
            {
                MessageBox.Show("word名字不可为空");
                return false;
            }
            else if (TbWordName.Text.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                MessageBox.Show("文件名不可包含非法字符，请核实");
                return false;
            }
            return true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_checkInfo())
            {
                WordControl wordControl = new WordControl();
                wordControl.SetTitleFlag(TbFirstTitle.Text, TbSecondTitle.Text);
                wordControl.SetWordName(TbWordName.Text + ".doc");
                wordControl.SetFontSize(NudFirstTitle.Value, NudSecondTitle.Value);
                wordControl.CreateWord(TbImgPath.Text, TBConfigPath.
                    Text, TBWordPath.Text, TBStatistical.Text);
            }
        }

        private void btnConfigPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Filter = "配置文件|*.csv";
            DialogResult dr = OpenFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                TBConfigPath.Text = OpenFileDialog.FileName; ;
            }
        }

        private void btnImgPath_Click(object sender, EventArgs e)
        {
            DialogResult dr = OpenImgDir.ShowDialog();
            if (dr == DialogResult.OK)
            {
                TbImgPath.Text = OpenImgDir.SelectedPath;
            }
        }

        private void btnGenWordPath_Click(object sender, EventArgs e)
        {
            DialogResult dr = OpenImgDir.ShowDialog();
            if (dr == DialogResult.OK)
            {
                TBWordPath.Text = OpenImgDir.SelectedPath;
            }
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (File.Exists(TBStatistical.Text))
            {
                System.Diagnostics.Process.Start(TBStatistical.Text);
            }
            else
            {
                MessageBox.Show("统计文件不存在");
            }
        }

        private void ImgToWordForm_Load(object sender, EventArgs e)
        {
            string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string directoryInfo = Path.GetDirectoryName(exePath);
            TBStatistical.Text = Path.Combine(directoryInfo, "ImgToWord/Stat.txt");
            TBConfigPath.Text = Path.Combine(directoryInfo, "ImgToWord/config.csv");
            TBWordPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        }

        private void BtnOpenConfig_Click(object sender, EventArgs e)
        {
            if (File.Exists(TBStatistical.Text))
            {
                System.Diagnostics.Process.Start(TBConfigPath.Text);
            }
            else
            {
                MessageBox.Show("配置表不存在");
            }
        }

        private void ImgToWordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
