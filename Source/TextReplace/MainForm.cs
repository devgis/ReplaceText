using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace TextReplace
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btReplaceContent_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "文本文件(.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbReplaceContent.Text = ofd.FileName;
            }
        }

        private void btReplaceFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ini文件(.ini)|*.ini";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbReplaceFile.Text = ofd.FileName;
            }
        }

        private void btReplace_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbReplaceContent.Text.Trim()) || !File.Exists(tbReplaceContent.Text))
            {
                MessageBox.Show("替换内容不存在！");
                tbReplaceContent.Focus();
                return;
            }

            if (String.IsNullOrEmpty(tbReplaceFile.Text.Trim()) || !File.Exists(tbReplaceFile.Text))
            {
                MessageBox.Show("替换文件不存在！");
                tbReplaceFile.Focus();
                return;
            }

            //执行替换操作
            String ReplaceContent = File.ReadAllText(tbReplaceContent.Text,Encoding.Default);
            ReplaceContent = "[gamelist]\r\n" + ReplaceContent + "\r\n\r\n[camera]";

            String ReplaceFil = File.ReadAllText(tbReplaceFile.Text, Encoding.Default);

            string pattern = @"\[gamelist\][^>]*\[camera\]";//匹配模式
            Regex regex = new Regex(pattern);

            int iCount = 0;
            foreach (Match m in regex.Matches(ReplaceFil))
            {
                //MessageBox.Show(m.Value);
                ReplaceFil=ReplaceFil.Replace(m.Value, ReplaceContent);
                iCount++;
            }
            if (iCount > 0)
            {
                File.WriteAllText(tbReplaceFile.Text, ReplaceFil, Encoding.Default);
                MessageBox.Show("互动效果更换完毕！");
            }
            else
            {
                MessageBox.Show("没有内容被替换！");
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}