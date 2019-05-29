using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A026_DigitalClockWF
{
    public partial class Form1 : Form
    {
        private object dClock;

        public Form1()
        {
            InitializeComponent();
        }

        public int Timer_Tick { get; private set; }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }
    }
}
