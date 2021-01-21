using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MyToolsForHer
{
    public class ResetFileName
    {
        private Dictionary<string, string> _dirInfoDic;

        private void _setConfigInfo(string configPath)
        {
            _dirInfoDic = new Dictionary<string, string>();
            Dictionary<string, List<string>> configInfo = CsvHelper.AnalysisCsvByFile(configPath);
            int temp = 0;
            List<string> keys = new List<string>();
            List<string> values = new List<string>();
            foreach (List<string> tempList in configInfo.Values)
            {
                if (temp == 0)
                {
                    keys = tempList;
                }
                else if (temp == 1)
                {
                    values = tempList;
                }
                temp++;
            }
            for (int j = 0; j < keys.Count; j++)
            {
                _dirInfoDic.Add(keys[j], values[j]);
            }
        }

        public void ResetName(string dirPath, string configPath, string statPath, bool isDir)
        {
            _setConfigInfo(configPath);
            if (isDir)
            {
                _resetConfigDirName(dirPath, configPath, statPath);
            }
            else
            {
                _resetConfigFileName(dirPath, configPath, statPath);
            }
            DialogResult dr = MessageBox.Show("操作完毕，是否打开目录？", "提示", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("explorer.exe", dirPath);
            }
        }

        private void _resetConfigDirName(string dirPath, string configPath, string statPath)
        {
            string errorMsg = "未更名目录如下：\n";
            foreach (KeyValuePair<string, string> info in _dirInfoDic)
            {
                string dirPathTemp = Path.Combine(dirPath, info.Key);
                if (Directory.Exists(dirPathTemp))
                {
                    Directory.Move(dirPathTemp, Path.Combine(dirPath, info.Value));
                }
                else
                {
                    errorMsg += dirPathTemp + "\n";
                }
            }
            File.WriteAllText(statPath, errorMsg, Encoding.UTF8);
        }

        private void _resetConfigFileName(string dirPath, string configPath, string statPath)
        {
            string errorMsg = "未命名文件如下：\n";
            foreach (KeyValuePair<string, string> info in _dirInfoDic)
            {
                string filePathTemp = Path.Combine(dirPath, info.Key);
                if (File.Exists(filePathTemp))
                {
                    File.Move(filePathTemp, Path.Combine(dirPath, info.Value));
                }
                else
                {
                    errorMsg += filePathTemp + "\n";
                }
            }
            File.WriteAllText(statPath, errorMsg, Encoding.UTF8);
        }
    }
}