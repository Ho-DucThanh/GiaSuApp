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
    /// Interaction logic for ViewAdmin.xaml
    /// </summary>
    public partial class ListHocVien : UserControl
    {
        Database.DataProcess dtBase = new Database.DataProcess();
        public ListHocVien()
        {
            InitializeComponent();
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            DataTable dtHocVien = new DataTable();

            dtHocVien = dtBase.ReadData("Select * from tblHocVien");

            /* Gán dữ liệu lên dataGrid */
            HocVienDataGrid.ItemsSource = dtHocVien.AsDataView();
        }

        private void Delete(string id)
        {
            string strDelete = "DELETE FROM tblHocVien WHERE Email = ('" + id + "')";
            dtBase.ChangeData(strDelete);
            LoadData();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow = HocVienDataGrid.SelectedItem as DataRowView;
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
