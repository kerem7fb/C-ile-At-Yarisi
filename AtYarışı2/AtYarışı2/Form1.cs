using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarışı2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int at1, at2, at3;
        Random rast = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            at1 = rast.Next(10, 25);
            pictureBox1.Left = pictureBox1.Left + at1;
            at2 = rast.Next(10, 25);
            pictureBox2.Left = pictureBox2.Left + at2;
            at3 = rast.Next(10, 25);
            pictureBox3.Left = pictureBox3.Left + at3;
            if (pictureBox1.Right > label5.Left) 
            {
                timer1.Enabled = false;
                MessageBox.Show("Mehmet Arda Karşı Kazandı");
            }
            else if (pictureBox2.Right >= label5.Left)
            {
                timer1.Enabled = false;
                MessageBox.Show("At Ağızlı Kazandı");
            }
            else if (pictureBox3.Right >= label5.Left)
            {
                timer1.Enabled = false;
                MessageBox.Show("Mert Duman Kazandı");
            }
            if (pictureBox1.Right > pictureBox2.Right && pictureBox1.Right > pictureBox3.Right) 
            {
                label7.Text = "Mehmet Arda Karşı Önde";
            }
            if (pictureBox2.Right > pictureBox1.Right && pictureBox2.Right > pictureBox3.Right)
            {
                label7.Text = "At Ağızlı Önde";
            }
            if (pictureBox3.Right > pictureBox2.Right && pictureBox3.Right > pictureBox1.Right)
            {
                label7.Text = "Mert Duman Önde";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(12, 45);
            pictureBox2.Location = new Point(12, 145);
            pictureBox3.Location = new Point(12, 245);
            label7.Text = "-";
        }
    }
}
