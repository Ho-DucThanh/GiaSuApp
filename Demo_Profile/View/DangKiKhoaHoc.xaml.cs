using Demo_Profile.Login;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Xml.Linq;

namespace Demo_Profile.View
{
    /// <summary>
    /// Interaction logic for DangKiKhoaHoc.xaml
    /// </summary>
    public partial class DangKiKhoaHoc : Window
    {
        Database.DataProcess dtBase = new Database.DataProcess();
        public DangKiKhoaHoc()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtCost.Text = TaoKhoaHoc.Cost;
            txtStartDate.Text = "+ Ngày bắt đầu: " +  TaoKhoaHoc.StarDate;
        }

        private void Dangki_Click(object sender, RoutedEventArgs e)
        {
            DataTable dtDKi = new DataTable();
            dtBase.ChangeData("Insert into tblDangKi values('" + SignIn.Hoten + "', '" + TaoKhoaHoc.NameKhoaHoc + "', '" + TaoKhoaHoc.Cost + "', '" + TaoKhoaHoc.NameGiaSu + "', '" + TaoKhoaHoc.StarDate + "')");
            MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
