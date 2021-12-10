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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch form1 = new Stopwatch();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student_Picker form = new Student_Picker();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dice__6_sided_ form = new Dice__6_sided_();
            form.Show();
        }
    }
}
