
namespace UcMultiFileSelecTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button文件处理 = new System.Windows.Forms.Button();
            this.checkBox多文件选择 = new System.Windows.Forms.CheckBox();
            this.checkBox单文件模式替换提醒 = new System.Windows.Forms.CheckBox();
            this.checkBox加入列表前的自定义检查 = new System.Windows.Forms.CheckBox();
            this.ucMultiFileSelect1 = new GoldArch.Control01.UcMultiFileSelect();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 306);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(887, 185);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // button文件处理
            // 
            this.button文件处理.Location = new System.Drawing.Point(12, 277);
            this.button文件处理.Name = "button文件处理";
            this.button文件处理.Size = new System.Drawing.Size(110, 23);
            this.button文件处理.TabIndex = 2;
            this.button文件处理.Text = "文件处理测试";
            this.button文件处理.UseVisualStyleBackColor = true;
            this.button文件处理.Click += new System.EventHandler(this.button文件处理_Click);
            // 
            // checkBox多文件选择
            // 
            this.checkBox多文件选择.AutoSize = true;
            this.checkBox多文件选择.Checked = true;
            this.checkBox多文件选择.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox多文件选择.Location = new System.Drawing.Point(728, 12);
            this.checkBox多文件选择.Name = "checkBox多文件选择";
            this.checkBox多文件选择.Size = new System.Drawing.Size(84, 16);
            this.checkBox多文件选择.TabIndex = 4;
            this.checkBox多文件选择.Text = "多文件选择";
            this.checkBox多文件选择.UseVisualStyleBackColor = true;
            this.checkBox多文件选择.CheckedChanged += new System.EventHandler(this.checkBox多文件选择_CheckedChanged);
            // 
            // checkBox单文件模式替换提醒
            // 
            this.checkBox单文件模式替换提醒.AutoSize = true;
            this.checkBox单文件模式替换提醒.Checked = true;
            this.checkBox单文件模式替换提醒.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox单文件模式替换提醒.Location = new System.Drawing.Point(728, 34);
            this.checkBox单文件模式替换提醒.Name = "checkBox单文件模式替换提醒";
            this.checkBox单文件模式替换提醒.Size = new System.Drawing.Size(132, 16);
            this.checkBox单文件模式替换提醒.TabIndex = 5;
            this.checkBox单文件模式替换提醒.Text = "单文件模式替换提醒";
            this.checkBox单文件模式替换提醒.UseVisualStyleBackColor = true;
            this.checkBox单文件模式替换提醒.CheckedChanged += new System.EventHandler(this.checkBox单文件模式替换提醒_CheckedChanged);
            // 
            // checkBox加入列表前的自定义检查
            // 
            this.checkBox加入列表前的自定义检查.AutoSize = true;
            this.checkBox加入列表前的自定义检查.Checked = true;
            this.checkBox加入列表前的自定义检查.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox加入列表前的自定义检查.Location = new System.Drawing.Point(728, 56);
            this.checkBox加入列表前的自定义检查.Name = "checkBox加入列表前的自定义检查";
            this.checkBox加入列表前的自定义检查.Size = new System.Drawing.Size(156, 16);
            this.checkBox加入列表前的自定义检查.TabIndex = 6;
            this.checkBox加入列表前的自定义检查.Text = "加入列表前的自定义检查";
            this.checkBox加入列表前的自定义检查.UseVisualStyleBackColor = false;
            // 
            // ucMultiFileSelect1
            // 
            this.ucMultiFileSelect1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucMultiFileSelect1.FileDialogFilter = null;
            this.ucMultiFileSelect1.FileDialogTitle = null;
            this.ucMultiFileSelect1.Location = new System.Drawing.Point(12, 12);
            this.ucMultiFileSelect1.MultiSelect = true;
            this.ucMultiFileSelect1.Name = "ucMultiFileSelect1";
            this.ucMultiFileSelect1.ShowMoveButton = true;
            this.ucMultiFileSelect1.Size = new System.Drawing.Size(696, 203);
            this.ucMultiFileSelect1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 498);
            this.Controls.Add(this.checkBox加入列表前的自定义检查);
            this.Controls.Add(this.checkBox单文件模式替换提醒);
            this.Controls.Add(this.checkBox多文件选择);
            this.Controls.Add(this.ucMultiFileSelect1);
            this.Controls.Add(this.button文件处理);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "多选文件列表测试";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button文件处理;
        private GoldArch.Control01.UcMultiFileSelect ucMultiFileSelect1;
        private System.Windows.Forms.CheckBox checkBox多文件选择;
        private System.Windows.Forms.CheckBox checkBox单文件模式替换提醒;
        private System.Windows.Forms.CheckBox checkBox加入列表前的自定义检查;
    }
}

