﻿using System;
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
using ControllerNamespace;

namespace PhotoNotes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int ok = 0;
        int ok2 = 0;
        int i = 0;

        List<Button> albumList = new List<Button>();

        public MainWindow()
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

        private void AddAlbumButton_Click(object sender, RoutedEventArgs e)
        {
            //Controller controller = new Controller();


            Image img = new Image();
            Button alb = new Button();
            alb.Width = 100;
            alb.Height = 100;
            alb.Margin = new Thickness(20 + ok, 20 + ok2, 0, 0);

            var uri = new Uri(uriString: @"E:\FACULTATE\An III\TP\PhotoNotes2\album3.png");
            img.Source = new BitmapImage(uri);

            alb.Content = img;
            albumList.Add(alb);


            albumCanvas.Children.Add(albumList.ElementAt(albumList.Count-1));
            alb.Click += new RoutedEventHandler(alb_Click);

            ok = ok + 150;
            i++;
            double max = albumCanvas.ActualWidth / (alb.Width + i * 10);

            if (i > max)
            {
                ok2 = ok2 + 120;
                ok = 0;
                i = 0;
            }


        }

        private void alb_Click(object sender, RoutedEventArgs e)
        {
            PhotosWindow window = new PhotosWindow();
            window.Show();
            this.Close();
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            menuGrid.Visibility = Visibility.Collapsed;
            albumScrollViewer.SetValue(Grid.ColumnProperty, 0);
            albumScrollViewer.SetValue(Grid.ColumnSpanProperty, 2);
        }
    }
}

