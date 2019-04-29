using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectCleaner
{

    public partial class main : Form
    {
        /// <summary>
        /// 默认删除扩展名
        /// </summary>
        const string defaultFileType = @".obj\.tlog\.lastbuildstate\.idb\.pdb\.pch\.res\.ilk\.exe\.sdf\.ipch\.log\";
        /// <summary>
        /// 所有文件结构体集合
        /// </summary>
        List<File> fileList = new List<File>();
        /// <summary>
        /// 可删除文件结构体
        /// </summary>
        List<File> toDelFileList = new List<File>();
        /// <summary>
        /// 文件总大小
        /// </summary>
        double totalSize = 0;
        /// <summary>
        /// 可删除大小
        /// </summary>
        double toDelSize = 0;

        public main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 获取所有要删除的扩展名种类的集合
        /// </summary>
        /// <returns></returns>
        private List<string> getToDelFileTypeList()
        {
            List<string> fileTypeList = new List<string>();
            string[] type = txt_fileType.Text.Split('\\');
            for (int i = 0; i < type.Length; i++)
            {
                if (type[i] != string.Empty)
                {
                    fileTypeList.Add(type[i]);
                }
            }
            return fileTypeList;
        }


        /// <summary>
        /// 文件路径检测
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private bool fileCheck(string fileName)
        {
            //如果路径存在
            if (Directory.Exists(fileName))
            {
                for (int i = 0; i < lbx_fileList.Items.Count; i++)
                {
                    if (lbx_fileList.Items[i].ToString() == fileName)
                    {
                        MessageBox.Show("该项目已存在!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                return true;
            }
            else
            {
                MessageBox.Show("路径错误!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //处理文件信息
        private void dataTreating()
        {
            //初始化文件数据
            fileList.Clear();
            toDelFileList.Clear();
            totalSize = 0;
            toDelSize = 0;

            //获取所有文件目录
            List<string> fileInfo = new List<string>();
            for (int i = 0; i < lbx_fileList.Items.Count; i++)
            {
                Tool.GetAllDir(lbx_fileList.Items[i].ToString(), ref fileInfo);
            }

            //获取可删除扩展名
            List<string> toDelFileTypeList = getToDelFileTypeList();

            //获取文件结构列表
            for (int i = 0; i < fileInfo.Count; i++)
            {
                //处理结构体信息
                string path = fileInfo[i].Split('|')[0];
                long size = Convert.ToInt64(fileInfo[i].Split('|')[1]);
                fileList.Add(new File(path, size));
                //更新文件总大小
                totalSize += size;
                //处理可删除文件信息 
                for (int j = 0; j < toDelFileTypeList.Count; j++)
                {
                    if (path.Contains(toDelFileTypeList[j]))
                    {
                        toDelFileList.Add(new File(path, size));
                        //更新可删除文件大小
                        toDelSize += size;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void main_Load(object sender, EventArgs e)
        {
            //禁用最大化
            MaximizeBox = false;
            //禁止改变窗体大小(对话框风格)
            FormBorderStyle = FormBorderStyle.FixedSingle;
            txt_fileType.Text = defaultFileType;
        }

        /// <summary>
        /// 选择项目路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_openFile_Click(object sender, EventArgs e)
        {
            if (dlg_openFile.ShowDialog() == DialogResult.OK)
            {
                if (dlg_openFile.SelectedPath.Trim() != "")
                {
                    txt_path.Text = dlg_openFile.SelectedPath.Trim();
                }
            }
        }


        /// <summary>
        /// 添加项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addPath_Click(object sender, EventArgs e)
        {
            string fileName = txt_path.Text.Trim();
            if (fileCheck(fileName))
            {
                //添加到ListBox
                lbx_fileList.Items.Add(fileName);
            }
        }


        /// <summary>
        /// 恢复默认文件类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_defaultFileType_Click(object sender, EventArgs e)
        {
            txt_fileType.Text = defaultFileType;
        }


        /// <summary>
        /// 获取文件信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_getInfo_Click(object sender, EventArgs e)
        {
            try
            {
                //处理文件数据
                dataTreating();

                //清空文本框信息
                txt_toDelInfo.Clear();

                //打印文件路径信息
                for (int i = 0; i < fileList.Count; i++)
                {
                    txt_toDelInfo.AppendText("找到:" + fileList[i].fileName + "\r\n\r\n");
                    Thread.Sleep(600 / fileList.Count);
                }

                //打印概览信息
                txt_toDelInfo.AppendText(
                    "文件总个数:" +
                    fileList.Count +
                    "个  " +
                    "文件总大小:" +
                    (totalSize / 1024 / 1024).ToString("0.00") +
                    "M\r\n");
                txt_toDelInfo.AppendText(
                   "可删除个数:" +
                   toDelFileList.Count +
                   "个  " +
                   "可删除大小:" +
                   (toDelSize / 1024 / 1024).ToString("0.00") +
                   "M");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_startDel_Click(object sender, EventArgs e)
        {
            //成功删除的个数
            int successCount = 0;
            //成功删除的大小(byte)
            double successSize = 0;
            //处理文件数据
            dataTreating();
            //清空文本框信息
            txt_delInfo.Clear();
            //删除
            for (int i = 0; i < toDelFileList.Count; i++)
            {
                if (Tool.delFile(toDelFileList[i].fileName))
                {
                    successCount += 1;
                    successSize += toDelFileList[i].size;
                    txt_delInfo.AppendText("删除:" + toDelFileList[i].fileName + "\r\n\r\n");
                    Thread.Sleep(600 / toDelFileList.Count);
                }
            }
            txt_delInfo.AppendText(
                  "失败" +
                  (toDelFileList.Count - successCount) +
                  "个 " +
                  "已释放:" +
                  (successSize / 1024 / 1024).ToString("0.00") +
                  "M");
        }


        /// <summary>
        /// 拖拽之释放前
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbx_fileList_DragEnter(object sender, DragEventArgs e)
        {
            //lbx_fileList.BorderStyle = BorderStyle.None;
            lbx_fileList.BackColor = Color.Gray;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// 拖拽的鼠标移除控件后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbx_fileList_DragLeave(object sender, EventArgs e)
        {
            //lbx_fileList.BorderStyle = BorderStyle.Fixed3D;
            lbx_fileList.BackColor = Color.White;
        }

        /// <summary>
        /// 拖放完成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbx_fileList_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            for (int i = 0; i < fileName.Length; i++)
            {
                if (fileCheck(fileName[i]))
                {
                    //添加到ListBox
                    lbx_fileList.Items.Add(fileName[i]);
                }
            }
            lbx_fileList_DragLeave(null, null);
        }


        /// <summary>
        /// tips(在toolTip中查看文件完整路径)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbx_fileList_MouseMove(object sender, MouseEventArgs e)
        {
            int index = lbx_fileList.IndexFromPoint(e.Location);
            //检查索引是否有效
            if (index != -1 && index < lbx_fileList.Items.Count)
            {
                //检查toolTip的文本是否和当前文件一致
                if (tip_fileName.GetToolTip(lbx_fileList) != lbx_fileList.Items[index].ToString())
                {
                    //如果不一致,则新创建一个tip
                    //隐藏,更新
                    tip_fileName.SetToolTip(lbx_fileList, lbx_fileList.Items[index].ToString());
                }
            }
        }

        //文件列表中,右键单击选中的项的索引
        int index = 0;

        /// <summary>
        /// 右键单击文件列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbx_fileList_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                index = lbx_fileList.IndexFromPoint(e.Location);
                if (index != -1 && index < lbx_fileList.Items.Count)
                {
                    lbx_fileList.SetSelected(index, true);
                    cms_fileOption.Show();
                    return;
                }
            }
            cms_fileOption.Hide();           
        }


        /// <summary>
        /// 单击文件选项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cms_fileOption_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                switch (e.ClickedItem.Text)
                {
                    case "删除":
                        lbx_fileList.Items.Remove(lbx_fileList.SelectedItem);
                        break;
                    case "打开目录":
                        Process open = new Process();
                        open.StartInfo.UseShellExecute = true;
                        open.StartInfo.FileName = lbx_fileList.Items[index].ToString();
                        open.Start();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
