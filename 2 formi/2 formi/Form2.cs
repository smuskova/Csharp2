using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_formi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Dispose();
            this.Dispose();
        }
        private void hScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            if (hScrollBar1.Value == 1)
            {
                label2.Visible = true;
                label2.BackColor = Color.White;
                label2.BorderStyle = BorderStyle.FixedSingle;
                label2.Text = "ТАЛАНТ";
                label2.Font = new System.Drawing.Font("Times New Roman", 10, System.Drawing.FontStyle.Bold);
                label3.Visible = false;
                label4.Visible = false;
            }
            if (hScrollBar1.Value == 2)
            {
                label3.Visible = true;
                label3.BackColor = Color.Green;
                label3.BorderStyle = BorderStyle.FixedSingle;
                label3.Text = "ТРУД";
                label3.Font = new System.Drawing.Font("Times New Roman", 10, System.Drawing.FontStyle.Bold);
                label4.Visible = false;
                label2.Visible = true;
            }
            if (hScrollBar1.Value == 3)
            {
                label4.Visible = true;
                label4.BackColor = Color.Red;
                label4.BorderStyle = BorderStyle.FixedSingle;
                label4.Text = "СПОНСОРИ";
                label4.Font = new System.Drawing.Font("Times New Roman", 10, System.Drawing.FontStyle.Bold);
                label2.Visible = true;
                label3.Visible = true;
            }
        }
    }
}
