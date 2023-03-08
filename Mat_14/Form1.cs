using System.Drawing;
using System.Drawing.Drawing2D;

namespace Mat_14
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Resize(object sender, EventArgs e)
    {
      Text = textBox1.Left.ToString();
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {
      Pen pen = new Pen(Color.Red, 5);

      //e.Graphics.FillRectangle(Brushes.Yellow, 5, 5, 250, 200);
      //e.Graphics.DrawRectangle(pen, 5, 5, 250, 200);
      //for (int i = 0; i < 100; i = i + 15)
      //{
      //  e.Graphics.DrawLine(pen, 10, 10, 150, i + 20);
      //}
      var bod1 = new Point(10, 10);
      var bod2 = new Point(100, 100);
      var bod3 = new Point(50, 100);
      var bod4 = new Point(100, 5);
      e.Graphics.DrawBezier(pen, bod1, bod3, bod2, bod4);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Graphics graphics = this.CreateGraphics();
      Pen pen = new Pen(Color.Red, 5);

      

      graphics.FillRectangle(Brushes.Yellow, 5, 5, 250, 200);
      graphics.DrawRectangle(pen, 5, 5, 250, 200);
      var bod1 = new Point(10, 10);
      var bod2 = new Point(100, 100);
      var bod3 = new Point(50, 100);
      var bod4 = new Point(100, 5);
      Brush brush = new LinearGradientBrush(bod1,bod2,Color.White,Color.Black);
      graphics.DrawBezier(pen,bod1,bod2,bod3,bod4);
      for (int i = 0; i < 100; i = i + 15)
      {
        graphics.DrawLine(pen, 10, 10, 150, i + 20);
      }
      graphics.FillRectangle(brush, 5, 5, 250, 200);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.Refresh();
    }
  }
}