using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Stopwatch : Form
    {
        float timer = 0;
        public Stopwatch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Start
            timer1.Enabled= true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Count Up timer
            timer += timer1.Interval * 0.001f;
            textBox1.Text = timer.ToString("0.0");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Stop
            timer1.Enabled = false;
        }

        private void button3_click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //reset
            timer = 0;
            textBox1.Text = timer.ToString();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
