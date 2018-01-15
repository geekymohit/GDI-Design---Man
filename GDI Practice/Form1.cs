using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI_Practice
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
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //Bitmap bitmap = new Bitmap(unnamed.jpg);
            Pen pen2 = new Pen(Color.Blue);
            SolidBrush brush4 = new SolidBrush(Color.DeepSkyBlue);
            Rectangle ss = new Rectangle(0, 0, 500, 500);
            //g.FillRectangle(brush4, ss);
            Pen pen = new Pen(Color.Black);
            Rectangle rect = new Rectangle(130, 50, 100, 100);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.LightYellow, Color.Yellow, LinearGradientMode.BackwardDiagonal);
            SolidBrush brush2 = new SolidBrush(Color.LightSkyBlue);
            SolidBrush brush3 = new SolidBrush(Color.Beige);
            
            g.DrawEllipse(pen, rect);
            Rectangle rect2 = new Rectangle(150,85,10,10);
            g.DrawEllipse(pen,rect2);
            Rectangle rect3 = new Rectangle(190, 85, 10, 10);
            g.DrawEllipse(pen, rect3);
            Rectangle rect4 = new Rectangle(155,77,50,50);
            g.DrawArc(pen,rect4,40,100);
            g.DrawLine(pen,175,150,175,350);
            g.DrawLine(pen,175,210,120,275);
            g.DrawLine(pen,175,210,230,275);
            g.DrawLine(pen, 175, 350, 120, 415);
            g.DrawLine(pen, 175, 350, 230, 415);
            g.DrawLine(pen,0,415,500,415);
            g.DrawLine(pen, 0, 470, 500, 470);
            Rectangle rect7 = new Rectangle(230,350,70,70);
            g.DrawEllipse(pen,rect7);
            Rectangle rect5 = new Rectangle(0,415,500,55);
            //g.DrawEllipse(pen, rect5);
            //g.FillEllipse(brush, rect5);
            g.FillRectangle(brush3, rect5);
            Rectangle rect6 = new Rectangle(0,471,500,500);
            g.FillRectangle(brush2, rect6);
        }
    } 
}
