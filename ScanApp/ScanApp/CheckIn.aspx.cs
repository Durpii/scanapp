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
    public partial class CheckIn : System.Web.UI.Page
    {
        CheckInController CC = new CheckInController();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCheckIn_Click(object sender, EventArgs e)
        {
            User user = new User();
            //create user object to insert into database

            try
            {

                user.name = tb_Name.Text;
                user.rank = tb_Rank.Text;
                //retrieves rank and name of user from textbox


                user.datein = DateTime.Today.ToString("ddMMyyyy");
                user.timein = DateTime.Now.ToString("HHmm");
                //user.datein = CC.getUserDateIn(user.name, user.rank);
                //user.timein = CC.getUserTimeIn(user.name, user.rank);
                //retrieves date and time in from user based on textbox

                CC.InsertUser(user.name, user.rank);
            }
            catch (Exception ex)
            {
                Session["ErrorName"] = ex.Message;
                Server.Transfer("RedirectPageError.aspx");
            }

            Session["userName"] = user.name;
            Session["userRank"] = user.rank;
            Session["userDateIn"] = user.datein;
            Session["userTimeIn"] = user.timein;
            //creates session to input values to new page

            Server.Transfer("RedirectPage.aspx");
        }
    }
}