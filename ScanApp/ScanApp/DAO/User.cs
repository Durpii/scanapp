using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScanApp.DAO
{
    public class User
    {
        public string name { get; set; }
        public string rank { get; set; }
        public string opreadydate { get; set; }
        public string datein { get; set; }
        public string timein { get; set; }
        public string timeout { get; set; }
        public string role { get; set; }
        public int accountenabled { get; set; }
    }
}