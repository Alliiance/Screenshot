using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Screenshot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Screenshot.ViewModals
{
    public class MainViewModel : ViewModelBase
    {
        public WebSite WebSite { get; set; }

        public MainViewModel()
        {
            WebSite = new WebSite();
        }

        private ICommand goToWeb;
        public ICommand GoToWeb => goToWeb ?? (goToWeb = new RelayCommand<string>(GoItemClick));

        private void GoItemClick(string link)
        {
            WebSite.WebLink = link;
        }

        private ICommand goNext;

        public ICommand GoNext => goNext ?? (goNext = new RelayCommand<object>(GoNextPage));

        private void GoNextPage(object obj)
        {

        }


    }
}
