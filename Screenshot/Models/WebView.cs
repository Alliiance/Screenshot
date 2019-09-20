using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screenshot.Models
{
    class WebView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string webLink;

        public string WebLink
        {
            get { return webLink; }
            set {
                webLink = value;
                OnPropertyChanged("WebLink");
            }
        }

        private void OnPropertyChanged(string link)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(link));
        }

    }
}
