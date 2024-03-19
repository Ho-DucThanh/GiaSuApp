using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Demo_Profile.Utilities;


namespace Demo_Profile.ViewModel
{
    public class NavigationVM : Utilities.ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public ICommand ListGiaSuCommand { get; set; }
        public ICommand ListHocVienCommand { get; set; }
        public ICommand ThongKeCommand { get; set; }
        public ICommand MessagesCommand { get; set; }
        public ICommand SettingsCommand { get; set; }


        private void ListGiaSu(object obj) => CurrentView = new ListGiaSuVM();
        private void ListHocVien(object obj) => CurrentView = new ListHocVienVM();
        private void ThongKe(object obj) => CurrentView = new ThongKeVM();
        private void Messages(object obj) => CurrentView = new MessagesVM();
        private void Settings(object obj) => CurrentView = new SettingsVM();
        

        public NavigationVM()
        {
            ListGiaSuCommand = new RelayCommand(ListGiaSu);
            ListHocVienCommand = new RelayCommand(ListHocVien);
            ThongKeCommand = new RelayCommand(ThongKe);            
            MessagesCommand = new RelayCommand(Messages);
            SettingsCommand = new RelayCommand(Settings);
            

            CurrentView = new ListGiaSuVM();
        }
    }
}
