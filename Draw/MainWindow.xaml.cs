using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Draw
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool IsDrawing = false;
        private PathFigure pathFigure;
        private Brush brush;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Mouse.Capture(DrawingTarget);
            IsDrawing = true;
            StartFigure(e.GetPosition(DrawingTarget));
        }

        private void StartFigure(Point point)
        {
            pathFigure = new PathFigure() { 
                StartPoint = point
            };
            var path = new Path() {
                Stroke = brush,
                StrokeThickness = 2,
                Data = new PathGeometry() {
                    Figures = { pathFigure }
                }
            };
            DrawingTarget.Children.Add(path);
        }

        private void DrawingTarget_MouseMove(object sender, MouseEventArgs e)
        {
            if(IsDrawing)
            {
                AddFigurePoint(e.GetPosition(DrawingTarget));
            }
        }

        private void AddFigurePoint(Point point)
        {
            pathFigure.Segments.Add(new LineSegment(point,true));
        }

        private void DrawingTarget_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void DrawingTarget_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            AddFigurePoint(e.GetPosition(DrawingTarget));
            EndFigure();
            IsDrawing = false;
            Mouse.Capture(null);
        }

        private void EndFigure()
        {
            pathFigure = null;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            brush = Brushes.Black;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            brush = Brushes.Blue;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            brush = Brushes.Red;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            brush = Brushes.Green;
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            brush = Brushes.White;
        }
    }
}
