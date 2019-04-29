using System;
using System.Collections.Generic;
using System.IO;

namespace ProjectCleaner
{

    struct File
    {
        public File(string _fileName, long _size)
        {
            fileName = _fileName;
            size = _size;
        }
        /// <summary>
        /// 文件完整路径
        /// </summary>
        public string fileName;

        /// <summary>
        /// 文件大小
        /// </summary>
        public long size;
    }

    class Tool
    {


        /// <summary>
        /// 获取指定路径下的所有文件
        /// </summary>
        /// <param name="path">指定路径</param>
        /// <param name="list">文件列表</param>
        /// /// <return>若成功,返回所有文件完整路径+文件大小(用|隔开)</return>
        public static void GetAllDir(string path, ref List<string> list)
        {
                DirectoryInfo dir = new DirectoryInfo(path);
                //获取当前目录下的所有子目录
                DirectoryInfo[] dirInfo = dir.GetDirectories();
                //获取当前目录下的所有文件
                FileInfo[] fileInfo = dir.GetFiles();
                //添加文件
                for (int i = 0; i < fileInfo.Length; i++)
                {
                    list.Add(fileInfo[i].FullName + "|" + fileInfo[i].Length);
                }
                //添加子目录
                for (int i = 0; i < dirInfo.Length; i++)
                {
                    GetAllDir(dirInfo[i].FullName, ref list);
                }           
        }


        /// <summary>
        /// 删除指定文件
        /// </summary>
        /// <param name="fileName">文件完整路径</param>
        /// <returns></returns>
        public static bool delFile(string fileName)
        {
            try
            {
                FileInfo file = new FileInfo(fileName);
                if(file.Exists)
                {
                    file.Delete();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
