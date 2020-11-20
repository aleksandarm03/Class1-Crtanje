using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Class1
{
    class Class1
    {
        Point o;
        int a;

        public Class1(Point o)
        {
            this.o = o;
            a = 20;
        }
        public void Crtaj(Graphics g, Color boja)
        {
            Pen olovka = new Pen(boja, 2);
            Point[] c = new Point[4];
            c[0] = new Point(o.X + 5 * a / 2, o.Y + a);
            c[1] = new Point(o.X + a, o.Y + a);
            c[2] = new Point(o.X + a, o.Y + 4 * a);
            c[3] = new Point(o.X + 5 * a / 2, o.Y + 4 * a);
            Point[] l = new Point[3];
            l[0] = new Point(o.X + 7 * a / 2, o.Y + a);
            l[1] = new Point(o.X + 7 * a / 2, o.Y + 4 * a);
            l[2] = new Point(o.X + 5 * a, o.Y + 4 * a);
            Point[] A = new Point[3];
            A[0] = new Point(o.X + 6 * a, o.Y + 4 * a);
            A[1] = new Point(o.X + 7 * a, o.Y + a);
            A[2] = new Point(o.X + 8 * a, o.Y + 4 * a);
            //A[3] = new Point(o.X + 13 * a / 2, o.Y + 5 * a / 2); 
            //A[4] = new Point(o.X + 15 * a / 2, o.Y + 5 * a / 2); 
            Point[] s1 = new Point[6];
            s1[0] = new Point(o.X + 21 * a / 2, o.Y + a);
            s1[1] = new Point(o.X + 9 * a, o.Y + a);
            s1[2] = new Point(o.X + 9 * a, o.Y + 5 * a / 2);
            s1[3] = new Point(o.X + 21 * a / 2, o.Y + 5 * a / 2);
            s1[4] = new Point(o.X + 21 * a / 2, o.Y + 4 * a);
            s1[5] = new Point(o.X + 9 * a, o.Y + 4 * a);
            Point[] s2 = new Point[6];
            s2[0] = new Point(o.X + 13 * a, o.Y + a);
            s2[1] = new Point(o.X + 23 * a / 2, o.Y + a);
            s2[2] = new Point(o.X + 23 * a / 2, o.Y + 5 * a / 2);
            s2[3] = new Point(o.X + 13 * a, o.Y + 5 * a / 2);
            s2[4] = new Point(o.X + 13 * a, o.Y + 4 * a);
            s2[5] = new Point(o.X + 23 * a / 2, o.Y + 4 * a);
            Point[] uno = new Point[3];
            uno[0] = new Point(o.X + 14 * a, o.Y + 2 * a);
            uno[1] = new Point(o.X + 29 * a / 2, o.Y + a);
            uno[2] = new Point(o.X + 29 * a / 2, o.Y + 4 * a);
            g.DrawLines(olovka, c);
            g.DrawLines(olovka, l);
            g.DrawLines(olovka, A);
            g.DrawLine(olovka, o.X + 13 * a / 2, o.Y + 5 * a / 2, o.X + 15 * a / 2, o.Y + 5 * a / 2); //A[3], A[4] 
            g.DrawLines(olovka, s1);

        }
    }
}
