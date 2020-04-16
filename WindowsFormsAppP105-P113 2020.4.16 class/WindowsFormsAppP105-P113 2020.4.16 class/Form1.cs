using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppP105_P113_2020._4._16_class
{
    public partial class Form1 : Form
    {
        int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void but_start_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void but_set_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = int.Parse(txt_time.Text);
            progressBar1.Value = int.Parse(txt_time.Text);
            i = int.Parse(txt_time.Text);
            but_start.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            i -= 1;
            if (i >= 0)
            {
                progressBar1.Value = i;
                txt_time.Text = i.ToString();
            }
            else
            {
                but_start.Enabled = false;
                timer1.Enabled = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int page = Int32.Parse(txtPage.Text);
            if (page < 1 || page > 3)
            {
                MessageBox.Show("请输入1-3之间的整数", "选项卡使用");
                txtPage.Focus();
                return;
            }
            tabControl2.SelectedIndex = page - 1;
        }

        private void btnCLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = this.tabControl2.SelectedIndex + 1;
            MessageBox.Show("您选中的是" + n + "张选项卡", "选项卡使用");
        }
    }
}
