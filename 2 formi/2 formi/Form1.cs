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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if (textBox1.Text == "987654")
                { //textBox1.PasswordChar = '*';
                    Form2 fr2 = new Form2();
                    this.Hide();
                    fr2.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Greshna parola", "ERROR");
                    textBox1.Focus();
                    textBox1.Text = "";
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
        private void button3_Enter(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
        }
    }
   
}
