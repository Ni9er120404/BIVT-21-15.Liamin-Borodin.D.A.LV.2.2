using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace LaboratoryWork.OOP._2._2
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			Loaded += MainWindow_Loaded;
		}

		private void MainWindow_Loaded(object sender, RoutedEventArgs e)
		{
			DrawShapes();
		}

		private void DrawShapes()
		{
			double centerX = this.Width / 2;
			double centerY = this.Height / 2;
			Canvas canvas = new Canvas();

			// Draw X and Y axes
			Line xAxis = new Line
			{
				X1 = 0,
				Y1 = centerY,
				X2 = this.Width,
				Y2 = centerY,
				Stroke = Brushes.Brown,
				StrokeThickness = 1.0
			};
			_ = canvas.Children.Add(xAxis);

			Line yAxis = new Line
			{
				X1 = centerX,
				Y1 = 0,
				X2 = centerX,
				Y2 = this.Height,
				Stroke = Brushes.Brown,
				StrokeThickness = 1.0
			};
			_ = canvas.Children.Add(yAxis);

			// Draw ellipse and points
			for (double x = 5; x <= 20; x += 0.375)
			{
				double y = Math.Pow(x, 2) - (18 * x) + 72;
				Ellipse point = new Ellipse
				{
					Width = 1,
					Height = 1,
					Fill = Brushes.Blue
				};
				Canvas.SetLeft(point, centerX + (x * 5));
				Canvas.SetTop(point, centerY - y);
				_ = canvas.Children.Add(point);
			}

			// Add canvas to the main window
			this.Content = canvas;
		}
	}
}