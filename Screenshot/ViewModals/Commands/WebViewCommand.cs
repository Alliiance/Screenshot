using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Screenshot.ViewModals.Commands
{
    public class WebViewCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        ViewModalBase HomeBase { get; set; }
        public WebViewCommand(ViewModalBase homeBase)
        {
            HomeBase = homeBase;
        }
        
        public bool CanExecute(object parameter)
        {
            if (parameter != null && parameter is String)
                return true;
            return false;
        }

        public void Execute(object parameter)
        {
            string link = parameter as String;
            HomeBase.GetNameLink(link);
        }
    }
}
