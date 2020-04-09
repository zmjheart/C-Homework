using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppP93例4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string str = "";
            if (checkBox1.Checked)
            {
                str += checkBox1.Text + ",";
            }
            if (checkBox2.Checked)
            {
                str += checkBox2.Text + ",";
            }
            if (checkBox3.Checked)
            {
                str += checkBox3.Text + ",";
            }
            if (checkBox4.Checked)
            {
                str += checkBox4.Text + ",";
            }
            if (radMale.Checked)
            {
                str += groupBox2.Text + "为" + radMale.Text;
            }
            else
            {
                str += groupBox2.Text + "为" + radFemale.Text;
            }
            MessageBox.Show(str, "问卷调查");

        }
    }
}
