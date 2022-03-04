using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace GoldArch.Control01
{
    [ToolboxItem(true)]
    public partial class UcMultiFileSelect : UserControl
    {
        [Browsable(true)]
        [Description("显示文件选择按键"), Category("自定义属性组"), DefaultValue(true)]
        public bool ShowSelectButton
        {
            get => toolStripButton增加文件.Visible;
            set => toolStripButton增加文件.Visible = value;
        }

        [Browsable(true)]
        [Description("显示文件打开按键"), Category("自定义属性组"), DefaultValue(true)]
        public bool ShowOpenButton
        {
            get => toolStripButton打开当前行文件.Visible;
            set => toolStripButton打开当前行文件.Visible = value;
        }

        //dx测试内容之一：DefaultValue与字段值不一致！看看有什么影响！
        private bool _showMoveButton = true;

        [Browsable(true)]
        [Description("显示文件打开按键"), Category("自定义属性组"), DefaultValue(false)]
        public bool ShowMoveButton
        {
            get => _showMoveButton;

            set
            {
                _showMoveButton = value;
                toolStripButton上移.Visible = value;
                toolStripButton下移.Visible = value;
            }
        }

        [Browsable(true)]
        [Description("可以拖动"), Category("自定义属性组"), DefaultValue(true)]
        public bool CanDragDrop { get; set; } = true;

        //fileDialog.Title = @"请选择文件";
        //fileDialog.Filter = @"所有文件(*.*)|*.*";
        [Browsable(true)]
        [Description("fileDialog.Title"), Category("自定义属性组"), DefaultValue("请选择文件")]
        public string FileDialogTitle { get; set; } //= "请选择文件";

        [Browsable(true)]
        [Description("fileDialog.Filter"), Category("自定义属性组"), DefaultValue("所有文件(*.*)|*.*")]
        public string FileDialogFilter { get; set; } //= "所有文件(*.*)|*.*";

        private bool _multiSelect = false;

        [Browsable(true)]
        [Description("File Multiselect"), Category("自定义属性组"), DefaultValue(false)]
        public bool MultiSelect
        {
            get => _multiSelect;
            set
            {
                _multiSelect = value;
                MultiSelectSet(value);
            }
        }

        [Browsable(true)]
        [Description("单文件替换时是否提醒"), Category("自定义属性组"), DefaultValue(true)]
        public bool SingleFileReplaceReminder { get; set; } = true;

        public Func<string[], bool> FuncSelected;
        public Action<string> FuncErrorReport;

        public List<ListViewFile> GetListViewFiles()
        {
            if (ListView1.Objects == null)
            {
                return new List<ListViewFile>()
                {
                    new ListViewFile()
                };
            }

            return ListView1.Objects.OfType<ListViewFile>().ToList();
        }

        public void SetListViewFiles(List<ListViewFile> value)
        {
            ListView1.SetObjects(value);
        }

        public UcMultiFileSelect()
        {
            InitializeComponent();

            //if (CanDragDrop)
            //{
            //    textBox文件.AllowDrop = true;
            //    textBox文件.DragDrop += TextBox_DragDrop;
            //    textBox文件.DragEnter += TextBox_DragEnter;
            //}

            //SetupColumns
            //ListView1.GetColumn(0).ImageGetter = delegate (object x) { return "fileimport"; };
            ListView1.GetColumn(0).ImageGetter = x => "fileimport";
            SetupDragAndDrop();

            //Objects,FilteredObjects
            ListView1.SetObjects(new List<ListViewFile>());
        }

        private void UcMultiFileSelect_Load(object sender, EventArgs e)
        {
            MultiSelectSet(MultiSelect);
            EnableControls();
        }


        private void MultiSelectSet(bool multiSelect)
        {
            toolStripButton移除所选行.Enabled = multiSelect;
        }

        //http://objectlistview.sourceforge.net/cs/dragdrop.html
        private void SetupDragAndDrop()
        {
            // Make each listview capable of dragging rows out
            //使每个列表视图能够拖出行
            ListView1.DragSource = new SimpleDragSource();

            // Make each listview capable of accepting drops.
            // More than that, make it so it's items can be rearranged
            // 使每个列表视图能够接受丢弃。
            // 不仅如此，让它的项目可以重新排列
            //ListView1.DropSink = new RearrangingDropSink(true);
            var dropSink = new RearrangingDropSink(false); //是否接受从其它list来的拖拽
            ListView1.DropSink = dropSink;

            // For a normal drag and drop situation, you will need to create a SimpleDropSink
            // and then listen for ModelCanDrop and ModelDropped events
            // 对于正常的拖放情况，您需要创建一个 SimpleDropSink
            // 然后监听 ModelCanDrop 和 ModelDropped 事件

            //示例:
            //e:\win相关\控件\【listview】集合\objectlistview【经典扩展】\objectlistviewfull-2.9.1（经典，编译成功）\objectlistviewdemo\Demo\TabComplexExample.cs
            //dropSink.ModelDropped += delegate (object sender, ModelDropEventArgs e) {
            //    if (e.TargetModel == null)
            //        return;

            //    // Change the dropped people plus the target person to be married
            //    ((Person)e.TargetModel).MaritalStatus = MaritalStatus.Married;
            //    foreach (Person p in e.SourceModels)
            //        p.MaritalStatus = MaritalStatus.Married;

            //    // Force them to refresh
            //    e.RefreshObjects();
            //};

            ListView1.Dropped += ListView1_Dropped;
        }

        //ListView1_Dropped:
        // This event is triggered when the user releases a drag over an ObjectListView that
        // has a SimpleDropSink installed as the drop handler.
        // 当用户在 ObjectListView 上释放拖动时触发此事件
        // 安装了一个 SimpleDropSink 作为放置处理程序。
        private void ListView1_Dropped(object sender, OlvDropEventArgs e)
        {
            if (e.DataObject == null)
                return;

            //上行行焦点控制正常，下行时焦点控制不正常
            //var index=e.DropTargetIndex;

            var obj = (OLVDataObject) e.DataObject;
            var index = ListView1.IndexOf(obj.ModelObjects[0]);

            Sort();

            ListView1.SelectedIndex = index;

            EnableControls();
        }

        private string CheckFiles(string[] files)
        {
            if (!MultiSelect)
            {
                if (files.Length > 1)
                {
                    return "只能选择一个文件";
                }

                //win系统不会让文件夹和文件同名，比如不会有一个IO文件夹和一个名称去后缀为IO的文件!
                var filePath = Path.Combine(Environment.CurrentDirectory, files[0]);

                //要判断文件是否存在
                if (!File.Exists(filePath))
                {
                    //MessageBox.Show("请选择文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "请选择文件";
                }
            }
            else
            {
                foreach (string file in files)
                {
                    //要判断文件是否存在(之所以判断，是以后做拖动处理的时候，有可能拖了一个文件夹过来)
                    if (!File.Exists(file))
                    {
                        return "请选择文件";
                    }
                }
            }

            return "";
        }

        private void button选择_Click(object sender, EventArgs e)
        {
            //重要说明：本打算加入拖动文件加入列表，后来考虑，弹出文件选择框包含了一种从界面上进行的限制（比如文件扩展名），比拖动更严谨些，所以，暂时不用手动！
            //C# 之 OpenFileDialog的使用 https://www.cnblogs.com/goldarch/p/15963452.html

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = MultiSelect;
            fileDialog.Title = FileDialogTitle;
            fileDialog.Filter = FileDialogFilter;
            fileDialog.CheckFileExists = true;
            fileDialog.RestoreDirectory = true;
            fileDialog.FilterIndex = 1;
            //解决url,ink的特殊文件，不引导到文件源
            //DereferenceLinks 在从对话框返回前是否取消引用快捷方式
            fileDialog.DereferenceLinks = false; //false得到本地保存的文件名！如果是true,可能会用默认方式访问网址，得到访问的文件和文件名！

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //这是多选
                // //openFileDialog.FileNames 获取对话框中所有选定文件的文件名（String 类型数组），为绝对路径，类似"E:\\code\\123.xml"

                string[] names = fileDialog.FileNames;

                //if (CheckFiles(names)) return;
                var errCheckFiles = CheckFiles(names);
                if (!string.IsNullOrWhiteSpace(errCheckFiles))
                {
                    if (FuncErrorReport != null)
                    {
                        FuncErrorReport(errCheckFiles);
                    }
                    else
                    {
                        MessageBox.Show(errCheckFiles, @"提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    return;
                }

                if (FuncSelected != null && !FuncSelected.Invoke(names))
                {
                    EnableControls();
                    return;
                }

                //处理单个文件判断,直接替换
                if (!MultiSelect)
                {
                    if (ListView1.GetItemCount() > 0 && SingleFileReplaceReminder)
                    {
                        DialogResult result = MessageBox.Show($@"只允许存在一个文件名,确定要替换吗？：
“确定”继续，替换当前文件名。
“取消”不继续，取消本次操作", @"文件名存在提醒", MessageBoxButtons.OKCancel);

                        if (result == DialogResult.Cancel)
                        {
                            return;
                        }
                    }

                    FileInfo fi = new FileInfo(names[0]);
                    ListView1.SetObjects(new List<ListViewFile>()
                    {
                        new ListViewFile()
                        {
                            Id = Guid.NewGuid().ToString(),
                            Name = fi.Name,
                            No = 1, //从1开始，不是从0开始
                            Path = fi.FullName
                        }
                    });

                    EnableControls();
                    return;
                }

                var list = ListView1.Objects;
                //判断列表中是否存在重复!如有重复，要否退出，要么直接剔除
                ////Objects(未经过滤的原始数据),FilteredObjects（过滤结果，非快照）
                var list相同项目 = new List<string>();
                foreach (var obj in list)
                {
                    var str = ((ListViewFile) obj).Path;
                    foreach (string file in names)
                    {
                        if (file == str)
                        {
                            list相同项目.Add(file);
                            break;
                        }
                    }
                }

                if (list相同项目.Count > 0)
                {
                    var showFiles = new StringBuilder();
                    var i = 0;
                    foreach (var str in list相同项目)
                    {
                        showFiles.AppendLine(str);

                        ++i;
                        if (i == 3)
                        {
                            showFiles.AppendLine("...");
                            break;
                        }
                    }

                    DialogResult result = MessageBox.Show($@"列表中存在相同文件：
{showFiles}
“确定”继续，但不会引入相同的名称。
“取消”不继续，取消本次操作", "文件名冲突提示", MessageBoxButtons.OKCancel);

                    if (result == DialogResult.OK)
                    {
                        var newNames = names.ToList<string>();
                        newNames.RemoveAll(str => list相同项目.Contains(str));

                        names = newNames.ToArray();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        EnableControls();
                        return;
                    }
                }


                foreach (string file in names)
                {
                    //MessageBox.Show("已选择文件:" + file, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //【参数】是否要去重同文件？这里暂时直接设置不能重复
                    FileInfo fi = new FileInfo(file);

                    var item = new ListViewFile()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = fi.Name,
                        No = ListView1.Items.Count + 1, //从1开始，不是从0开始
                        Path = fi.FullName
                    };

                    ListView1.AddObject(item);

                    ListView1.EnsureModelVisible(item);
                }

                //ShowStatistics();

                EnableControls();
            }
        }

        private void Sort()
        {
            ListView1.BeginUpdate();

            for (int i = 0; i < ListView1.Items.Count; i++)
            {
                //成功！
                OLVListItem olvi = ListView1.GetItem(i);
                var obj = (ListViewFile) olvi.RowObject;
                obj.No = i + 1;
                //如果不加这个界面数据刷新反馈会滞后！
                ListView1.RefreshItem(olvi);
            }

            ListView1.EndUpdate();
        }

        private void toolStripButton移除所选行_Click(object sender, EventArgs e)
        {
            var checks = ListView1.CheckedIndices;
            if (ListView1.CheckedObjects.Count == 0)
            {
                MessageBox.Show("没有选择任何文件，请点击复选框中选择:", "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ListView1.RemoveObjects(ListView1.CheckedObjects); //另有SelectedObjects

            Sort();

            //ShowStatistics();

            EnableControls();
        }

        private void toolStripButton清空列表_Click(object sender, EventArgs e)
        {
            //这个用户是错误的
            //ListView1.Clear();

            if (ListView1.GetItemCount() > 0)
            {
                DialogResult result = MessageBox.Show($@"确定要清除所有文件名吗？：
“确定”继续。
“取消”不继续，取消本次操作", "消除提醒", MessageBoxButtons.OKCancel);

                if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            //问题，把数据源设置为null了,再次添加文件会报错！
            ListView1.ClearObjects();
            ListView1.SetObjects(new List<ListViewFile>());
            //ShowStatistics();
            EnableControls();
        }

        private void toolStripButton上移_Click(object sender, EventArgs e)
        {
            ////E:\WIN相关\控件\【Listview】集合\ObjectListView【经典扩展】\ObjectListViewFull-2.9.1（经典，编译成功）\ObjectListViewDemo\ObjectListView\Utilities\ColumnSelectionForm.cs
            //int selectedIndex = this.objectListView1.SelectedIndices[0];
            //int selectedIndex = this.ListView1.CheckedIndices[0];

            //多选或不选都为空
            if (ListView1.SelectedItem == null)
            {
                MessageBox.Show("请选择当前行", "选择提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //比如第二行:no=2,index=1,上移后：no=1,index=0
            int selectedIndex = this.ListView1.SelectedIndices[0];

            //报错：var list = ((ListViewFile[])((ArrayList)ListView1.Objects).ToArray()).ToList();
            var list = ListView1.Objects.OfType<ListViewFile>().ToList();

            var obj = list[selectedIndex];
            list.RemoveAt(selectedIndex);

            //obj.No = selectedIndex; //显示是从1开始
            list.Insert(selectedIndex - 1, obj);

            //相同的位置，新的对象
            //obj = list[selectedIndex];
            //obj.No = selectedIndex+1;

            ListView1.SetObjects(list);

            Sort();

            //默认的行为包含：原焦点定位！
            //ListView1.BuildList();

            ListView1.SelectedIndex = selectedIndex - 1;

            EnableControls();
        }

        private void toolStripButton下移_Click(object sender, EventArgs e)
        {
            //多选或不选都为空
            if (ListView1.SelectedItem == null)
            {
                MessageBox.Show("请选择当前行", "选择提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //比如第二行:no=2,index=1,下移后：no=3,index=2
            //由于最后应用sort，no不用处理，只用处理index
            int selectedIndex = this.ListView1.SelectedIndices[0];
            var list = ListView1.Objects.OfType<ListViewFile>().ToList();
            var obj = list[selectedIndex];
            list.RemoveAt(selectedIndex);
            list.Insert(selectedIndex + 1, obj);

            //重新设置列表
            ListView1.SetObjects(list);

            Sort();

            //默认的行为包含：原焦点定位！
            //ListView1.BuildList();

            ListView1.SelectedIndex = selectedIndex + 1;

            EnableControls();
        }


        private void toolStripButton打开当前行目录_Click(object sender, EventArgs e)
        {
            //多选或不选都为空
            if (ListView1.SelectedItem == null)
            {
                MessageBox.Show("请选择当前行", "选择提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var fullName = ((ListViewFile) ListView1.SelectedItem.RowObject).Path;
            //FileInfo fi = new FileInfo(path);
            //if (fi.Exists)
            //{
            //    //System.Diagnostics.Process open = new System.Diagnostics.Process
            //    //{
            //    //    StartInfo = {UseShellExecute = true, FileName = fi.DirectoryName ?? string.Empty}
            //    //};
            //    //open.Start();

            //}
            if (File.Exists(fullName))
            {
                //C# 打开指定目录并定位到文件
                OpenFolderAndSelectFile(fullName);
            }
            else
            {
                MessageBox.Show("当前文件不存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OpenFolderAndSelectFile(String fileFullName)
        {
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("Explorer.exe");
            psi.Arguments = "/e,/select," + fileFullName;
            System.Diagnostics.Process.Start(psi);
        }

        private void toolStripButton打开当前行文件_Click(object sender, EventArgs e)
        {
            //多选或不选都为空
            if (ListView1.SelectedItem == null)
            {
                MessageBox.Show("请选择当前行", "选择提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var fullName = ((ListViewFile) ListView1.SelectedItem.RowObject).Path;
            if (File.Exists(fullName))
            {
                System.Diagnostics.Process.Start(fullName);
            }
            else
            {
                MessageBox.Show("当前文件不存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Enable the controls on the dialog to match the current state
        /// 启用对话框上的控件以匹配当前状态（即处理：因list的焦点位置变化，对按键明灭的影响）
        /// </summary>
        protected void EnableControls()
        {
            if (ListView1.SelectedIndices.Count == 0)
            {
                toolStripButton上移.Enabled = false;
                toolStripButton下移.Enabled = false;
            }
            else
            {
                // Can't move the first row up or the last row down
                toolStripButton上移.Enabled = (ListView1.SelectedIndices[0] != 0);
                toolStripButton下移.Enabled = (ListView1.SelectedIndices[0] < (ListView1.GetItemCount() - 1));
            }

            ShowStatistics();
        }

        void ShowStatistics()
        {
            label总数.Text = ListView1.GetItemCount().ToString();
        }

        private void ListView1_SelectionChanged(object sender, EventArgs e)
        {
            EnableControls();
        }
    }
}