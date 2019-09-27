using Screenshot.Models;
using Screenshot.ViewModals.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screenshot.ViewModals
{
    public class ViewModalBase
    {
        public WebViewCommand WebViewCommand { get; set; }

        public ViewModalBase()
        {
            WebViewCommand = new WebViewCommand(this);
        }

        public void GetNameLink(string link)
        {
            WebModel s = new WebModel();
            s.WebLink = link;
        }
    }
}
