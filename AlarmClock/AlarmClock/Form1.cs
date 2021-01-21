using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;

namespace Alarm_Clock
{
    public partial class Alarm_Clock_Form : Form
    {
        SoundPlayer sp = new SoundPlayer();
        bool isclose = false;
        public Alarm_Clock_Form()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.labNowTime.Text = DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss");
            if (cbAlarmClock.Checked)
            {
                if (DateTime.Now.ToString() == this.dtpTimeingtime.Value.ToString())
                {
                    Play();
                }
            }
            if (cbCloseCpu.Checked)
            {
                if (DateTime.Now.ToString() ==this.dtpCloseCpu .Value.ToString())
                {
                    Process.Start("cmd", "/cshutdown.exe /s /t 20");
                   if(DialogResult .Yes == MessageBox.Show("计算机将在20秒钟关闭。\n需要取消关闭吗？","提示",MessageBoxButtons.YesNo  ,MessageBoxIcon.Question  ))
                       Process.Start("cmd", "/cshutdown.exe /a");
                }
            }
        }
        /// <summary>
        /// 播放声音
        /// </summary>
        private void Play()
        {
            sp.SoundLocation = "这就是爱.wav"; 
            sp.PlayLooping();
            if (DialogResult.OK == MessageBox.Show("时间到", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information))
                sp.Stop();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isclose = true;
            this.Close();
        }

        private void 显示主窗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }


        private void Alarm_Clock_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            if (!isclose)
            e.Cancel = true; 
        }

    }
}
