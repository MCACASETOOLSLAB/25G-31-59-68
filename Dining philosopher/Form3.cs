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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.Visible = false;
            Form5 f5 = new Form5();
            f5.Visible = true;
            f5.StartPosition = FormStartPosition.CenterParent;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.Visible = false;
            Form6 f6 = new Form6();
            f6.Visible = true;
            f6.StartPosition = FormStartPosition.CenterParent;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.Visible = false;
            Form7 f7 = new Form7();
            f7.Visible = true;
            f7.StartPosition = FormStartPosition.CenterParent;
        }

      

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.Visible = false;
            Form8 f8 = new Form8();
            f8.Visible = true;
            f8.StartPosition = FormStartPosition.CenterParent;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.Visible = false;
            Form9 f9 = new Form9();
            f9.Visible = true;
            f9.StartPosition = FormStartPosition.CenterParent;
        }
    }
}
