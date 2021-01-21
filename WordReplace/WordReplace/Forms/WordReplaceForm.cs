using System;
using System.IO;
using System.Windows.Forms;

namespace MyToolsForHer
{
    public partial class WordReplaceForm : Form
    {
        public WordReplaceForm()
        {
            InitializeComponent();
        }

        private void BtnSelectConfig_Click(object sender, EventArgs e)
        {
            SelectFileDia.Filter = "Config (*.csv)|*.csv";
            DialogResult dr = SelectFileDia.ShowDialog();
            if (dr == DialogResult.OK)
            {
                TbConfigPath.Text = SelectFileDia.FileName;
            }
        }

        private void BtnSelectWord_Click(object sender, EventArgs e)
        {
            SelectFileDia.Filter = "Word (*.doc,*.docx)|*.doc;*.docx";
            DialogResult dr = SelectFileDia.ShowDialog();
            if (dr == DialogResult.OK)
            {
                TbWordPath.Text = SelectFileDia.FileName;
            }
        }

        private void BtnReplace_Click(object sender, EventArgs e)
        {
            if (!File.Exists(TbConfigPath.Text))
            {
                MessageBox.Show("配置文件不存在");
            }
            else if (!File.Exists(TbWordPath.Text))
            {
                MessageBox.Show("Word文件不存在");
            }
            else
            {
                WordReplace wr = new WordReplace();
                wr.Replace(TbConfigPath.Text, TbWordPath.Text,TbInfo.Text);
            }
        }

        private void WordReplaceForm_Load(object sender, EventArgs e)
        { 
            string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string directoryInfo = Path.GetDirectoryName(exePath);
            TbInfo.Text = Path.Combine(directoryInfo, "WordReplaceInfo/Stat.txt");
            TbConfigPath.Text = Path.Combine(directoryInfo, "WordReplaceInfo/config.csv");
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            if (File.Exists(TbInfo.Text))
            {
                System.Diagnostics.Process.Start(TbInfo.Text);
            }
            else
            {
                MessageBox.Show("统计信息文件不存在");
            }
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

        private void WordReplaceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
