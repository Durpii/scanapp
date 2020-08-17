using ScanApp.Controller;
using ScanApp.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ScanApp
{
    public partial class RedirectPageError : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string error = Session["ErrorName"].ToString();

            Session.Remove("ErrorName");

            Label2.Text = error;
        }
    }
}