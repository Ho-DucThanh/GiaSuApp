using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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
using Demo_Profile;
using Demo_Profile.ViewModel;
using Demo_Profile.Run;
using Demo_Profile.Utilities;

namespace Demo_Profile.Login
{
    public partial class SignIn : Window
    {
        public ViewModelBase ViewModel { get; set; }
        public static string id = "", mk = "", Hoten;
        Database.DataProcess dtBase = new Database.DataProcess();
        public SignIn()
        {
            InitializeComponent();
            ViewModel = new ViewModelBase();
            DataContext = ViewModel;
        }
        private void textUser_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtUser.Focus();
        }

        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUser.Text) && txtUser.Text.Length > 0)
            {
                textUser.Visibility = Visibility.Collapsed;
            }
            else
            {
                textUser.Visibility = Visibility.Visible;
            }
        }

        private void textPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtPassword.Focus();
        }

        private void txtPassword_TextChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Password) && txtPassword.Password.Length > 0)
            {
                textPassword.Visibility = Visibility.Collapsed;
            }
            else
            {
                textPassword.Visibility = Visibility.Visible;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            string sql = "";

            if (cbbVaiTro.Text == "Gia Sư")
            {
                
                if (txtUser.Text.Trim() == "" || txtPassword.Password == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                sql = "Select * from tblGiaSu where Email = '" + txtUser.Text + "' and MatKhau ='" + txtPassword.Password + "'";
                DataTable dtTaiKhoan = dtBase.ReadData(sql);
                if (dtTaiKhoan.Rows.Count == 0)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                ViewModel.HoTen = dtTaiKhoan.Rows[0]["HoTen"].ToString();
                
                id = txtUser.Text;
                mk = txtPassword.Password;
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

                GiaSu giasu = new GiaSu();
                this.Hide();
                giasu.ShowDialog();
            }

            if (cbbVaiTro.Text == "Admin")
            {

                if (txtUser.Text.Trim() == "" || txtPassword.Password == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                sql = "Select * from tblAdmin where TenDN = '" + txtUser.Text + "' and MatKhau ='" + txtPassword.Password + "'";
                DataTable dtTaiKhoan = dtBase.ReadData(sql);
                if (dtTaiKhoan.Rows.Count == 0)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                ViewModel.HoTen = dtTaiKhoan.Rows[0]["HoTen"].ToString();
                id = txtUser.Text;
                mk = txtPassword.Password;
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

                MainWindow main = new MainWindow();
                this.Hide();
                main.ShowDialog();
            }

            if (cbbVaiTro.Text == "Học Viên")
            {

                if (txtUser.Text.Trim() == "" || txtPassword.Password == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                sql = "Select * from tblHocVien where Email = '" + txtUser.Text + "' and MatKhau ='" + txtPassword.Password + "'";
                DataTable dtTaiKhoan = dtBase.ReadData(sql);
                if (dtTaiKhoan.Rows.Count == 0)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                ViewModel.HoTen = dtTaiKhoan.Rows[0]["HoTen"].ToString();
                id = txtUser.Text;
                mk = txtPassword.Password;
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

                HocVien hocvien = new HocVien();
                this.Hide();
                hocvien.ShowDialog();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SignUp signup = new SignUp();
            signup.ShowDialog();
            this.Close();
        }
    }
}
