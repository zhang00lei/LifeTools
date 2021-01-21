namespace Alarm_Clock
{
    partial class Alarm_Clock_Form
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alarm_Clock_Form));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtpTimeingtime = new System.Windows.Forms.DateTimePicker();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示主窗体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labNowTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpCloseCpu = new System.Windows.Forms.DateTimePicker();
            this.cbAlarmClock = new System.Windows.Forms.CheckBox();
            this.cbCloseCpu = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dtpTimeingtime
            // 
            this.dtpTimeingtime.CustomFormat = "yyyy年MM月dd日 HH:mm:ss";
            this.dtpTimeingtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeingtime.Location = new System.Drawing.Point(78, 66);
            this.dtpTimeingtime.Name = "dtpTimeingtime";
            this.dtpTimeingtime.Size = new System.Drawing.Size(175, 21);
            this.dtpTimeingtime.TabIndex = 4;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "设定成功";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem,
            this.显示主窗体ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 48);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 显示主窗体ToolStripMenuItem
            // 
            this.显示主窗体ToolStripMenuItem.Name = "显示主窗体ToolStripMenuItem";
            this.显示主窗体ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.显示主窗体ToolStripMenuItem.Text = "显示主窗体";
            this.显示主窗体ToolStripMenuItem.Click += new System.EventHandler(this.显示主窗体ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "闹铃时间:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "现在时间:";
            // 
            // labNowTime
            // 
            this.labNowTime.AutoSize = true;
            this.labNowTime.Location = new System.Drawing.Point(78, 34);
            this.labNowTime.Name = "labNowTime";
            this.labNowTime.Size = new System.Drawing.Size(59, 12);
            this.labNowTime.TabIndex = 5;
            this.labNowTime.Text = "现在时间:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "关机时间:";
            // 
            // dtpCloseCpu
            // 
            this.dtpCloseCpu.CustomFormat = "yyyy年MM月dd日 HH:mm:ss";
            this.dtpCloseCpu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCloseCpu.Location = new System.Drawing.Point(78, 104);
            this.dtpCloseCpu.Name = "dtpCloseCpu";
            this.dtpCloseCpu.Size = new System.Drawing.Size(175, 21);
            this.dtpCloseCpu.TabIndex = 4;
            // 
            // cbAlarmClock
            // 
            this.cbAlarmClock.AutoSize = true;
            this.cbAlarmClock.Location = new System.Drawing.Point(272, 70);
            this.cbAlarmClock.Name = "cbAlarmClock";
            this.cbAlarmClock.Size = new System.Drawing.Size(15, 14);
            this.cbAlarmClock.TabIndex = 6;
            this.cbAlarmClock.UseVisualStyleBackColor = true;
            // 
            // cbCloseCpu
            // 
            this.cbCloseCpu.AutoSize = true;
            this.cbCloseCpu.Location = new System.Drawing.Point(272, 110);
            this.cbCloseCpu.Name = "cbCloseCpu";
            this.cbCloseCpu.Size = new System.Drawing.Size(15, 14);
            this.cbCloseCpu.TabIndex = 6;
            this.cbCloseCpu.UseVisualStyleBackColor = true;
            // 
            // Alarm_Clock_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 185);
            this.Controls.Add(this.cbCloseCpu);
            this.Controls.Add(this.cbAlarmClock);
            this.Controls.Add(this.labNowTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTimeingtime);
            this.Controls.Add(this.dtpCloseCpu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Alarm_Clock_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "闹铃";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Alarm_Clock_Form_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示主窗体ToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpTimeingtime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labNowTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpCloseCpu;
        private System.Windows.Forms.CheckBox cbAlarmClock;
        private System.Windows.Forms.CheckBox cbCloseCpu;
    }
}

