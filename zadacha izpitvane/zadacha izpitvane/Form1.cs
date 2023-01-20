using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadacha_izpitvane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private int nameri(int n, int a)
        { int newCH;
            int br = 0;
            while(n !=0)
            { newCH = n % 10;
                if (newCH == a)
                {
                    br++; 
                }
                n = n / 10;
            }
            return br;
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            int n = int.Parse(textBox1.Text);
            int a = int.Parse(textBox2.Text);
            int rezultat= nameri(n, a);
            textBox3.Text = rezultat.ToString();
            
        }
    }
}
