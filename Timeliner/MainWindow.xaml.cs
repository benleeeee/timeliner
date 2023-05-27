using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Timeliner.MediaTypes;

namespace Timeliner
{
    //public struct Line
    //{
    //    public float x1;
    //    public float x2;
    //    public SolidColorBrush colour;
    //    public float strokeThickness;
    //}

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Media> mediaList = new List<Media>();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;

            FakeInput();
        }


        /// <summary>
        /// Fake list of media for now
        /// TODO: Read from a file the media information
        /// </summary>
        public void FakeInput()
        {
            //graphGridContainer.DataContext = mediaList;

            //Construct some media and add to list
            Media GotG3 = new Movie();
            GotG3.startDateTime = new DateTime(2023, 5, 25);
            GotG3.finishDateTime = new DateTime(2023, 5, 25);
            GotG3.name = "GotG3";

            Media Zom100_V1 = new Manga();
            Zom100_V1.startDateTime = new DateTime(2023, 5, 25);
            Zom100_V1.finishDateTime = new DateTime(2023, 5, 26);
            Zom100_V1.name = "Zom100_V1";

            mediaList.Add(GotG3);
            mediaList.Add(Zom100_V1);


            

            Line line = new Line { X1 = 0, X2 = 100, Y1 = 0, Y2 = 100, Stroke = Brushes.Black, StrokeThickness = 2 };

            //graphGrid.Children.Add(line);
        }

        private void AddToFakeList(object sender, RoutedEventArgs e)
        {
            Media Zom100_V1 = new Manga();
            Zom100_V1.startDateTime = new DateTime(2023, 5, 25);
            Zom100_V1.finishDateTime = new DateTime(2023, 5, 26);

            mediaList.Add(Zom100_V1);
        }
    }
}
