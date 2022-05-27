namespace BIVT_21_15_Liamin_Borodin.D.A_.LV_2_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int X = this.Width / 2;
            int Y = this.Height / 2;
            g.TranslateTransform(X, Y);
            g.DrawEllipse(new Pen(Color.Red, 8.0f), 0, 0, 1, 1);
            double x;
            double y;
            g.DrawLine(new Pen(Color.Brown, 1.0f), -200, 0, 200, 0);
            g.DrawLine(new Pen(Color.Brown, 1.0f), 0, -200, 0, 200);
            for (x = 5; x <= 20; x+=0.375)
            {
                y = Math.Pow(x, 2) - 18 * x + 72;
                g.DrawEllipse(new Pen(Color.Blue, 2.0f), (int)x * 5, (int)-y, 1, 1);
            }

        }
    }
}