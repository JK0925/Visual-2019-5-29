using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A007_Flag
{
    public partial class Form1 : Form
    {
        private bool flag=false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                label1.Text = "안녕하세요";
                flag = true;
            }
            else
            {
                label1.Text = "";
                flag = false;
            }
            /*
            if (label1.Text == "")
            {
                label1.Text = "안녕하세요";
            }
            else
            {
                label1.Text = "";
            }
            */
        }
    }
}
