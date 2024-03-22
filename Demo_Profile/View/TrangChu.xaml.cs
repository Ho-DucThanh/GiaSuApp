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
    /// Interaction logic for Messages.xaml
    /// </summary>
    public partial class TrangChu : UserControl
    {
        Database.DataProcess dtBase = new Database.DataProcess();
        public TrangChu()
        {
            InitializeComponent();
        }

        private void XemKhoaHoc_Click(object sender, RoutedEventArgs e)
        {
            DangKiKhoaHoc dki = new DangKiKhoaHoc();
            dki.ShowDialog();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            txtGiaSuName.Text = TaoKhoaHoc.NameGiaSu;
            txtNameKhoaHoc.Text = TaoKhoaHoc.NameKhoaHoc;
            txtMoTa.Text = TaoKhoaHoc.MoTa;
        }
    }
}
