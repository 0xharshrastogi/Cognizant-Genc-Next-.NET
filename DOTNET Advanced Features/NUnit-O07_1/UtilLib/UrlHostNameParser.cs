using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilLib
{
    public class UrlHostNameParser
    {
        public string ParseHostName(string url)
        {
            string protocol = url.Split(':')[0];

            if (protocol.Equals("http") || protocol.Equals("https"))
            {
                string hostName = url.Split(':')[1].Substring(2).Split('/')[0];

                return hostName;

            }
            else
            {
                throw new FormatException("Url is not in correct format");
            }
        }
    }
}
