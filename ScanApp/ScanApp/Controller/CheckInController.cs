using ScanApp.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScanApp.Controller
{
    public class CheckInController
    {

        CheckInDAO checkInDAO = new CheckInDAO();

        public void InsertUser(string name, string rank)
        {
            checkInDAO.InsertUser(name, rank);
        }

        public string getUserDateIn(string name, string rank)
        {
            string datein = "";
            
            datein = checkInDAO.GetUserDateIn(name, rank);

            return datein;
        }

        public string getUserTimeIn(string name, string rank)
        {
            string timein = "";

            timein = checkInDAO.GetUserDateIn(name, rank);

            return timein;
        }
    }
}