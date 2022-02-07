using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//g.FillEllipse(b, x + 1 * num, y - 2 * num, 6, 6);
//SolidBrush b = new SolidBrush(Color.Red);
//g.DrawLine(Pens.Black, x, y, x, y - 5);
//g.DrawEllipse(Pens.Black, x - 3, y - 3, x1, y1);
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            g = CreateGraphics();
            g.Clear(Color.White);
        }

        Graphics g;
        SolidBrush b = new SolidBrush(Color.Red);
        int selection = 0;float x = 250; float y = 250;float r = 0; int a = 0;int z;bool counter = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            switch (selection)
            {
                case 0:
                    g.DrawLine(Pens.White, x, y + 5, x, y);
                    g.DrawLine(Pens.Black, x, y, x, y - 5);
                    y -= 5;
                    if (y == 100)
                    {
                        selection++;
                    }
                    break;
                case 1:
                    g.DrawLine(Pens.White, x, y + 10, x, y);
                    timer1.Enabled = false;
                    timer2.Enabled = true;
                    Console.WriteLine(x); Console.WriteLine(y);
                    a = 0;
                    g.DrawEllipse(Pens.Black, x, y, 1, 1);
                    break;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            /*if (counter == true)
            {
                g.DrawLine(Pens.Black, x, z, x, 0.00161F * (a + 250) * (a + 250) + 100);
                z = (0.00161F * (a + 250) * (a + 250) + 100);
                x = 2;
                counter = false;
            }
            else
            {
                g.DrawLine(Pens.Black, x, z, x, 0.00161F * (a + 250) * (a + 250) + 100);
                z = (0.00161F * (a + 250) * (a + 250) + 100);
                x ++;
            }*/
            if (a < 40)
            {   
                r = 0.15f*(0.24f*a * a);
                g.DrawEllipse(Pens.Red, x + a, y + r, 1, 1);
                r = 0.25f * (0.24f * a * a);
                g.DrawEllipse(Pens.DarkSlateBlue, x + a, y + r, 1, 1);
                r = 0.1f * (0.24f * a * a);
                g.DrawEllipse(Pens.DeepPink, x + a, y + r, 1, 1);
                r = 0.15f*(0.24F * a * a - 10f * (a) + 0);
                g.DrawEllipse(Pens.Blue, x + a, y + r, 1, 1); 
                r = 0.15f*(0.3F * a * a - 15 * a + 5);
                g.DrawEllipse(Pens.DeepSkyBlue, x + a, y + r, 1, 1);
                r = 0.15f * (0.3F * a * a -9*a+ 5);
                g.DrawEllipse(Pens.Coral, x + a, y + r, 1, 1);
                r = 0.15f * (0.3F * a * a - 6 * a + 5);
                g.DrawEllipse(Pens.GreenYellow, x + a, y + r, 1, 1);
                r = 0.15f*(0.24F * a*a-15*a+7);
                g.DrawEllipse(Pens.DarkOrchid, x + a, y + r, 1, 1);
                r = 0.15f*(0.24F * a * a - 12 * a + 12);
                g.DrawEllipse(Pens.DarkOrange, x+a, y+r, 1, 1);

                r = 0.15f * (0.24f * a * a);
                g.DrawEllipse(Pens.Red, x - a, y + r, 1, 1);
                r = 0.25f * (0.24f * a * a);
                g.DrawEllipse(Pens.DarkSlateBlue, x - a, y + r, 1, 1);
                r = 0.1f * (0.24f * a * a);
                g.DrawEllipse(Pens.DeepPink, x - a, y + r, 1, 1);
                r = 0.15f * (0.24F * a * a - 10f * (a) + 0);
                g.DrawEllipse(Pens.Blue, x -a, y + r, 1, 1);
                r = 0.15f * (0.3F * a * a - 15 * a + 5);
                g.DrawEllipse(Pens.DeepSkyBlue, x - a, y + r, 1, 1);
                r = 0.15f * (0.3F * a * a - 9 * a + 5);
                g.DrawEllipse(Pens.Coral, x - a, y + r, 1, 1);
                r = 0.15f * (0.3F * a * a - 6 * a + 5);
                g.DrawEllipse(Pens.GreenYellow, x - a, y + r, 1, 1);
                r = 0.15f * (0.24F * a * a - 15 * a + 7);
                g.DrawEllipse(Pens.DarkOrchid, x - a, y + r, 1, 1);
                r = 0.15f * (0.24F * a * a - 12 * a + 12);
                g.DrawEllipse(Pens.DarkOrange, x - a, y + r, 1, 1);

                a++;
            }

           
/*          g.DrawLine(Pens.Black, a, r, a, 0.00161F * (a + 250)*(a + 250) + 100);
            r = (0.00161F * (a + 250) * (a + 250) + 100);
            a++;*/
            Console.WriteLine(x); Console.WriteLine(x - 0.1F * x * x);
        }
    }
}
