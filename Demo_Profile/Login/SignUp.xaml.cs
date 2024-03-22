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

namespace Demo_Profile.Login
{

    public partial class SignUp : Window
    {
        Database.DataProcess dtBase = new Database.DataProcess();
        public SignUp()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (!cbbGTinh.Items.Contains("Nam"))
                cbbGTinh.Items.Add("Nam");

            if (!cbbGTinh.Items.Contains("Nữ"))
                cbbGTinh.Items.Add("Nữ");


            if (!cbbVTro.Items.Contains("Học viên"))
                cbbVTro.Items.Add("Học viên");

            if (!cbbVTro.Items.Contains("Gia sư"))
                cbbVTro.Items.Add("Gia sư");
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            DataTable dtHV = new DataTable();
            DataTable dtGS = new DataTable();
            if (txtName.Text == "" || txtEmail.Text == "" || txtMatKhau.Text == "" || txtNgaySinh.Text == "" || cbbGTinh.Text == "" || cbbVTro.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtName.Focus();
                return;
            }

            dtHV = dtBase.ReadData("Select * from tblHocVien where Email = '" + txtEmail.Text + "'");
            dtGS = dtBase.ReadData("Select * from tblGiaSu where Email = '" + txtEmail.Text + "'");

            if (dtHV.Rows.Count > 0)
            {
                MessageBox.Show("Email đã tồn tại", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtEmail.Focus();
                return;
            }

            if (dtGS.Rows.Count > 0)
            {
                MessageBox.Show("Email đã tồn tại", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                txtEmail.Focus();
                return;
            }

            string gioiTinh = "";
            if (cbbGTinh.SelectedIndex == 0)
                gioiTinh = "Nam";
            else
                gioiTinh = "Nữ";
            
            string VaiTro = "";
            if (cbbVTro.SelectedIndex == 0)
                VaiTro = "Học viên";
            else
                VaiTro = "Gia sư";

            if (VaiTro == "Học viên")
            {
                dtBase.ChangeData("Insert into tblHocVien values('" + txtName.Text + "', '" + gioiTinh + "', '" + txtNgaySinh.Text + "', '" + txtEmail.Text + "', '" + txtMatKhau.Text + "', '" + VaiTro + "')");
                MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            if (VaiTro == "Gia sư")
            {
                dtBase.ChangeData("Insert into tblGiaSu values('" + txtName.Text + "', '" + gioiTinh + "', '" + txtNgaySinh.Text + "', '" + txtEmail.Text + "', '" + txtMatKhau.Text + "', '" + VaiTro + "')");
                MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            txtName.Text = "";
            txtEmail.Text = "";
            txtMatKhau.Text = "";
            txtNgaySinh.Text = "";
            cbbGTinh.Text = "";
            cbbVTro.Text = "";
        }
    }
}
