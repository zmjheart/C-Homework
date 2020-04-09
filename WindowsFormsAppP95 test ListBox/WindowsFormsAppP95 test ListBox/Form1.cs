using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppP95_test_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radMan_CheckedChanged(object sender, EventArgs e)
        {
            if (radMan.Checked)
            {
                lst2.Items.Add(8);
                lst2.Items.Add("A");
                object[] obj = new object[3] { "B", "C", "D" };
                lst2.Items.AddRange(obj);
                lst2.Items.Insert(3, 1);
                lst2.Items.Insert(4, "F");
                lst2.Sorted = true;//sorted属性 排序 默认升序
            }
        }

        private void radWomen_CheckedChanged(object sender, EventArgs e)
        {
            if (radWomen.Checked)
            {
                lst2.Items.Remove(1);//删除指定值
                lst2.Items.RemoveAt(1);//删除指定索引处项目
                
                lst2.Items.Clear();//移除所有项

                int count = lst2.Items.Count;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = "";
            foreach (Object t in lst2.SelectedItems)
                s += t.ToString() + " ";
            s = "所有项:" + s;
            textBox1.Text = s;
        }
    }
}
