using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Class1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random r = new Random();
        Graphics g;
        Class1 c;
        Color boja;
        Point p;
        int x = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 800;
            Height = 600;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();         
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (x % 2 == 0) timer1.Start();
            else timer1.Stop();
            ++x;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            boja = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
            p = new Point(r.Next(0,800),r.Next(0,600));
            c = new Class1(p);
            c.Crtaj(g,boja);
        }
    }
}
