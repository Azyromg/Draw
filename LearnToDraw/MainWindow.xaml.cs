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

namespace LearnToDraw
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var rand = new Random();
            int width = rand.Next(0, 500);
            int height = rand.Next(0, 500);
            byte red = (byte)rand.Next(0, 256);
            byte green = (byte)rand.Next(0, 256);
            byte blue = (byte)rand.Next(0, 256);
            var rectangle = new Rectangle
            {
                Width = width,
                Height = height,
                Fill = new SolidColorBrush(Color.FromRgb(red, green, blue))
            };

            double canvasWidth = canvas.ActualWidth;
            double canvasHeight = canvas.ActualHeight;
            double x = rand.NextDouble() * (canvasWidth - rectangle.Width);
            double y = rand.NextDouble() * (canvasHeight - rectangle.Height);

            Canvas.SetLeft(rectangle, x);
            Canvas.SetTop(rectangle, y);

            canvas.Children.Add(rectangle);

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var rand = new Random();
            int width = rand.Next(0, 500);
            int height = rand.Next(0, 500);
            byte red  = (byte)rand.Next(0, 256);
            byte green = (byte)rand.Next(0, 256);
            byte blue = (byte)rand.Next(0, 256);
            var circle = new Ellipse
            {
                Width = width,
                Height = height,
                Fill = new SolidColorBrush(Color.FromRgb(red, green, blue))
            };

            double canvasWidth = canvas.ActualWidth;
            double canvasHeight = canvas.ActualHeight;
            double x = rand.NextDouble() * (canvasWidth - circle.Width);
            double y = rand.NextDouble() * (canvasHeight - circle.Height);

            Canvas.SetLeft(circle, x);
            Canvas.SetTop(circle, y);

            canvas.Children.Add(circle);

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            var rand = new Random();
            int width1 = 422;
            int height1 = 309;
            int width2 = 40;
            int height2 = 100;
            int width3 = 108;
            int height3 = 285;
            byte red = (byte)rand.Next(0, 256);
            byte green = (byte)rand.Next(0, 256);
            byte blue = (byte)rand.Next(0, 256);
            var circle = new Ellipse
            {
                Width = width1,
                Height = height1,
                Fill = new SolidColorBrush(Color.FromRgb(red, green, blue))
            };
            var circle2 = new Ellipse
            {
                Width = width3,
                Height = height3,
                Fill = new SolidColorBrush(Color.FromRgb(red, green, blue))
            };
            var rectangle1 = new Rectangle
            {
                Width = width2,
                Height = height2,
                Fill = new SolidColorBrush(Color.FromRgb(red, green, blue))
            };
            var rectangle2 = new Rectangle
            {
                Width = width2,
                Height = height2,
                Fill = new SolidColorBrush(Color.FromRgb(red, green, blue))
            };
            var rectangle3 = new Rectangle
            {
                Width = width2,
                Height = height2,
                Fill = new SolidColorBrush(Color.FromRgb(red, green, blue))
            };
            var rectangle4 = new Rectangle
            {
                Width = width2,
                Height = height2,
                Fill = new SolidColorBrush(Color.FromRgb(red, green, blue))
            };

            double canvasWidth = canvas.ActualWidth;
            double canvasHeight = canvas.ActualHeight;
            double x1 = 211;
            double y1 = 70;

            Canvas.SetLeft(circle, x1);
            Canvas.SetTop(circle, y1);

            double x2 = 200;
            double y2 = 20;

            Canvas.SetLeft(circle2, x2);
            Canvas.SetTop(circle2, y2);

            double x3 = 260;
            double y3 = 300;

            Canvas.SetLeft(rectangle1, x3);
            Canvas.SetTop(rectangle1, y3);

            double x4 = 450;
            double y4 = 300;

            Canvas.SetLeft(rectangle2, x4);
            Canvas.SetTop(rectangle2, y4);

            double x5 = 500;
            double y5 = 300;

            Canvas.SetLeft(rectangle3, x5);
            Canvas.SetTop(rectangle3, y5);

            double x6 = 320;
            double y6 = 300;

            Canvas.SetLeft(rectangle4, x6);
            Canvas.SetTop(rectangle4, y6);

            canvas.Children.Add(circle);
            canvas.Children.Add(circle2);
            canvas.Children.Add(rectangle1);
            canvas.Children.Add(rectangle2);
            canvas.Children.Add(rectangle3);
            canvas.Children.Add(rectangle4);
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            var rand = new Random();    
            
            byte red = (byte)rand.Next(0, 256);
            byte green = (byte)rand.Next(0, 256);
            byte blue = (byte)rand.Next(0, 256);
            var line = new Line()
            {
                X1 = 0,
                Y1 = 0,
                X2 = 100,
                Y2 = 100,
                Stroke = new SolidColorBrush(Color.FromRgb (red, green, blue)),
                StrokeThickness = 3,
            };
            
            
            canvas.Children.Add(line);
        }

        private async void button6_Click(object sender, RoutedEventArgs e)
        {
            var rand = new Random();
            
            for(int i = 100; i < 500; i++)
            {
                byte red = (byte)rand.Next(0, 256);
                byte green = (byte)rand.Next(0, 256);
                byte blue = (byte)rand.Next(0, 256);
                var line = new Line()
                {

                    X1 = i,
                    Y1 = 100,
                    X2 = i,
                    Y2 = 200,
                    Stroke = new SolidColorBrush(Color.FromRgb(red, green, blue)),
                    StrokeThickness = 3,
                };


                canvas.Children.Add(line);
                await Task.Delay(100);
            }
            
        }

        private async void button7_Click(object sender, RoutedEventArgs e)
        {
            var rand = new Random();

            
            
                byte red = (byte)rand.Next(0, 256);
                byte green = (byte)rand.Next(0, 256);
                byte blue = (byte)rand.Next(0, 256);
                var line = new Line()
                {

                    X1 = 280,
                    Y1 = 300,
                    X2 = 350,
                    Y2 = 150,
                    Stroke = new SolidColorBrush(Color.FromRgb(red, green, blue)),
                    StrokeThickness = 3,
                };
            var line1 = new Line()
            {

                X1 = 350,
                Y1 = 150,
                X2 = 480,
                Y2 = 300,
                Stroke = new SolidColorBrush(Color.FromRgb(red, green, blue)),
                StrokeThickness = 3,
            };
            var line2 = new Line()
            {

                X1 = 480,
                Y1 = 300,
                X2 = 250,
                Y2 = 200,
                Stroke = new SolidColorBrush(Color.FromRgb(red, green, blue)),
                StrokeThickness = 3,
            };
            var line3 = new Line()
            {

                X1 = 250,
                Y1 = 200,
                X2 = 480,
                Y2 = 200,
                Stroke = new SolidColorBrush(Color.FromRgb(red, green, blue)),
                StrokeThickness = 3,
            };
            var line4 = new Line()
            {

                X1 = 480,
                Y1 = 200,
                X2 = 280,
                Y2 = 300,
                Stroke = new SolidColorBrush(Color.FromRgb(red, green, blue)),
                StrokeThickness = 3,
            };

            canvas.Children.Add(line);
            canvas.Children.Add(line1);
            canvas.Children.Add(line2);
            canvas.Children.Add(line3);
            canvas.Children.Add(line4);

            
            
                for(int j = 150; j < 200; j++)
                {
                    byte red1 = (byte)rand.Next(0, 256);
                    byte green1 = (byte)rand.Next(0, 256);
                    byte blue1 = (byte)rand.Next(0, 256);
                    var line5 = new Line()
                    {

                        X1 = 330,
                        Y1 = 200,
                        X2 = 350,
                        Y2 = j,
                        Stroke = new SolidColorBrush(Color.FromRgb(red1, green1, blue1)),
                        StrokeThickness = 3,
                    };


                    canvas.Children.Add(line5);
                    await Task.Delay(1);
                }
            
            
                for (int j = 150; j < 200; j++)
                {
                    byte red1 = (byte)rand.Next(0, 256);
                    byte green1 = (byte)rand.Next(0, 256);
                    byte blue1 = (byte)rand.Next(0, 256);
                    var line6 = new Line()
                    {

                        X1 = 400,
                        Y1 = 200,
                        X2 = 350,
                        Y2 = j,
                        Stroke = new SolidColorBrush(Color.FromRgb(red1, green1, blue1)),
                        StrokeThickness = 3,
                    };


                    canvas.Children.Add(line6);
                    await Task.Delay(1);
                }
            for (int j = 200; j < 265; j++)
            {
                byte red1 = (byte)rand.Next(0, 256);
                byte green1 = (byte)rand.Next(0, 256);
                byte blue1 = (byte)rand.Next(0, 256);
                var line7 = new Line()
                {

                    X1 = 250,
                    Y1 = 200,
                    X2 = 400,
                    Y2 = j,
                    Stroke = new SolidColorBrush(Color.FromRgb(red1, green1, blue1)),
                    StrokeThickness = 3,
                };


                canvas.Children.Add(line7);
                await Task.Delay(1);
            }
            for (int j = 200; j < 265; j++)
            {
                byte red1 = (byte)rand.Next(0, 256);
                byte green1 = (byte)rand.Next(0, 256);
                byte blue1 = (byte)rand.Next(0, 256);
                var line8 = new Line()
                {

                    X1 = 480,
                    Y1 = 300,
                    X2 = 400,
                    Y2 = j,
                    Stroke = new SolidColorBrush(Color.FromRgb(red1, green1, blue1)),
                    StrokeThickness = 3,
                };


                canvas.Children.Add(line8);
                await Task.Delay(1);
            }
            for (int j = 200; j < 277; j++)
            {
                byte red1 = (byte)rand.Next(0, 256);
                byte green1 = (byte)rand.Next(0, 256);
                byte blue1 = (byte)rand.Next(0, 256);
                var line9 = new Line()
                {

                    X1 = 480,
                    Y1 = 200,
                    X2 = 330,
                    Y2 = j,
                    Stroke = new SolidColorBrush(Color.FromRgb(red1, green1, blue1)),
                    StrokeThickness = 3,
                };


                canvas.Children.Add(line9);
                await Task.Delay(1);
            }
            for (int j = 200; j < 277; j++)
            {
                byte red1 = (byte)rand.Next(0, 256);
                byte green1 = (byte)rand.Next(0, 256);
                byte blue1 = (byte)rand.Next(0, 256);
                var line10 = new Line()
                {

                    X1 = 280,
                    Y1 = 300,
                    X2 = 330,
                    Y2 = j,
                    Stroke = new SolidColorBrush(Color.FromRgb(red1, green1, blue1)),
                    StrokeThickness = 3,
                };


                canvas.Children.Add(line10);
                await Task.Delay(1);
            }




        }
    }
}
