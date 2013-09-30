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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.Visible = false;
            Form10 f10 = new Form10();
            f10.Visible = true;
            f10.StartPosition = FormStartPosition.CenterParent;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.Visible = false;
            Form11 f11 = new Form11();
            f11.Visible = true;
            f11.StartPosition = FormStartPosition.CenterParent;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.Visible = false;
            Form12 f12 = new Form12();
            f12.Visible = true;
            f12.StartPosition = FormStartPosition.CenterParent;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.Visible = false;
            Form13 f13 = new Form13();
            f13.Visible = true;
            f13.StartPosition = FormStartPosition.CenterParent;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.Visible = false;
            Form14 f14 = new Form14();
            f14.Visible = true;
            f14.StartPosition = FormStartPosition.CenterParent;
        }
    }
}
