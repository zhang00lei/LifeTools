using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace Alarm_Clock
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Process  []proname=Process.GetProcesses();
            //for (int i = 0; i < proname.Length; i++)
            //{
            //    if (proname[i].ProcessName  == "AlarmClock")
            //        return;
            //}
            Application.Run(new Alarm_Clock_Form());


        }
    }
}
