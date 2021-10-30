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
        private string secondTitle;
        private string thirdTitle;
        private float firstTitleSize = 14;
        private float secondTitleSize;
        private float thirdTitleSize;

        private List<string> GetImgDirList(string imgDirPath,string configPath)
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
                    result.Add(dirPath);
                }
                else
                {
                    errorInfo += dirPath + "\n";
                }
            }
            File.WriteAllText(statisticalPath, errorInfo, Encoding.UTF8);
            return result;
        }

        public void SetFontSize(decimal secondTitleSize, decimal thirdTitleSize)
        {
            this.secondTitleSize = (float)secondTitleSize;
            this.thirdTitleSize = (float)thirdTitleSize;
        }

        public void SetWordName(string text)
        {
            _wordFileName = text;
        }

        public void SetTitleFlag(string secondTitle, string thirdTitle)
        {
            this.secondTitle = secondTitle;
            this.thirdTitle = thirdTitle;
        }

        private void _insertTitle(string titleName,bool isFirstTitle=false)
        {
            Range textRange = wordDoc.Paragraphs.Last.Range;
            string fileName = titleName + "\n";
            textRange.Text = fileName;
            object oStyleName = WdBuiltinStyle.wdStyleNormal;
            if (isFirstTitle)
            {
                oStyleName = WdBuiltinStyle.wdStyleHeading1;
            }
            else
            {
                if (!string.IsNullOrEmpty(secondTitle) || !string.IsNullOrEmpty(thirdTitle))
                {
                    if (!string.IsNullOrEmpty(secondTitle) && fileName.Contains(secondTitle))
                    {
                        oStyleName = WdBuiltinStyle.wdStyleHeading2;
                    }
                    if (!string.IsNullOrEmpty(thirdTitle) && fileName.Contains(thirdTitle))
                    {
                        oStyleName = WdBuiltinStyle.wdStyleHeading3;
                    }
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
            else if ((WdBuiltinStyle)oStyleName == WdBuiltinStyle.wdStyleHeading3)
            {
                textRange.Font.Size = thirdTitleSize;
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

        /// <summary>
        /// 获取文件名字或目录的父目录名字
        /// </summary>
        /// <param name="pathInfo">相关路径</param>
        public string GetFileOrParentDirName(string pathInfo)
        {
            string[] pathTemp = pathInfo.Split('\\');
            return pathTemp[pathTemp.Length - 1];
        }

        public void CreateWord(string imgDirPath, string wordPath, string configPath)
        {
            //初始化
            wordApp = new MSWord.ApplicationClass();
            //由于使用的是COM 库，因此有许多变量需要用Missing.Value 代替
            Object Nothing = Missing.Value;
            //新建一个word对象
            wordDoc = wordApp.Documents.Add(ref Nothing, ref Nothing, ref Nothing, ref Nothing);
            List<string> imgDirList = GetImgDirList(imgDirPath,configPath);
            foreach (string dirPath in imgDirList)
            {
                string dirName = GetFileOrParentDirName(dirPath);
                //插入目录标题
                _insertTitle(dirName, true);

                string[] imgFiles = Directory.GetFiles(dirPath, "*.jpg");
                foreach (string imgPath in imgFiles)
                {
                    _insertTitle(Path.GetFileNameWithoutExtension(imgPath));
                    _insertImg(imgPath);
                    object oPageBreak = WdBreakType.wdSectionBreakNextPage;
                    wordApp.Selection.InsertBreak(ref oPageBreak);
                }
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
    }
}