using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_P97_CheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("f", true);
            checkedListBox1.Items.Add("g", false);
            checkedListBox1.Items.Add("h", CheckState.Unchecked); ;
            checkedListBox1.Items.Add("i", CheckState.Indeterminate); ;

            checkedListBox1.SetItemChecked(1, true);
            checkedListBox1.SetItemCheckState(2, CheckState.Indeterminate);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
