using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xt3_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_compare_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int num3 = int.Parse(txtNum3.Text);
            int[] numbers = new int[3] { num1, num2, num3 };
            int max = num1, min = num1;
            //max = num1 > num2 ? num1 : num2;
            //max = num3 > max ? num3 : max;

            for (int i = 1; i <= 2; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            txtMin.Text = min.ToString();
            txtMax.Text = max.ToString();
        }
    }
}
