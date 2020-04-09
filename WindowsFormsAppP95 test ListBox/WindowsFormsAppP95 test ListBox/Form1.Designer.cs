namespace WindowsFormsAppP95_test_ListBox
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lst2 = new System.Windows.Forms.ListBox();
            this.radMan = new System.Windows.Forms.RadioButton();
            this.radWomen = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "打火机",
            "领带",
            "西装"});
            this.listBox1.Location = new System.Drawing.Point(168, 190);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 88);
            this.listBox1.TabIndex = 0;
            // 
            // lst2
            // 
            this.lst2.FormattingEnabled = true;
            this.lst2.ItemHeight = 12;
            this.lst2.Location = new System.Drawing.Point(438, 190);
            this.lst2.Name = "lst2";
            this.lst2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst2.Size = new System.Drawing.Size(120, 88);
            this.lst2.TabIndex = 1;
            // 
            // radMan
            // 
            this.radMan.AutoSize = true;
            this.radMan.Location = new System.Drawing.Point(406, 107);
            this.radMan.Name = "radMan";
            this.radMan.Size = new System.Drawing.Size(35, 16);
            this.radMan.TabIndex = 2;
            this.radMan.TabStop = true;
            this.radMan.Text = "男";
            this.radMan.UseVisualStyleBackColor = true;
            this.radMan.CheckedChanged += new System.EventHandler(this.radMan_CheckedChanged);
            // 
            // radWomen
            // 
            this.radWomen.AutoSize = true;
            this.radWomen.Location = new System.Drawing.Point(579, 107);
            this.radWomen.Name = "radWomen";
            this.radWomen.Size = new System.Drawing.Size(35, 16);
            this.radWomen.TabIndex = 3;
            this.radWomen.TabStop = true;
            this.radWomen.Text = "女";
            this.radWomen.UseVisualStyleBackColor = true;
            this.radWomen.CheckedChanged += new System.EventHandler(this.radWomen_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(449, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radWomen);
            this.Controls.Add(this.radMan);
            this.Controls.Add(this.lst2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox lst2;
        private System.Windows.Forms.RadioButton radMan;
        private System.Windows.Forms.RadioButton radWomen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

