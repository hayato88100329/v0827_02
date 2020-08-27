using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0827_02
{
    public partial class Form1 : Form
    {
        int vx = rand.Next(-10, 12);
        int vy = rand.Next(-10, 12);
        int point = -100;
        static Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Height-label1.Height);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            point--;
            label3.Text = "Score " + point;

            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left < 0)
            {
                vx = Math.Abs(vx);
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy);
            }
            if (label1.Right > ClientSize.Width)
            {
                vx = -Math.Abs(vx);
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
