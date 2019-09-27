using System.ComponentModel;

namespace Screenshot.Models
{
    public class WebModel : INotifyPropertyChanged
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
