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
    /// Interaction logic for TrangChu.xaml
    /// </summary>
    public partial class ListGiaSu : UserControl
    {
        Database.DataProcess dtBase = new Database.DataProcess();
        public ListGiaSu()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            DataTable dtGiaSu = new DataTable();

            dtGiaSu = dtBase.ReadData("Select * from tblGiaSu");

            /* Gán dữ liệu lên dataGrid */
            GiaSuDataGrid.ItemsSource = dtGiaSu.AsDataView();
        }

        private void txtFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            string sql = "";
            if (txtFilter.Text.Trim() == "")
            {
                sql = "Select * from tblGiaSu";
            }
            else
            {
                sql = "Select * from tblGiaSu where HoTen like '%" + txtFilter.Text + "%'";
            }

        }

        private void BtnTimKiem_Click(object sender, RoutedEventArgs e)
        {
            string sql = "";
            if (txtFilter.Text.Trim() == "")
                sql = "Select * from tblGiaSu";
            else
            {
                sql = "Select * from tblGiaSu where HoTen is not null";
                if (txtFilter.Text.Trim() != "")
                    sql = sql + " and HoTen like '%" + txtFilter.Text + "%'";
               
            }
            DataTable dtTimKiem = dtBase.ReadData(sql);
            GiaSuDataGrid.ItemsSource = dtTimKiem.AsDataView();
        }

        private void Delete(string id)
        {
            string strDelete = "DELETE FROM tblGiaSu WHERE Email = ('" + id + "')";
            dtBase.ChangeData(strDelete);
            LoadData();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow = GiaSuDataGrid.SelectedItem as DataRowView;
            if (selectedRow != null)
            {
                string selectedID = selectedRow["Email"].ToString();
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu có Email là " + selectedID + "?", "Xác nhận xóa", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    Delete(selectedID);
                }
            }
        }
    }
}
