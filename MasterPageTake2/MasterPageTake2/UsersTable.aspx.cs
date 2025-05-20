using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

namespace MasterPageTake2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        public string st = "";
        public string msg = "";
        public string sqlSelect = "";

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
                string fileName = "usersDB.mdf";
                string tableName = "usersTbl";

                sqlSelect = "SELECT * FROM " + tableName;

                DataTable table = Helper.ExecuteDataTable(fileName, sqlSelect);

                int length = table.Rows.Count;

                if (length == 0)
                {
                    msg = "No Signs";
                }

                else
                {
                    st += "<tr>";
                    st += "<th class = 'tblTH' style = 'width: 100px;'>User Name</th>";
                    st += "<th class = 'tblTH' style = 'width: 80px;'>First Name</th>";
                    st += "<th class = 'tblTH' style = 'width: 60px;'>Last Name</th>";
                    st += "<th class = 'tblTH' style = 'width: 140px;'>Email Address</th>";
                    st += "<th class = 'tblTH' style = 'width: 60px;'>Gender</th>";
                    st += "<th class = 'tblTH' style = 'width: 100px;'>City Of Residence</th>";
                    st += "<th class = 'tblTH' style = 'width: 100px;'>Birth Year</th>";
                    st += "<th class = 'tblTH' style = 'width: 100px;'>Phone Number</th>";
                    st += "<th class = 'tblTH' style = 'width: 100px;'>Computers</th>";
                    st += "<th class = 'tblTH'>Music</th>";
                    st += "<th class = 'tblTH'>Movies</th>";
                    st += "<th class = 'tblTH'>TV</th>";
                    st += "<th class = 'tblTH'>Horses</th>";
                    st += "<th class = 'tblTH' style = 'width: 100px;'>Password</th>";
                    st += "</tr>";

                    for (int i = 0; i < length; i++)
                    {
                        st += "<tr>";
                        st += "<td class = 'tblTD1'>" + table.Rows[i]["uName"] + "</td>";
                        st += "<td class = 'tblTD2'>" + table.Rows[i]["fName"] + "</td>";
                        st += "<td class = 'tblTD2'>" + table.Rows[i]["lName"] + "</td>";
                        st += "<td class = 'tblTD3' style = 'width: 60;'>" + table.Rows[i]["email"] + "</td>";
                        st += "<td class = 'tblTD1'>" + table.Rows[i]["gender"] + "</td>";
                        st += "<td class = 'tblTD1'>" + table.Rows[i]["city"] + "</td>";
                        st += "<td class = 'tblTD1'>" + table.Rows[i]["yearBorn"] + "</td>";
                        st += "<td class = 'tblTD1'>" + table.Rows[i]["prefix"] + "-" + table.Rows[i]["phone"] + "</td>";
                        st += "<td class = 'tblTD1'>" + table.Rows[i]["hob1"] + "</td>";
                        st += "<td class = 'tblTD1'>" + table.Rows[i]["hob2"] + "</td>";
                        st += "<td class = 'tblTD1'>" + table.Rows[i]["hob3"] + "</td>";
                        st += "<td class = 'tblTD1'>" + table.Rows[i]["hob4"] + "</td>";
                        st += "<td class = 'tblTD1'>" + table.Rows[i]["hob5"] + "</td>";
                        st += "<td class = 'tblTD1'>" + table.Rows[i]["pw"] + "</td>";
                        st += "</tr>";
                    }
                    msg = "Signed up: " + length + " People";
                }
            }
        }
    }
}