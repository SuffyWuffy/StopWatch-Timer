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
    public partial class Student_Picker : Form
    {
        public Student_Picker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (listBox1.Items.Count > 0) //if at least one person on the list
            {
                int studentNum = rnd.Next(0, listBox1.Items.Count); //get a random place on a list 
                textBox1.Text = listBox1.Items[studentNum].ToString(); //copy name to textbox

                listBox1.Items.RemoveAt(studentNum); //remove the chosen student (optional)
            }
            else
            {
                MessageBox.Show("Please add students!!!");//no students on list :(
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text); //add a student to the list
            //textBox2.AppendText(textBox2.Text);
        }
    }
}
