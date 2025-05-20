using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MasterPageTake2
{
    public partial class ManagerPage : System.Web.UI.Page
    {
        public string msg = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"].ToString() == "no")
            {
                msg += "<h3>";
                msg += "You are not an admin.";
                msg += "</br>";
                msg += "</h3>";
                msg += "<h3>";
                msg += "<a href = 'MainPage.aspx'>Main Page</a>";
                msg += "</h3>";
            }
            else
            {
                msg = "<h3><a href = 'UsersTable.aspx'>[Show Table]</a></h3>";
                msg += "<h3><a href = 'SimpleQuery.aspx'>[Simple Query]</a></h3>";
                msg += "<h3><a href = 'ComplexQuery.aspx'>[Complex Query]</a></h3>";

            }

        }
    }
}