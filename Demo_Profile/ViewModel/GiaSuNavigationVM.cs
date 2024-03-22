using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_Profile.Utilities;
using System.Windows.Input;

namespace Demo_Profile.ViewModel
{
    public class GiaSuNavigationVM : Utilities.ViewModelBase
    {
        private object _currentView;
        public object GSCurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public ICommand ChapNhanDkiCommand { get; set; }

        public ICommand CreateKhoaHocCommand { get; set; }
        public ICommand ThoiKhoaBieuCommand { get; set; }

        public ICommand MessagesCommand { get; set; }
        public ICommand SettingsCommand { get; set; }



        private void CreateKhoaHoc(object obj) => GSCurrentView = new CreateKhoaHocVM();
        private void ChapNhan(object obj) => GSCurrentView = new ChapNhanKhoaHocVM();
        private void ThoiKhoaBieu(object obj) => GSCurrentView = new ThoiKhoaBieuVM();
        private void Messages(object obj) => GSCurrentView = new MessagesVM();
        private void Settings(object obj) => GSCurrentView = new SettingsVM();


        public GiaSuNavigationVM()
        {
            CreateKhoaHocCommand = new RelayCommand(CreateKhoaHoc);
            ChapNhanDkiCommand = new RelayCommand(ChapNhan);
            ThoiKhoaBieuCommand = new RelayCommand(ThoiKhoaBieu);
            MessagesCommand = new RelayCommand(Messages);
            SettingsCommand = new RelayCommand(Settings);

            GSCurrentView = new CreateKhoaHocVM();
        }
    }
}
