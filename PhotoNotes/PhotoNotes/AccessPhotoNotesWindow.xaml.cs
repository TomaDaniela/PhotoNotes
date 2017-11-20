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
using System.Windows.Shapes;

namespace PhotoNotes
{
    /// <summary>
    /// Interaction logic for AccessPhotoNotesWindow.xaml
    /// </summary>
    public partial class AccessPhotoNotesWindow : Window
    {
        int ok = 0;
        int ok2 = 0;
        int i = 0;
     

        public AccessPhotoNotesWindow()
        {
            InitializeComponent();


        }
        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {

            if (menuGrid.Visibility == Visibility.Collapsed)
            {
                menuGrid.Visibility = Visibility.Visible;
                MainGrid.SetValue(Grid.ColumnProperty, value: 2);
            }

            else
            {
                menuGrid.Visibility = Visibility.Collapsed;
                MainGrid.SetValue(Grid.ColumnProperty, 0);
                MainGrid.SetValue(Grid.ColumnSpanProperty, 2);

            }

        }

        private void AddAlbumButton_Click(object sender, RoutedEventArgs e)
        {

            Image img = new Image();
            img.Width = 100;
            img.Height = 100;
            img.Margin = new Thickness(10 + ok, 10 + ok2, 0, 0);


            var uri = new Uri(uriString: @"D:\ProiectTP\PhotoNotesPilot\PhotoNotesPilot\Pictures\album3.png");
            img.Source = new BitmapImage(uri);



            //albumStackPanel.Children.Add(img);

            //ok = ok + 150;
            //i++;
            //double max = albumStackPanel.ActualWidth / (img.Width + i * 10);
            //if (i > max)
            //{
            //    ok2 = ok2 + 120;
            //    ok = 0;
            //    i = 0;
            //}


        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
        private void AspectRatioCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (myImage.Stretch == Stretch.Fill)
            {
                myImage.Stretch = Stretch.Uniform;

            }
            else if (myImage.Stretch == Stretch.Uniform)
            {
                myImage.Stretch = Stretch.Fill;
            }
        }
    }

}
