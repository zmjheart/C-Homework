using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example3_19
{
    public partial class Form1 : Form
    {
        const int commonPrice = 60;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdbNine_CheckedChanged(object sender, EventArgs e)
        {
            txtPrice.Text = string.Format("{0:f2}", commonPrice * 90 / 100);
        }

        private void rdbEight_CheckedChanged(object sender, EventArgs e)
        {
            txtPrice.Text = string.Format("{0:f2}", commonPrice * 80 / 100);
        }

        private void rdbSixFive_CheckedChanged(object sender, EventArgs e)
        {
            txtPrice.Text = string.Format("{0:f2}", commonPrice * 65 / 100);
        }

        private void cmbTicketType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtReceive.Text = "";
            txtChange.Text = "";

            //折扣设置不可用
            grpDiscount.Enabled = false;

            switch (cmbTicketType.SelectedIndex)
            {
                case 0:
                    txtPrice.Text = string.Format("{0:f2}", commonPrice);
                    break;
                case 1:
                    txtPrice.Text = string.Format("{0:f2}", commonPrice * 50 / 100);
                    break;
                case 2:
                    grpDiscount.Enabled = true;
                    rdbNine.Checked = true;
                    txtPrice.Text = string.Format("{0:f2}", commonPrice * 90 / 100);
                    break;
            }
        }

        private void txtTotalTicket_TextChanged(object sender, EventArgs e)
        {
            int tickets;
            double receiving, price;
            try
            {
                txtReceive.Text = "";
                tickets = Int32.Parse(txtTotalTicket.Text);
                price = double.Parse(txtPrice.Text);

                receiving = tickets * price;
                txtReceive.Text = String.Format("{0:f2}", receiving);
            }
            catch
            {
                MessageBox.Show("输入有错！请检查购票数量");
                return;
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            double payment, receiving, balance, price;
            int tickets;

            try
            {
                tickets = Int32.Parse(txtTotalTicket.Text);
                payment = double.Parse(txtPayment.Text);
                price = double.Parse(txtPrice.Text);

                receiving = tickets * price;
                txtReceive.Text = String.Format("{0:f2}", receiving);

                balance = payment - receiving;
                txtChange.Text = String.Format("{0:f2}", balance);

                if(balance<0)
                {
                    MessageBox.Show("钱不够");
                    txtPayment.Text = "";
                    txtChange.Text = "";
                    txtPayment.Focus();
                }
                else
                {
                    MessageBox.Show("购票成功\n\n票价:" + txtPrice.Text
                        + "元,票数……");
                }
            }
            catch
            {
                MessageBox.Show("输入有错！请检查");
                return;
            }
        }
    }
}
