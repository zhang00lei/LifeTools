using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MyToolsForHer
{
    public class FindAndCopy
    {
        private Dictionary<string, string> _dirInfoDic;

        private void _setConfigInfo(string configPath)
        {
            _dirInfoDic = new Dictionary<string, string>();
            Dictionary<string, List<string>> configInfo = CsvHelper.AnalysisCsvByFile(configPath);
            int temp = 0;
            List<string> keys = new List<string>();
            foreach (List<string> tempList in configInfo.Values)
            {
                if (temp == 0)
                {
                    keys = tempList;
                }

                temp++;
            }

            for (int j = 0; j < keys.Count; j++)
            {
                _dirInfoDic.Add(keys[j], string.Empty);
            }
        }

        public List<string> ExecFindCopy(string fromPath, string toPath, string configPath, bool isDir)
        {
            _setConfigInfo(configPath);
            if (isDir)
            {
                string[] directoys = Directory.GetDirectories(fromPath, "*", SearchOption.AllDirectories);
                foreach (string info in directoys)
                {
                    string[] strTemp = info.Split('\\');
                    string dirName = strTemp[strTemp.Length - 1];
                    if (_dirInfoDic.ContainsKey(dirName))
                    {
                        string  copyToPath = Path.Combine(toPath,dirName);
                        directoryCopy(info, copyToPath);
                        _dirInfoDic.Remove(dirName);
                    }
                }
            }
            else
            {
                string[] files = Directory.GetFiles(fromPath, "*", SearchOption.AllDirectories);
                foreach (string info in files)
                {
                    string[] strTemp = info.Split('\\');
                    string fileName = strTemp[strTemp.Length - 1];
                    if (_dirInfoDic.ContainsKey(fileName))
                    {
                        File.Copy(info, toPath + "\\" + fileName, true);
                        _dirInfoDic.Remove(fileName);
                    }
                }
            }

            List<string> result = new List<string>();
            foreach (var keyValuePair in _dirInfoDic)
            {
                result.Add(keyValuePair.Key);
            }

            return result;
        }

        public void directoryCopy(string sourceDirectory, string targetDirectory)
        {
            if (!Directory.Exists(targetDirectory)) {
                Directory.CreateDirectory(targetDirectory);
            }
            try
            {
                DirectoryInfo dir = new DirectoryInfo(sourceDirectory);
                //获取目录下（不包含子目录）的文件和子目录
                FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();
                foreach (FileSystemInfo i in fileinfo)
                {
                    if (i is DirectoryInfo) //判断是否文件夹
                    {
                        if (!Directory.Exists(targetDirectory + "\\" + i.Name))
                        {
                            //目标目录下不存在此文件夹即创建子文件夹
                            Directory.CreateDirectory(targetDirectory + "\\" + i.Name);
                        }

                        //递归调用复制子文件夹
                        directoryCopy(i.FullName, targetDirectory + "\\" + i.Name);
                    }
                    else
                    {
                        //不是文件夹即复制文件，true表示可以覆盖同名文件
                        File.Copy(i.FullName, targetDirectory + "\\" + i.Name, true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("复制文件出现异常" + ex.Message);
            }
        }
    }
}