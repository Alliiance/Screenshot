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

        public string WebLink
        {
            get { return webLink; }
            set
            {
                Set(ref webLink, value);
            }
        }

    }
}
