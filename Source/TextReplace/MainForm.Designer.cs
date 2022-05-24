namespace TextReplace
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tbReplaceContent = new System.Windows.Forms.TextBox();
            this.tbReplaceFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btReplaceContent = new System.Windows.Forms.Button();
            this.btReplaceFile = new System.Windows.Forms.Button();
            this.btReplace = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请选择更换使用的互动效果txt文档：";
            // 
            // tbReplaceContent
            // 
            this.tbReplaceContent.Location = new System.Drawing.Point(206, 63);
            this.tbReplaceContent.Name = "tbReplaceContent";
            this.tbReplaceContent.Size = new System.Drawing.Size(342, 21);
            this.tbReplaceContent.TabIndex = 1;
            // 
            // tbReplaceFile
            // 
            this.tbReplaceFile.Location = new System.Drawing.Point(243, 113);
            this.tbReplaceFile.Name = "tbReplaceFile";
            this.tbReplaceFile.Size = new System.Drawing.Size(305, 21);
            this.tbReplaceFile.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "请选择软件所在位置bin\\settubg.ini文件：";
            // 
            // btReplaceContent
            // 
            this.btReplaceContent.Location = new System.Drawing.Point(555, 63);
            this.btReplaceContent.Name = "btReplaceContent";
            this.btReplaceContent.Size = new System.Drawing.Size(23, 23);
            this.btReplaceContent.TabIndex = 4;
            this.btReplaceContent.Text = ">";
            this.btReplaceContent.UseVisualStyleBackColor = true;
            this.btReplaceContent.Click += new System.EventHandler(this.btReplaceContent_Click);
            // 
            // btReplaceFile
            // 
            this.btReplaceFile.Location = new System.Drawing.Point(555, 113);
            this.btReplaceFile.Name = "btReplaceFile";
            this.btReplaceFile.Size = new System.Drawing.Size(23, 23);
            this.btReplaceFile.TabIndex = 5;
            this.btReplaceFile.Text = ">";
            this.btReplaceFile.UseVisualStyleBackColor = true;
            this.btReplaceFile.Click += new System.EventHandler(this.btReplaceFile_Click);
            // 
            // btReplace
            // 
            this.btReplace.Location = new System.Drawing.Point(473, 164);
            this.btReplace.Name = "btReplace";
            this.btReplace.Size = new System.Drawing.Size(75, 23);
            this.btReplace.TabIndex = 6;
            this.btReplace.Text = "开始更换";
            this.btReplace.UseVisualStyleBackColor = true;
            this.btReplace.Click += new System.EventHandler(this.btReplace_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(374, 164);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 7;
            this.btClose.Text = "关闭";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 266);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btReplace);
            this.Controls.Add(this.btReplaceFile);
            this.Controls.Add(this.btReplaceContent);
            this.Controls.Add(this.tbReplaceFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbReplaceContent);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "互动效果更换工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbReplaceContent;
        private System.Windows.Forms.TextBox tbReplaceFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btReplaceContent;
        private System.Windows.Forms.Button btReplaceFile;
        private System.Windows.Forms.Button btReplace;
        private System.Windows.Forms.Button btClose;
    }
}

