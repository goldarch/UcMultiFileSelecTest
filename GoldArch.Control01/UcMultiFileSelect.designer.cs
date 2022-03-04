
namespace GoldArch.Control01
{
    partial class UcMultiFileSelect
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcMultiFileSelect));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton增加文件 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton移除所选行 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton清空列表 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton打开当前行文件 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton打开当前行目录 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton上移 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton下移 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ListView1 = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn序号 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn文件名 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn路径 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label总数 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton增加文件,
            this.toolStripButton移除所选行,
            this.toolStripButton清空列表,
            this.toolStripSeparator2,
            this.toolStripButton打开当前行文件,
            this.toolStripButton打开当前行目录,
            this.toolStripSeparator1,
            this.toolStripButton上移,
            this.toolStripButton下移,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(696, 25);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton增加文件
            // 
            this.toolStripButton增加文件.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton增加文件.Image")));
            this.toolStripButton增加文件.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton增加文件.Name = "toolStripButton增加文件";
            this.toolStripButton增加文件.Size = new System.Drawing.Size(53, 22);
            this.toolStripButton增加文件.Text = "添加";
            this.toolStripButton增加文件.Click += new System.EventHandler(this.button选择_Click);
            // 
            // toolStripButton移除所选行
            // 
            this.toolStripButton移除所选行.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton移除所选行.Image")));
            this.toolStripButton移除所选行.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton移除所选行.Name = "toolStripButton移除所选行";
            this.toolStripButton移除所选行.Size = new System.Drawing.Size(79, 22);
            this.toolStripButton移除所选行.Text = "移除选择";
            this.toolStripButton移除所选行.Click += new System.EventHandler(this.toolStripButton移除所选行_Click);
            // 
            // toolStripButton清空列表
            // 
            this.toolStripButton清空列表.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton清空列表.Image")));
            this.toolStripButton清空列表.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton清空列表.Name = "toolStripButton清空列表";
            this.toolStripButton清空列表.Size = new System.Drawing.Size(79, 22);
            this.toolStripButton清空列表.Text = "清空列表";
            this.toolStripButton清空列表.Click += new System.EventHandler(this.toolStripButton清空列表_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton打开当前行文件
            // 
            this.toolStripButton打开当前行文件.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton打开当前行文件.Image")));
            this.toolStripButton打开当前行文件.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton打开当前行文件.Name = "toolStripButton打开当前行文件";
            this.toolStripButton打开当前行文件.Size = new System.Drawing.Size(118, 22);
            this.toolStripButton打开当前行文件.Text = "打开当前行文件";
            this.toolStripButton打开当前行文件.Click += new System.EventHandler(this.toolStripButton打开当前行文件_Click);
            // 
            // toolStripButton打开当前行目录
            // 
            this.toolStripButton打开当前行目录.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton打开当前行目录.Image")));
            this.toolStripButton打开当前行目录.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton打开当前行目录.Name = "toolStripButton打开当前行目录";
            this.toolStripButton打开当前行目录.Size = new System.Drawing.Size(118, 22);
            this.toolStripButton打开当前行目录.Text = "打开当前行目录";
            this.toolStripButton打开当前行目录.Click += new System.EventHandler(this.toolStripButton打开当前行目录_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton上移
            // 
            this.toolStripButton上移.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton上移.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton上移.Image")));
            this.toolStripButton上移.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton上移.Name = "toolStripButton上移";
            this.toolStripButton上移.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton上移.Text = "上移";
            this.toolStripButton上移.Click += new System.EventHandler(this.toolStripButton上移_Click);
            // 
            // toolStripButton下移
            // 
            this.toolStripButton下移.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton下移.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton下移.Image")));
            this.toolStripButton下移.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton下移.Name = "toolStripButton下移";
            this.toolStripButton下移.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton下移.Text = "下移";
            this.toolStripButton下移.Click += new System.EventHandler(this.toolStripButton下移_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(116, 22);
            this.toolStripLabel1.Text = "*也可直接拖动排序";
            // 
            // ListView1
            // 
            this.ListView1.AllColumns.Add(this.olvColumn序号);
            this.ListView1.AllColumns.Add(this.olvColumn文件名);
            this.ListView1.AllColumns.Add(this.olvColumn路径);
            this.ListView1.AllowColumnReorder = true;
            this.ListView1.AllowDrop = true;
            this.ListView1.CellEditUseWholeCell = false;
            this.ListView1.CheckBoxes = true;
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn序号,
            this.olvColumn文件名,
            this.olvColumn路径});
            this.ListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView1.FullRowSelect = true;
            this.ListView1.GroupWithItemCountFormat = "{0} ({1} file)";
            this.ListView1.GroupWithItemCountSingularFormat = "{0} ({1} file)";
            this.ListView1.HideSelection = false;
            this.ListView1.LargeImageList = this.imageListLarge;
            this.ListView1.Location = new System.Drawing.Point(0, 25);
            this.ListView1.Name = "ListView1";
            this.ListView1.SelectColumnsOnRightClick = false;
            this.ListView1.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.ListView1.ShowGroups = false;
            this.ListView1.ShowHeaderInAllViews = false;
            this.ListView1.ShowImagesOnSubItems = true;
            this.ListView1.ShowItemToolTips = true;
            this.ListView1.Size = new System.Drawing.Size(696, 185);
            this.ListView1.SmallImageList = this.imageListSmall;
            this.ListView1.TabIndex = 21;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.SelectionChanged += new System.EventHandler(this.ListView1_SelectionChanged);
            // 
            // olvColumn序号
            // 
            this.olvColumn序号.AspectName = "No";
            this.olvColumn序号.HeaderCheckBox = true;
            this.olvColumn序号.IsEditable = false;
            this.olvColumn序号.Sortable = false;
            this.olvColumn序号.Text = "序号";
            this.olvColumn序号.Width = 72;
            // 
            // olvColumn文件名
            // 
            this.olvColumn文件名.AspectName = "Name";
            this.olvColumn文件名.IsEditable = false;
            this.olvColumn文件名.Sortable = false;
            this.olvColumn文件名.Text = "文件名";
            this.olvColumn文件名.Width = 228;
            // 
            // olvColumn路径
            // 
            this.olvColumn路径.AspectName = "Path";
            this.olvColumn路径.IsEditable = false;
            this.olvColumn路径.Sortable = false;
            this.olvColumn路径.Text = "路径";
            this.olvColumn路径.Width = 1000;
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "user");
            this.imageListLarge.Images.SetKeyName(1, "compass");
            this.imageListLarge.Images.SetKeyName(2, "down");
            this.imageListLarge.Images.SetKeyName(3, "find");
            this.imageListLarge.Images.SetKeyName(4, "folder");
            this.imageListLarge.Images.SetKeyName(5, "movie");
            this.imageListLarge.Images.SetKeyName(6, "music");
            this.imageListLarge.Images.SetKeyName(7, "no");
            this.imageListLarge.Images.SetKeyName(8, "readonly");
            this.imageListLarge.Images.SetKeyName(9, "public");
            this.imageListLarge.Images.SetKeyName(10, "recycle");
            this.imageListLarge.Images.SetKeyName(11, "spanner");
            this.imageListLarge.Images.SetKeyName(12, "star");
            this.imageListLarge.Images.SetKeyName(13, "tick");
            this.imageListLarge.Images.SetKeyName(14, "archive");
            this.imageListLarge.Images.SetKeyName(15, "system");
            this.imageListLarge.Images.SetKeyName(16, "hidden");
            this.imageListLarge.Images.SetKeyName(17, "temporary");
            this.imageListLarge.Images.SetKeyName(18, "document_file");
            this.imageListLarge.Images.SetKeyName(19, "fileimport");
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "compass");
            this.imageListSmall.Images.SetKeyName(1, "down");
            this.imageListSmall.Images.SetKeyName(2, "user");
            this.imageListSmall.Images.SetKeyName(3, "find");
            this.imageListSmall.Images.SetKeyName(4, "folder");
            this.imageListSmall.Images.SetKeyName(5, "movie");
            this.imageListSmall.Images.SetKeyName(6, "music");
            this.imageListSmall.Images.SetKeyName(7, "no");
            this.imageListSmall.Images.SetKeyName(8, "readonly");
            this.imageListSmall.Images.SetKeyName(9, "public");
            this.imageListSmall.Images.SetKeyName(10, "recycle");
            this.imageListSmall.Images.SetKeyName(11, "spanner");
            this.imageListSmall.Images.SetKeyName(12, "star");
            this.imageListSmall.Images.SetKeyName(13, "tick");
            this.imageListSmall.Images.SetKeyName(14, "archive");
            this.imageListSmall.Images.SetKeyName(15, "system");
            this.imageListSmall.Images.SetKeyName(16, "hidden");
            this.imageListSmall.Images.SetKeyName(17, "temporary");
            this.imageListSmall.Images.SetKeyName(18, "document_file");
            this.imageListSmall.Images.SetKeyName(19, "fileimport");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label总数);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 27);
            this.panel1.TabIndex = 22;
            // 
            // label总数
            // 
            this.label总数.AutoSize = true;
            this.label总数.Location = new System.Drawing.Point(45, 7);
            this.label总数.Name = "label总数";
            this.label总数.Size = new System.Drawing.Size(11, 12);
            this.label总数.TabIndex = 1;
            this.label总数.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "总数：";
            // 
            // UcMultiFileSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UcMultiFileSelect";
            this.Size = new System.Drawing.Size(696, 237);
            this.Load += new System.EventHandler(this.UcMultiFileSelect_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton增加文件;
        private System.Windows.Forms.ToolStripButton toolStripButton移除所选行;
        private System.Windows.Forms.ToolStripButton toolStripButton清空列表;
        private BrightIdeasSoftware.ObjectListView ListView1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton上移;
        private System.Windows.Forms.ToolStripButton toolStripButton下移;
        private BrightIdeasSoftware.OLVColumn olvColumn序号;
        private BrightIdeasSoftware.OLVColumn olvColumn文件名;
        private BrightIdeasSoftware.OLVColumn olvColumn路径;
        private System.Windows.Forms.ToolStripButton toolStripButton打开当前行文件;
        private System.Windows.Forms.ToolStripButton toolStripButton打开当前行目录;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label总数;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ImageList imageListLarge;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}
