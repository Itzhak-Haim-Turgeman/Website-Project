using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MasterPageTake2
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uName"].ToString() == "Guest")
            {
                return;
            }

            else
            {
                Session.Abandon();
                Response.Redirect("MainPage.aspx");
            }
        }
    }
}