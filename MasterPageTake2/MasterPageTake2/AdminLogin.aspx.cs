using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MasterPageTake2
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        public string msg = "";
        public string sqlAdmin = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["Submit"] != null)
            {
                string name = Request.Form["mName"];
                string mPw = Request.Form["mPw"];
                string fileName = "usersDB.mdf";

                sqlAdmin = $"SELECT * FROM managerTbl WHERE (mName = '{name}' AND mPw = '{mPw}');";

                DataTable table = Helper.ExecuteDataTable(fileName, sqlAdmin);

                int length = table.Rows.Count;

                if (length == 0)
                {
                    msg = "<div style='text-align: center;'>";
                    msg += "<h3>You do not have access to this page.<h3>";
                    msg += "<a href='MainPage.aspx'>[Continue]</a>";
                    msg += "</div>";
                }

                else
                {
                    Application.Lock();
                    Application["counter"] = (int)Application["counter"] + 1;
                    Application.UnLock();
                    Session["uName"] = "Admin";
                    Session["userFName"] = "Admin";
                    Session["admin"] = "yes";
                    Response.Redirect("MainPage.aspx");
                }

            }
        }
    }
}