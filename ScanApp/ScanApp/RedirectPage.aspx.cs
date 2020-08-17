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
    public partial class RedirectPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = "";
            string rank = "";
            string datein = "";
            string timein = "";

            try
            {
                name = Session["userName"].ToString();
                rank = Session["userRank"].ToString();
                datein = Session["userDateIn"].ToString();
                timein = Session["userTimeIn"].ToString();
            } catch (Exception ex)
            {
                Server.Transfer("RedirectPageError.aspx");
                Session["ErrorName"] = ex.Message;
            }

            lbl_Response.Text = "Welcome " + rank + " " + name + ". Date In: " + datein + " Time In: " + timein;

            Session.Remove("userName");
            Session.Remove("userRank");
            Session.Remove("userDateIn");
            Session.Remove("userTimeIn");
        }
    }
}