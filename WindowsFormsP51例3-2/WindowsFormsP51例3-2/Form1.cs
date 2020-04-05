using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsP51例3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String strMsg = txtName.Text + "出生于" + txtAddress.Text;
            MessageBox.Show(strMsg, "姓名和出生地", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
