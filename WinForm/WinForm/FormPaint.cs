using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Drawing.Drawing2D;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class FormPaint : Form
    {
        public FormPaint()
        {
            InitializeComponent();
        }
        public bool Mouse = true;
        Pen pen = new Pen(Color.Black, 2);
        Point _startPoint = new Point();
        Point _endPoint = new Point();
        Point _pRectangleStart = new Point();
        Point _pRectangleEnd = new Point();
        Point _pRectangle = new Point();
        private void Draw(object sender, EventArgs e)
        {

        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse = true;
            xclicklbl.Text = e.X.ToString();
            yclicklbl.Text = e.Y.ToString();
            _startPoint = new Point(e.X, e.Y);
            _pRectangleStart = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Mouse = false;
            xuplbl.Text = e.X.ToString();
            yuplbl.Text = e.Y.ToString();
            _endPoint = new Point(e.X, e.Y);
            _pRectangleEnd = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            xlbl.Text = e.X.ToString();
            ylbl.Text = e.Y.ToString();
            _pRectangle = new Point(e.X, e.Y);
        }


        private void whitebtn_Click_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            pen.Color = btn.BackColor;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pen.DashStyle = DashStyle.Dash;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pen.DashStyle = DashStyle.DashDotDot;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pen.DashStyle = DashStyle.DashDot;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pen.DashStyle = DashStyle.Dot;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.DrawLine(pen, _startPoint, _endPoint);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen cellPen = new Pen(Color.Gray, 1);

            for (int x = 0; x < 1295; x = x + 20)
            {
                g.DrawLine(cellPen, x, 0, x, 706);
            }

            for (int y = 0; y < 706; y = y + 20)
            {
                g.DrawLine(cellPen, 0, y, 1295, y);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Rectangle rectangle = new Rectangle(_startPoint.X, _startPoint.Y, _endPoint.X, _endPoint.Y);
            graphics.DrawRectangle(pen, rectangle);
        }
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
