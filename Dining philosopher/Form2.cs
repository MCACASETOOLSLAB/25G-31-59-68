using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dining_Philosopher1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                this.Visible = false;
                Form3 f3 = new Form3();
                f3.Visible = true;
                f3.StartPosition = FormStartPosition.CenterParent;
            
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 f4 = new Form4();
            f4.Visible = true;
            f4.StartPosition = FormStartPosition.CenterParent;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
