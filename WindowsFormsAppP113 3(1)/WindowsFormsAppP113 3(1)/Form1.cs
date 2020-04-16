using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppP113_3_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(txt1.Text);
            int b = Int32.Parse(txt2.Text);
            String result="";
            if (rad1.Checked)
            {
                result = (a + b).ToString();
            }
            else if(rad2.Checked)
            {
                result = (a - b).ToString();
            }
            else if(rad3.Checked)
            {
                result = (a * b).ToString();
            }
            else if(rad4.Checked)
            {
                result = ((Double)a - (Double)b).ToString();
            }
            else
            {
                MessageBox.Show("请选择运算符", "错误提示");
            }
            txtRes.Text = result;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
