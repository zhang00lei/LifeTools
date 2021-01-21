using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MSWord = Microsoft.Office.Interop.Word;
using System.Text;
namespace MyToolsForHer
{
    class WordControl
    {
        //生成word名字
        private string _wordFileName;

        private string statisticalPath;
        private MSWord.Application wordApp;
        private Document wordDoc;
        private string firstTitle;
        private string secondTitle;
        private float firstTitleSize;
        private float secondTitleSize;

        private List<string> _getFileInfoByConfig(string imgDirPath, string configPath)
        {
            string errorInfo = "未找到目录如下：\n";
            List<string> result = new List<string>();
            Dictionary<string, List<string>> configInfo = CsvHelper.AnalysisCsvByFile(configPath);
            List<string> infoList = new List<string>();
            foreach (List<string> valueTemp in configInfo.Values)
            {
                for (int i = 0; i < valueTemp.Count; i++)
                {
                    infoList.Add(valueTemp[i]);
                }
            }

            for (int i = 0; i < infoList.Count; i++)
            {
                string dirPath = Path.Combine(imgDirPath, infoList[i]);
                if (Directory.Exists(dirPath))
                {
                    string[] files = Directory.GetFiles(dirPath, "*.jpg");
                    result.AddRange(files);
                }
                else
                {
                    errorInfo += dirPath + "\n";
                }
            }
            File.WriteAllText(statisticalPath, errorInfo, Encoding.UTF8);
            return result;
        }

        public void SetFontSize(decimal firstTitleSize, decimal secondTitleSize)
        {
            this.firstTitleSize = (float)firstTitleSize;
            this.secondTitleSize = (float)secondTitleSize;
        }

        public void SetWordName(string text)
        {
            _wordFileName = text;
        }

        public void SetTitleFlag(string firstTitle, string secondTitle)
        {
            this.firstTitle = firstTitle;
            this.secondTitle = secondTitle;
        }

        private void _insertTitle(string titleName)
        {
            Range textRange = wordDoc.Paragraphs.Last.Range;
            string fileName = GetFileName(titleName) + "\n";
            textRange.Text = fileName;
            object oStyleName = WdBuiltinStyle.wdStyleNormal;
            if (!string.IsNullOrEmpty(firstTitle) || !string.IsNullOrEmpty(secondTitle))
            {
                if (!string.IsNullOrEmpty(firstTitle) && fileName.Contains(firstTitle))
                {
                    oStyleName = WdBuiltinStyle.wdStyleHeading1; 
                }
                if (!string.IsNullOrEmpty(secondTitle) && fileName.Contains(secondTitle))
                {
                    oStyleName = WdBuiltinStyle.wdStyleHeading2; 
                }
            } 

            textRange.set_Style(ref oStyleName);
            if ((WdBuiltinStyle)oStyleName == WdBuiltinStyle.wdStyleHeading1)
            {
                textRange.Font.Size = firstTitleSize;
            }
            else if ((WdBuiltinStyle)oStyleName == WdBuiltinStyle.wdStyleHeading2)
            {
                textRange.Font.Size = secondTitleSize;
            }
            else
            {
                textRange.Font.Size = 10.5f;
            }
            textRange.ParagraphFormat.Alignment = MSWord.WdParagraphAlignment.wdAlignParagraphLeft;
        }

        public void CreateWord(string imgDirPath, string configPath,
            string wordPath, string statisticalPath)
        {
            this.statisticalPath = statisticalPath;
            string pathTemp = Path.Combine(wordPath, _wordFileName);
            CreateWord(imgDirPath, pathTemp, configPath);
            DialogResult dr = MessageBox.Show(string.Format("创建word成功，对应路径：{0}\n是否打开？",
     wordPath), "提示", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                //打开word
                System.Diagnostics.Process.Start(pathTemp);
            }
        }

        private void _insertImg(string filePath)
        {
            object unite = WdUnits.wdStory;
            //定义要向文档中插入图片的位置
            Range range = wordDoc.Paragraphs.Last.Range;
            //定义该图片是否为外部链接
            object linkToFile = false;//默认
            //定义插入的图片是否随word一起保存                          
            object saveWithDocument = true;
            object rangeTemp = range;
            //向word中写入图片
            InlineShape inlineShape = wordDoc.InlineShapes.AddPicture(filePath, ref linkToFile,
                ref saveWithDocument, ref rangeTemp);
            float maxHeight = 575;
            if (inlineShape.Height > inlineShape.Width)
            {
                float ratio = inlineShape.Height / inlineShape.Width;
                inlineShape.Height = maxHeight;
                inlineShape.Width = inlineShape.Height / ratio;
            }
            object oStyleName = MSWord.WdBuiltinStyle.wdStyleBodyText;
            range.set_Style(ref oStyleName);
            Object Nothing = Missing.Value;
            wordApp.Selection.EndKey(ref unite, ref Nothing);
            //居中显示图片
            wordApp.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
        }

        public void CreateWord(string imgDirPath, string wordPath, string configPath)
        {
            //初始化
            wordApp = new MSWord.ApplicationClass();
            //由于使用的是COM 库，因此有许多变量需要用Missing.Value 代替
            Object Nothing = Missing.Value;
            //新建一个word对象
            wordDoc = wordApp.Documents.Add(ref Nothing, ref Nothing, ref Nothing, ref Nothing);
            string[] files = _getFileInfoByConfig(imgDirPath, configPath).ToArray();

            for (int i = 0; i < files.Length; i++)
            {
                string imgName = files[i];

                _insertTitle(imgName);

                _insertImg(files[i]);
                object oPageBreak = WdBreakType.wdSectionBreakNextPage;
                wordApp.Selection.InsertBreak(ref oPageBreak);
            }
            //WdSaveDocument为Word2003文档的保存格式(文档后缀.doc)\wdFormatDocumentDefault为Word2007的保存格式(文档后缀.docx)
            object format = WdSaveFormat.wdFormatDocument;
            object wordPathTemp = (object)wordPath;
            //将wordDoc 文档对象的内容保存为DOC 文档,并保存到path指定的路径
            wordDoc.SaveAs(ref wordPathTemp, ref format, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing);
            //关闭wordDoc文档
            wordDoc.Close(ref Nothing, ref Nothing, ref Nothing);
            //关闭wordApp组件对象
            wordApp.Quit(ref Nothing, ref Nothing, ref Nothing);
        }

        public string GetFileName(string filePath)
        {
            string[] tempArray = filePath.Split('\\');
            string fileName = tempArray[tempArray.Length - 1];
            fileName = fileName.Replace(".jpg", string.Empty);
            return fileName;
        }
    }
}