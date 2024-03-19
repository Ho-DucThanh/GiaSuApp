using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_Profile.Utilities;
using System.Windows.Input;
using Demo_Profile.View;

namespace Demo_Profile.ViewModel
{
    public class HocVienNavigationVM : Utilities.ViewModelBase
    {
        private object _currentView;
        public object HVCurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public ICommand TrangChuCommand { get; set; }

        public ICommand KhoaHocCommand { get; set; }
        public ICommand ThoiKhoaBieuCommand { get; set; }

        public ICommand MessagesCommand { get; set; }
        public ICommand SettingsCommand { get; set; }



        private void TrangChu(object obj) => HVCurrentView = new TrangChuVM();
        private void KhoaHoc(object obj) => HVCurrentView = new KhoaHocVM();
        private void ThoiKhoaBieu(object obj) => HVCurrentView = new ThoiKhoaBieuVM();
        private void Messages(object obj) => HVCurrentView = new MessagesVM();
        private void Settings(object obj) => HVCurrentView = new SettingsVM();


        public HocVienNavigationVM()
        {
            TrangChuCommand = new RelayCommand(TrangChu);
            KhoaHocCommand = new RelayCommand(KhoaHoc);
            ThoiKhoaBieuCommand = new RelayCommand(ThoiKhoaBieu);
            MessagesCommand = new RelayCommand(Messages);
            SettingsCommand = new RelayCommand(Settings);

            HVCurrentView = new TrangChuVM();
        }
       
    }
}
