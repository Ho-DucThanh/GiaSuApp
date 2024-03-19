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
    /// Interaction logic for ThoiKhoaBieu.xaml
    /// </summary>
    public partial class ThoiKhoaBieu : UserControl
    {
        public ThoiKhoaBieu()
        {
            InitializeComponent();
        }

        private void lblNote_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtNote.Focus();
        }

        private void txtNote_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            textNote.Visibility = string.IsNullOrEmpty(txtNote.Text) ? Visibility.Visible : Visibility.Collapsed;
        }

        private void lblTime_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtTime.Focus();
        }

        private void txtTime_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            textTime.Visibility = string.IsNullOrEmpty(txtTime.Text) ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}
