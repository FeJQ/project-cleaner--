namespace ProjectCleaner
{
    partial class main
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.gbx_left = new System.Windows.Forms.GroupBox();
            this.lbx_fileList = new System.Windows.Forms.ListBox();
            this.gbx_rightTop = new System.Windows.Forms.GroupBox();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.lbl_fileType = new System.Windows.Forms.Label();
            this.lbl_path = new System.Windows.Forms.Label();
            this.btn_defaultFileType = new System.Windows.Forms.Button();
            this.btn_addPath = new System.Windows.Forms.Button();
            this.txt_fileType = new System.Windows.Forms.TextBox();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.gbx_rightBottom = new System.Windows.Forms.GroupBox();
            this.txt_delInfo = new System.Windows.Forms.TextBox();
            this.lbl_delInfo = new System.Windows.Forms.Label();
            this.txt_toDelInfo = new System.Windows.Forms.TextBox();
            this.btn_startDel = new System.Windows.Forms.Button();
            this.lbl_toDelInfo = new System.Windows.Forms.Label();
            this.btn_getInfo = new System.Windows.Forms.Button();
            this.dlg_openFile = new System.Windows.Forms.FolderBrowserDialog();
            this.tip_fileName = new System.Windows.Forms.ToolTip(this.components);
            this.cms_fileOption = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.打开目录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbx_left.SuspendLayout();
            this.gbx_rightTop.SuspendLayout();
            this.gbx_rightBottom.SuspendLayout();
            this.cms_fileOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_left
            // 
            this.gbx_left.Controls.Add(this.lbx_fileList);
            this.gbx_left.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbx_left.Location = new System.Drawing.Point(14, 11);
            this.gbx_left.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbx_left.Name = "gbx_left";
            this.gbx_left.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbx_left.Size = new System.Drawing.Size(386, 551);
            this.gbx_left.TabIndex = 0;
            this.gbx_left.TabStop = false;
            this.gbx_left.Text = "将文件夹拖拽到此区域";
            // 
            // lbx_fileList
            // 
            this.lbx_fileList.AllowDrop = true;
            this.lbx_fileList.ColumnWidth = 343;
            this.lbx_fileList.ContextMenuStrip = this.cms_fileOption;
            this.lbx_fileList.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbx_fileList.FormattingEnabled = true;
            this.lbx_fileList.HorizontalExtent = 500;
            this.lbx_fileList.HorizontalScrollbar = true;
            this.lbx_fileList.IntegralHeight = false;
            this.lbx_fileList.ItemHeight = 20;
            this.lbx_fileList.Location = new System.Drawing.Point(17, 55);
            this.lbx_fileList.MultiColumn = true;
            this.lbx_fileList.Name = "lbx_fileList";
            this.lbx_fileList.ScrollAlwaysVisible = true;
            this.lbx_fileList.Size = new System.Drawing.Size(349, 484);
            this.lbx_fileList.TabIndex = 0;
            this.lbx_fileList.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbx_fileList_DragDrop);
            this.lbx_fileList.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbx_fileList_DragEnter);
            this.lbx_fileList.DragLeave += new System.EventHandler(this.lbx_fileList_DragLeave);
            this.lbx_fileList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbx_fileList_MouseMove);
            this.lbx_fileList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbx_fileList_MouseUp);
            // 
            // gbx_rightTop
            // 
            this.gbx_rightTop.Controls.Add(this.btn_openFile);
            this.gbx_rightTop.Controls.Add(this.lbl_fileType);
            this.gbx_rightTop.Controls.Add(this.lbl_path);
            this.gbx_rightTop.Controls.Add(this.btn_defaultFileType);
            this.gbx_rightTop.Controls.Add(this.btn_addPath);
            this.gbx_rightTop.Controls.Add(this.txt_fileType);
            this.gbx_rightTop.Controls.Add(this.txt_path);
            this.gbx_rightTop.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbx_rightTop.Location = new System.Drawing.Point(418, 11);
            this.gbx_rightTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbx_rightTop.Name = "gbx_rightTop";
            this.gbx_rightTop.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbx_rightTop.Size = new System.Drawing.Size(599, 167);
            this.gbx_rightTop.TabIndex = 1;
            this.gbx_rightTop.TabStop = false;
            this.gbx_rightTop.Text = "文件选项";
            // 
            // btn_openFile
            // 
            this.btn_openFile.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_openFile.Location = new System.Drawing.Point(388, 54);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(39, 25);
            this.btn_openFile.TabIndex = 5;
            this.btn_openFile.Text = ">>";
            this.btn_openFile.UseVisualStyleBackColor = true;
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // lbl_fileType
            // 
            this.lbl_fileType.AutoSize = true;
            this.lbl_fileType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_fileType.Location = new System.Drawing.Point(27, 95);
            this.lbl_fileType.Name = "lbl_fileType";
            this.lbl_fileType.Size = new System.Drawing.Size(129, 20);
            this.lbl_fileType.TabIndex = 4;
            this.lbl_fileType.Text = "要删除的文件类型";
            // 
            // lbl_path
            // 
            this.lbl_path.AutoSize = true;
            this.lbl_path.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_path.Location = new System.Drawing.Point(27, 33);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(39, 20);
            this.lbl_path.TabIndex = 3;
            this.lbl_path.Text = "路径";
            // 
            // btn_defaultFileType
            // 
            this.btn_defaultFileType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_defaultFileType.Location = new System.Drawing.Point(462, 118);
            this.btn_defaultFileType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_defaultFileType.Name = "btn_defaultFileType";
            this.btn_defaultFileType.Size = new System.Drawing.Size(121, 25);
            this.btn_defaultFileType.TabIndex = 1;
            this.btn_defaultFileType.Text = "默认";
            this.btn_defaultFileType.UseVisualStyleBackColor = true;
            this.btn_defaultFileType.Click += new System.EventHandler(this.btn_defaultFileType_Click);
            // 
            // btn_addPath
            // 
            this.btn_addPath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_addPath.Location = new System.Drawing.Point(462, 54);
            this.btn_addPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_addPath.Name = "btn_addPath";
            this.btn_addPath.Size = new System.Drawing.Size(121, 25);
            this.btn_addPath.TabIndex = 1;
            this.btn_addPath.Text = "添加";
            this.btn_addPath.UseVisualStyleBackColor = true;
            this.btn_addPath.Click += new System.EventHandler(this.btn_addPath_Click);
            // 
            // txt_fileType
            // 
            this.txt_fileType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_fileType.Location = new System.Drawing.Point(27, 119);
            this.txt_fileType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_fileType.Name = "txt_fileType";
            this.txt_fileType.Size = new System.Drawing.Size(401, 27);
            this.txt_fileType.TabIndex = 0;
            // 
            // txt_path
            // 
            this.txt_path.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_path.Location = new System.Drawing.Point(27, 55);
            this.txt_path.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(362, 27);
            this.txt_path.TabIndex = 0;
            // 
            // gbx_rightBottom
            // 
            this.gbx_rightBottom.Controls.Add(this.txt_delInfo);
            this.gbx_rightBottom.Controls.Add(this.lbl_delInfo);
            this.gbx_rightBottom.Controls.Add(this.txt_toDelInfo);
            this.gbx_rightBottom.Controls.Add(this.btn_startDel);
            this.gbx_rightBottom.Controls.Add(this.lbl_toDelInfo);
            this.gbx_rightBottom.Controls.Add(this.btn_getInfo);
            this.gbx_rightBottom.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbx_rightBottom.Location = new System.Drawing.Point(418, 185);
            this.gbx_rightBottom.Name = "gbx_rightBottom";
            this.gbx_rightBottom.Size = new System.Drawing.Size(599, 377);
            this.gbx_rightBottom.TabIndex = 2;
            this.gbx_rightBottom.TabStop = false;
            this.gbx_rightBottom.Text = "删除信息";
            // 
            // txt_delInfo
            // 
            this.txt_delInfo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_delInfo.Location = new System.Drawing.Point(31, 194);
            this.txt_delInfo.Multiline = true;
            this.txt_delInfo.Name = "txt_delInfo";
            this.txt_delInfo.ReadOnly = true;
            this.txt_delInfo.Size = new System.Drawing.Size(397, 169);
            this.txt_delInfo.TabIndex = 0;
            // 
            // lbl_delInfo
            // 
            this.lbl_delInfo.AutoSize = true;
            this.lbl_delInfo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_delInfo.Location = new System.Drawing.Point(27, 170);
            this.lbl_delInfo.Name = "lbl_delInfo";
            this.lbl_delInfo.Size = new System.Drawing.Size(69, 20);
            this.lbl_delInfo.TabIndex = 3;
            this.lbl_delInfo.Text = "删除信息";
            // 
            // txt_toDelInfo
            // 
            this.txt_toDelInfo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_toDelInfo.Location = new System.Drawing.Point(31, 58);
            this.txt_toDelInfo.Multiline = true;
            this.txt_toDelInfo.Name = "txt_toDelInfo";
            this.txt_toDelInfo.ReadOnly = true;
            this.txt_toDelInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_toDelInfo.Size = new System.Drawing.Size(397, 90);
            this.txt_toDelInfo.TabIndex = 0;
            // 
            // btn_startDel
            // 
            this.btn_startDel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_startDel.Location = new System.Drawing.Point(462, 193);
            this.btn_startDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_startDel.Name = "btn_startDel";
            this.btn_startDel.Size = new System.Drawing.Size(121, 167);
            this.btn_startDel.TabIndex = 1;
            this.btn_startDel.Text = "开始删除";
            this.btn_startDel.UseVisualStyleBackColor = true;
            this.btn_startDel.Click += new System.EventHandler(this.btn_startDel_Click);
            // 
            // lbl_toDelInfo
            // 
            this.lbl_toDelInfo.AutoSize = true;
            this.lbl_toDelInfo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_toDelInfo.Location = new System.Drawing.Point(27, 37);
            this.lbl_toDelInfo.Name = "lbl_toDelInfo";
            this.lbl_toDelInfo.Size = new System.Drawing.Size(84, 20);
            this.lbl_toDelInfo.TabIndex = 3;
            this.lbl_toDelInfo.Text = "待删除信息";
            // 
            // btn_getInfo
            // 
            this.btn_getInfo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_getInfo.Location = new System.Drawing.Point(462, 58);
            this.btn_getInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_getInfo.Name = "btn_getInfo";
            this.btn_getInfo.Size = new System.Drawing.Size(121, 90);
            this.btn_getInfo.TabIndex = 1;
            this.btn_getInfo.Text = "获取信息";
            this.btn_getInfo.UseVisualStyleBackColor = true;
            this.btn_getInfo.Click += new System.EventHandler(this.btn_getInfo_Click);
            // 
            // cms_fileOption
            // 
            this.cms_fileOption.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_fileOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开目录ToolStripMenuItem,
            this.toolStripMenuItem1});
            this.cms_fileOption.Name = "cms_fileOption";
            this.cms_fileOption.Size = new System.Drawing.Size(139, 52);
            this.cms_fileOption.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cms_fileOption_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.MergeIndex = 1;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 24);
            this.toolStripMenuItem1.Text = "删除";
            // 
            // 打开目录ToolStripMenuItem
            // 
            this.打开目录ToolStripMenuItem.MergeIndex = 0;
            this.打开目录ToolStripMenuItem.Name = "打开目录ToolStripMenuItem";
            this.打开目录ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.打开目录ToolStripMenuItem.Text = "打开目录";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 574);
            this.Controls.Add(this.gbx_rightBottom);
            this.Controls.Add(this.gbx_rightTop);
            this.Controls.Add(this.gbx_left);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "main";
            this.Text = "项目清理工具 v1.0";
            this.Load += new System.EventHandler(this.main_Load);
            this.gbx_left.ResumeLayout(false);
            this.gbx_rightTop.ResumeLayout(false);
            this.gbx_rightTop.PerformLayout();
            this.gbx_rightBottom.ResumeLayout(false);
            this.gbx_rightBottom.PerformLayout();
            this.cms_fileOption.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_left;
        private System.Windows.Forms.GroupBox gbx_rightTop;
        private System.Windows.Forms.Label lbl_fileType;
        private System.Windows.Forms.Label lbl_path;
        private System.Windows.Forms.Button btn_defaultFileType;
        private System.Windows.Forms.Button btn_addPath;
        private System.Windows.Forms.TextBox txt_fileType;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.GroupBox gbx_rightBottom;
        private System.Windows.Forms.TextBox txt_delInfo;
        private System.Windows.Forms.Label lbl_delInfo;
        private System.Windows.Forms.TextBox txt_toDelInfo;
        private System.Windows.Forms.Button btn_startDel;
        private System.Windows.Forms.Label lbl_toDelInfo;
        private System.Windows.Forms.Button btn_getInfo;
        private System.Windows.Forms.ListBox lbx_fileList;
        private System.Windows.Forms.Button btn_openFile;
        private System.Windows.Forms.FolderBrowserDialog dlg_openFile;
        private System.Windows.Forms.ToolTip tip_fileName;
        private System.Windows.Forms.ContextMenuStrip cms_fileOption;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 打开目录ToolStripMenuItem;
    }
}

