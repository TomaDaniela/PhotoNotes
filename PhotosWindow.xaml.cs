using Microsoft.Win32;
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

namespace PhotoNotes2
{
    /// <summary>
    /// Interaction logic for PhotosWindow.xaml
    /// </summary>
    public partial class PhotosWindow : Window
    {
        int ok = 0;
        int ok2 = 0;
        int i = 0;

        public PhotosWindow()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {

            if (menuGrid.Visibility == Visibility.Collapsed)
            {
                menuGrid.Visibility = Visibility.Visible;
                albumScrollViewer.SetValue(Grid.ColumnProperty, value: 2);
            }

            else
            {
                menuGrid.Visibility = Visibility.Collapsed;
                albumScrollViewer.SetValue(Grid.ColumnProperty, 0);
                albumScrollViewer.SetValue(Grid.ColumnSpanProperty, 2);

            }

        }

        private void AddPhotoButton_Click(object sender, RoutedEventArgs e)
        {
            Image a = new Image();
            a.Height = 200;
            a.Width = 200;
            Thickness thickness1 = new Thickness(10 + ok, 20 + ok2, 0, 0);
            a.Margin = thickness1;


            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (.jpg;.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (.png)|.png";
            if (op.ShowDialog() == true)
            {

                a.Source = new BitmapImage(new Uri(op.FileName));
                i++;
            }


            albumStackPanel.Children.Add(a);
            ok = ok + 220;
            if (i > 3)
            {
                ok2 = ok2 + 220;
                ok = 0;
                i = 0;
            }

        }
    }
}
