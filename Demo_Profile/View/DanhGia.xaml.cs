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

namespace Demo_Profile.View
{
    /// <summary>
    /// Interaction logic for DanhGia.xaml
    /// </summary>
    public partial class DanhGia : UserControl
    {
        public DanhGia()
        {
            InitializeComponent();
        }
        private Grid selectedGrid = null;

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void Border_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            if (sender is Border border)
            {
                border.Focus();
            }
        }

        private void Grid_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            if (sender is Grid grid)
            {
                grid.Focus();
            }
        }

        private void Grid_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            if (sender is Grid grid)
            {
                if (selectedGrid != null)
                {
                    selectedGrid.Background = Brushes.White;
                }
                grid.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eba5bb"));
                selectedGrid = grid;
            }
        }


        private void txtRating_TextChanged(object sender, TextChangedEventArgs e)
        {
            textRating.Visibility = string.IsNullOrEmpty(txtRating.Text) ? Visibility.Visible : Visibility.Collapsed;
        }

        private void ratingButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you for your review");
        }
    }
}
