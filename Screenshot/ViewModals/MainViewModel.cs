using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Screenshot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;

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
        private ICommand webForward;
        private ICommand webBack;
        private ICommand takeScreenshot;
        public ICommand GoToWeb => goToWeb ?? (goToWeb = new RelayCommand<string>(GoItemClick));
        public ICommand WebForward => webForward ?? (webForward = new RelayCommand<object>(GoWebForward));
        public ICommand WebBack => webBack ?? (webBack = new RelayCommand<object>(GoWebBack));
        public ICommand TakeScreenshot => takeScreenshot ?? (takeScreenshot = new RelayCommand<object>(GetScreenshot));

        private void GoItemClick(string link)
        {
            WebSite.WebLink = link;
            WebSite.CanScreenshot = true;
        }

        private void GoWebForward(object obj)
        {
            var webView = obj as WebView;
            webView.GoForward();
        }
        private void GoWebBack(object obj)
        {
            var webView = obj as WebView;
            webView.GoBack();
        }

        private void GetScreenshot(object obj)
        {
            var webView = obj as WebView;
        }

    }
}
