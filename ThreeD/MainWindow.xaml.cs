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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HelixToolkit.Wpf;

namespace ThreeD
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainSmirnov();
        }
        //qwert
        Random rnd;
        public BoxVisual3D rectangle;
        ArrowVisual3D strelka1;
        ArrowVisual3D strelka2;
        ArrowVisual3D strelka3;
        ArrowVisual3D strelka4;

        Color color;
          
        public void MainSmirnov()
        {
            rnd = new Random();
            System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();

            timer.Tick += new EventHandler(TimerTick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();

            rectangle = new BoxVisual3D
            {
                Height = 3,
                Width = 3,
                Length = 6,
                Center = new Point3D(0,0,0),
            };
            MyHelix.Children.Add(rectangle);

            strelka1 = new ArrowVisual3D
            {
                HeadLength = 2,
                Diameter = 1,
                Point1 = new Point3D(0, 0, 0),
                Point2 = new Point3D(0, 0, 4),
            };
            MyHelix.Children.Add(strelka1);

            strelka4 = new ArrowVisual3D
            {
                HeadLength = 2,
                Diameter = 1,
                Point1 = new Point3D(0, 0, 0),
                Point2 = new Point3D(0, 0, -4),
            };
            MyHelix.Children.Add(strelka4);

            strelka2 = new ArrowVisual3D
            {
                HeadLength = 2,
                Diameter = 1,
                Point1 = new Point3D(0, 0, 0),
                Point2 = new Point3D(0, -4, 0),
            };
            MyHelix.Children.Add(strelka2);

            strelka3 = new ArrowVisual3D
            {
                HeadLength = 2,
                Diameter = 1,
                Point1 = new Point3D(0, 0, 0),
                Point2 = new Point3D(0, 4, 0),
            };
            MyHelix.Children.Add(strelka3);

            void TimerTick(object sender, EventArgs e)
            {
                color = Color.FromRgb(0, (byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255)); ;
                rectangle.Fill = new SolidColorBrush(color);
                strelka1.Fill = new SolidColorBrush(color);
                strelka2.Fill = new SolidColorBrush(color);
                strelka3.Fill = new SolidColorBrush(color);
                strelka4.Fill = new SolidColorBrush(color);
            }
        }
    }
}
