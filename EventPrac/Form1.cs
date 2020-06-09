using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Text = "으악!";
            btn.Enabled = false;
            //textBox1.Text += "★";
            //label1.Text += "◎";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "X : " + e.X + ", Y : " + e.Y;
        }

        private int elapsedTime = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            label2.Text = "" + elapsedTime;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            elapsedTime = 0;
        }
    }
}
