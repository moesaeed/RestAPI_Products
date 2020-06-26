using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI_Core
{
    public class AppSettings
    {
        public string ApplicationName { get; set; }
        public string ApplicationUrl { get; set; }
        public string JWTSecert { get; set; }
        public string ConnectionString { get; set; }
    }
}
