using Screenshot.Healpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Screenshot.Models
{
    public class WebSite : Observable
    {
        private string webLink;
        private bool canScreenshot;

        public string WebLink
        {
            get { return webLink; }
            set
            {
                Set(ref webLink, value);
            }
        }

        public bool CanScreenshot
        {
            get { return canScreenshot; }
            set
            {
                Set(ref canScreenshot, value);
            }
        }

    }
}
