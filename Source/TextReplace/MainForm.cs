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
            ofd.Filter = "�ı��ļ�(.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbReplaceContent.Text = ofd.FileName;
            }
        }

        private void btReplaceFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ini�ļ�(.ini)|*.ini";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbReplaceFile.Text = ofd.FileName;
            }
        }

        private void btReplace_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbReplaceContent.Text.Trim()) || !File.Exists(tbReplaceContent.Text))
            {
                MessageBox.Show("�滻���ݲ����ڣ�");
                tbReplaceContent.Focus();
                return;
            }

            if (String.IsNullOrEmpty(tbReplaceFile.Text.Trim()) || !File.Exists(tbReplaceFile.Text))
            {
                MessageBox.Show("�滻�ļ������ڣ�");
                tbReplaceFile.Focus();
                return;
            }

            //ִ���滻����
            String ReplaceContent = File.ReadAllText(tbReplaceContent.Text,Encoding.Default);
            ReplaceContent = "[gamelist]\r\n" + ReplaceContent + "\r\n\r\n[camera]";

            String ReplaceFil = File.ReadAllText(tbReplaceFile.Text, Encoding.Default);

            string pattern = @"\[gamelist\][^>]*\[camera\]";//ƥ��ģʽ
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
                MessageBox.Show("����Ч��������ϣ�");
            }
            else
            {
                MessageBox.Show("û�����ݱ��滻��");
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}