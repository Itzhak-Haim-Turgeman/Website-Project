using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MasterPageTake2
{
    public partial class SimpleQuery : System.Web.UI.Page
    {
        public string st = "";
        public string msg = "";
        public string sqlSelect = "";
        public string sql = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                return;

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
                string field = Request.Form["field"];
                string value = Request.Form["value"];
                string fileName = "usersDB.mdf";
                string tableName = "usersTbl";

                if (field == "gender" || field == "prefix")
                {
                    sqlSelect = $"SELECT * FROM {tableName} WHERE {field} = '{value}';";
                }
                else if (field == "yearBorn")
                {
                    sqlSelect = $"SELECT * FROM {tableName} WHERE {field} = {value};";
                }
                else if (field == "hobby")
                {
                    int val = int.Parse(value);
                    switch (val)
                    {
                        case 1: field = "hob1"; break;
                        case 2: field = "hob2"; break;
                        case 3: field = "hob3"; break;
                        case 4: field = "hob4"; break;
                        case 5: field = "hob5"; break;
                    }
                    sqlSelect = $"SELECT * FROM {tableName} WHERE {field} = 'T';";
                }
                else
                {
                    if (field == "email")
                        sqlSelect = $"SELECT * FROM {tableName} WHERE {field} LIKE '%{value}%';";
                    else
                        sqlSelect = $"SELECT * FROM {tableName} WHERE {field} LIKE N'{value}%';";
                }

                sql = sqlSelect;
                DataTable table = Helper.ExecuteDataTable(fileName, sqlSelect);


                int length = table.Rows.Count;

                if (length == 0)
                {
                    msg = "No matches found.";
                }

                else
                {
                    st += "<table class='tableDB'>";
                    st += "<tr>";
                    st += " <th class='tblTH'>User Name</th>";
                    st += " <th class='tblTH'>First Name</th>";
                    st += "<th class='tblTH'>Last Name</th>";
                    st += "<th class='tblTH'>Email</th>";
                    st += "<th class='tblTH'>Gender</th>";
                    st += "<th class='tblTH'>Year Born</th>";
                    st += "<th class='tblTH'>Phone</th>";
                    st += "<th class='tblTH'>Computers</th>";
                    st += "<<th class='tblTH'>Music</th>";
                    st += "<th class='tblTH'>Movies</th>";
                    st += "<th class='tblTH'>TV</th>";
                    st += " <th class='tblTH'>Horses</th>";
                    st += "</tr>";


                    foreach (DataRow row in table.Rows)
                    {
                        st += "<tr>";
                        st += "<td class='tblTD1'>" + row["uName"] + "</td>";
                        st += "<td class='tblTD2'>" + row["fName"] + "</td>";
                        st += "<td class='tblTD2'>" + row["lName"] + "</td>";
                        st += "<td class='tblTD2' style='width: 60px;'>" + row["email"] + "</td>";
                        st += "<td class='tblTD1'>" + row["gender"] + "</td>";
                        st += "<td class='tblTD1'>" + row["yearBorn"] + "</td>";
                        st += "<td class='tblTD1'>" + row["prefix"] + "-" + row["phone"] + "</td>";
                        st += "<td class='tblTD1'>" + row["city"] + "</td>";
                        st += "<td class='tblTD1'>" + row["hob1"] + "</td>";
                        st += "<td class='tblTD1'>" + row["hob2"] + "</td>";
                        st += "<td class='tblTD1'>" + row["hob3"] + "</td>";
                        st += "<td class='tblTD1'>" + row["hob4"] + "</td>";
                        st += "<td class='tblTD1'>" + row["hob5"] + "</td>";
                        st += "</tr>";
                    }
                    st += "</table>";

                    msg = length + " People match that description.";
                }
            }
        }
    }
}