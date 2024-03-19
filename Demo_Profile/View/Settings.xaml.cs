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
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            textName.Visibility = string.IsNullOrEmpty(txtName.Text) ? Visibility.Visible : Visibility.Collapsed;
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            textEmail.Visibility = string.IsNullOrEmpty(txtEmail.Text) ? Visibility.Visible : Visibility.Collapsed;
        }

        private void txtPhone_TextChanged(object sender, TextChangedEventArgs e)
        {
            textPhone.Visibility = string.IsNullOrEmpty(txtPassWord.Text) ? Visibility.Visible : Visibility.Collapsed;
        }

        private void txtCountry_TextChanged(object sender, TextChangedEventArgs e)
        {
            textCountry.Visibility = string.IsNullOrEmpty(txtGioiTinh.Text) ? Visibility.Visible : Visibility.Collapsed;
        }

        private void txtCity_TextChanged(object sender, TextChangedEventArgs e)
        {
            textCity.Visibility = string.IsNullOrEmpty(txtVaiTro.Text) ? Visibility.Visible : Visibility.Collapsed;
        }

        
    }
}
