using System;
using Microsoft.Office.Interop.Word;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Word.Application;

namespace MyToolsForHer
{
    public struct ReplaceInfo
    {
        public string SourceInfo;
        public string TargetInfo;
    }

    internal class WordReplace
    {
        private List<ReplaceInfo> _replaceInfos;
        private void _getConfigInfo(string configPath)
        {
            _replaceInfos = new List<ReplaceInfo>();
            Dictionary<string, List<string>> configInfo = CsvHelper.AnalysisCsvByFile(configPath);
            foreach (List<string> values in configInfo.Values)
            {
                for (int i = 0; i < values.Count; i++)
                {
                    ReplaceInfo info = new ReplaceInfo();
                    info.SourceInfo = values[i];
                    _replaceInfos.Add(info);
                }
            }
            int temp = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(_replaceInfos.Count / 2.0f)));
            for (int i = 0; i < temp; i++)
            {
                ReplaceInfo info = new ReplaceInfo();
                info.SourceInfo = _replaceInfos[i].SourceInfo;
                info.TargetInfo = _replaceInfos[i + temp].SourceInfo;
                _replaceInfos[i] = info;
            }
            while (_replaceInfos.Count > temp)
            {
                _replaceInfos.RemoveAt(_replaceInfos.Count - 1);
            }
        }
        public void Replace(string configPath, string wordPath, string infoPath)
        {
            string _errorMsg = "未能进行替换的文本有：\n";
            _getConfigInfo(configPath);
            Application app = new Application();
            object wordPathTemp = wordPath;
            object oMissing = System.Reflection.Missing.Value;
            Document doc = app.Documents.Open(ref wordPathTemp,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            foreach (ReplaceInfo info in _replaceInfos)
            {
                app.Selection.Find.Replacement.ClearFormatting();
                app.Selection.Find.ClearFormatting();
                //需要被替换的文本
                app.Selection.Find.Text = info.SourceInfo;
                //替换文本 
                app.Selection.Find.Replacement.Text = info.TargetInfo;
                //执行替换操作
                object replace = WdReplace.wdReplaceAll;
                bool isReplaceOver = app.Selection.Find.Execute(
                     ref oMissing, ref oMissing,
                     ref oMissing, ref oMissing,
                     ref oMissing, ref oMissing,
                     ref oMissing, ref oMissing, ref oMissing,
                     ref oMissing, ref replace,
                     ref oMissing, ref oMissing,
                     ref oMissing, ref oMissing);
                if (!isReplaceOver)
                {
                    _errorMsg += info.SourceInfo + "\n";
                }
            }
            //对替换好的word模板另存为一个新的word文档
            string oldWordName = Path.GetFileName(wordPath);
            wordPath = wordPath.Replace(oldWordName, string.Empty);
            wordPath = Path.Combine(wordPath, "New_" + oldWordName);
            doc.SaveAs(wordPath,
                oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing,
                oMissing, oMissing, oMissing, oMissing, oMissing, oMissing);
            //关闭wordDoc文档
            doc.Close(ref oMissing, ref oMissing, ref oMissing);
            //关闭wordApp组件对象
            app.Quit(ref oMissing, ref oMissing, ref oMissing);
            File.WriteAllText(infoPath, _errorMsg, Encoding.UTF8);
            DialogResult dr = MessageBox.Show(string.Format("操作完毕，Word路径：{0}，是否打开？", wordPath), "提示", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(wordPath);
            }
        }
    }
}
