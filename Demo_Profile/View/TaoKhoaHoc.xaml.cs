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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Demo_Profile.View
{
    /// <summary>
    /// Interaction logic for TaoKhoaHoc.xaml
    /// </summary>
    public partial class TaoKhoaHoc : UserControl
    {
        Database.DataProcess dtBase = new Database.DataProcess();
        public static string NameKhoaHoc = "", Cost = "", StarDate = "", NameGiaSu = "", MoTa = "";
        public TaoKhoaHoc()
        {
            InitializeComponent();
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            textName.Visibility = string.IsNullOrEmpty(txtName.Text) ? Visibility.Visible : Visibility.Collapsed;
        }

        private void txtCost_TextChanged(object sender, TextChangedEventArgs e)
        {
            textCost.Visibility = string.IsNullOrEmpty(txtCost.Text) ? Visibility.Visible : Visibility.Collapsed;
        }
        private void txtStartDate_TextChanged(object sender, TextChangedEventArgs e)
        {
            textStartDate.Visibility = string.IsNullOrEmpty(txtStartDate.Text) ? Visibility.Visible : Visibility.Collapsed;
        }

        private void txtEndDate_TextChanged(object sender, TextChangedEventArgs e)
        {
            textNameGiaSu.Visibility = string.IsNullOrEmpty(textNameGiaSu.Text) ? Visibility.Visible : Visibility.Collapsed;
        }
        private void txtDes_TextChanged(object sender, TextChangedEventArgs e)
        {
            textDes.Visibility = string.IsNullOrEmpty(txtDes.Text) ? Visibility.Visible : Visibility.Collapsed;
        }

        private void CreateCourse_Click(object sender, RoutedEventArgs e)
        {
            DataTable dtCourse = new DataTable();
            if (txtName.Text == "" || txtCost.Text == "" || txtStartDate.Text == "" || txtDes.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtName.Focus();
                return;
            }
            dtBase.ChangeData("Insert into tblCourse values('" + txtName.Text + "', '" + txtCost.Text + "', '" + txtStartDate.Text + "', '" + txtNameGiaSu.Text + "', '" + txtDes.Text + "')");
            MessageBox.Show("Tạo khóa học thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            NameKhoaHoc = txtName.Text;
            Cost = txtCost.Text;
            StarDate = txtStartDate.Text;
            NameGiaSu = txtNameGiaSu.Text;
            MoTa = txtDes.Text;


            txtName.Text = "";
            txtCost.Text = "";
            txtStartDate.Text = "";
            txtDes.Text = "";

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            textNameGiaSu.Text = SignIn.Hoten;
            txtNameGiaSu.Text = SignIn.Hoten;
        }
    }
}
