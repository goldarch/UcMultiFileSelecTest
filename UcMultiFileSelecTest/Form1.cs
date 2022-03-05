using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UcMultiFileSelecTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ucMultiFileSelect1.FuncSelected += FileSelected;

            checkBox多文件选择.Checked = ucMultiFileSelect1.MultiSelect;
            checkBox单文件模式替换提醒.Checked = ucMultiFileSelect1.SingleFileReplaceReminder;
        }
        private void button文件处理_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            var list = ucMultiFileSelect1.GetListViewFiles();
            foreach (var listViewFile in list)
            {
                richTextBox1.AppendText(listViewFile.No + ":" + listViewFile.Name + Environment.NewLine);
            }
        }

        bool FileSelected(string[] names)
        {
            if (!checkBox加入列表前的自定义检查.Checked)
            {
                return true;
            }

            DialogResult result = MessageBox.Show(this,$@"文件选择的业务逻辑判断，一般情况下，可以在文件处理时再进行业务判断，但如果必要，在这里做？：
“确定”继续，文件添加到列表。
“取消”不继续，取消本次操作。", @"模拟文件选择的业务限制", MessageBoxButtons.OKCancel);

            return result == DialogResult.OK;
        }

        private void checkBox多文件选择_CheckedChanged(object sender, EventArgs e)
        {
            ucMultiFileSelect1.MultiSelect = checkBox多文件选择.Checked;
        }

        private void checkBox单文件模式替换提醒_CheckedChanged(object sender, EventArgs e)
        {
            ucMultiFileSelect1.SingleFileReplaceReminder = checkBox单文件模式替换提醒.Checked;
        }
    }
}
