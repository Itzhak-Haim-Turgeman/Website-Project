using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPageTake2
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        public string loginMsg;
        protected void Page_Load(object sender, EventArgs e)
        {
            loginMsg = "<h3>Hello ";
            loginMsg += Session["userFname"].ToString();
            loginMsg += "</h3>";

            if (Session["admin"].ToString() == "yes")
            {
                loginMsg += "[<a href = 'ManagerPage.aspx'>Managing Page</a>]<br />";
                loginMsg += "[<a href = 'Logout.aspx'>Log out</a>]<br />";
            }

            else
            {
                if (Session["uName"].ToString() == "Guest")
                {
                    loginMsg += "[<a href = 'Login.aspx'>Login</a>]<br /><br />";
                    loginMsg += "[<a href = 'SignUp.aspx'>Sign up</a>]";
                }

                else
                {
                    loginMsg += "[<a href = 'UpdateUser.aspx'>Update Credentials</a>]<br />";
                    loginMsg += "[<a href = 'Logout.aspx'>Log out</a>]<br />";
                }
            }

        }
    }
}