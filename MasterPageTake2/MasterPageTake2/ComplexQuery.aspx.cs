using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MasterPageTake2
{
    public partial class ComplexQuery : System.Web.UI.Page
    {
        public string st = "";
        public string msg = "";
        public string sql = "";
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
                string field1 = Request.Form["field1"];
                string field2 = Request.Form["field2"];

                string value1 = Request.Form["value1"];
                string value2 = Request.Form["value2"];
                string op = Request.Form["op"];

                string fileName = "usersDB.mdf";
                string tableName = "usersTbl";

                string query1 = "", query2 = "";

                if (!IsPostBack)
                    return;

                if (value1 != null)
                {
                    if (field1 == "gender" || field1 == "prefix")
                    {
                        query1 = field1 + " = '" + value1 + "'";
                    }
                    else if (field1 == "yearBorn")
                    {
                        query1 = field1 + " = " + value1;
                    }
                    else if (field1 == "yearFrom")
                    {
                        query1 = field1 + " >= " + value1;
                    }
                    else if (field1 == "hobby")
                    {
                        var val1 = int.Parse(value1);

                        switch (val1)
                        {
                            case 1:
                                field1 = "hob1";
                                break;
                            case 2:
                                field1 = "hob2";
                                break;
                            case 3:
                                field1 = "hob3";
                                break;
                            case 4:
                                field1 = "hob4";
                                break;
                            case 5:
                                field1 = "hob5";
                                break;
                        }
                        query1 = field1 + " = 'T'";
                    }
                    else if (field1 == "email")
                    {
                        query1 = field1 + " LIKE '%" + value1 + "%'";
                    }
                    else
                    {
                        query1 = field1 + " LIKE N'" + value1 + "%'";
                    }
                }

                if (value2 != null)
                {
                    if (field2 == "gender" || field2 == "prefix")
                    {
                        query2 = field2 + " = '" + value2 + "'";
                    }
                    else if (field2 == "yearBorn")
                    {
                        query2 = field2 + " = " + value2;
                    }
                    else if (field2 == "yearTo")
                    {
                        query2 = field2 + " <= " + value2;
                    }
                    else if (field2 == "hobby")
                    {
                        var val2 = int.Parse(value2); 

                        switch (val2)
                        {
                            case 1:
                                field2 = "hob1";
                                break;
                            case 2:
                                field2 = "hob2";
                                break;
                            case 3:
                                field2 = "hob3";
                                break;
                            case 4:
                                field2 = "hob4";
                                break;
                            case 5:
                                field2 = "hob5";
                                break;
                        }
                        query2 = field2 + " = 'T'";
                    }
                    else if (field2 == "email")
                    {
                        query2 = field2 + " LIKE '%" + value2 + "%'";
                    }
                    else
                    {
                        query2 = field2 + " LIKE N'" + value2 + "%'";
                    }
                }

                string sqlSelect = "";

                if (query1 != "" || query2 != "")
                {
                    if (query1 != "" && query2 == "")
                    {
                        sqlSelect = "SELECT * FROM " + tableName + " WHERE (" + query1 + ");";
                    }
                    else if (query1 == "" && query2 != "")
                    {
                        sqlSelect = "SELECT * FROM " + tableName + " WHERE (" + query2 + ");";
                    }
                    else if (op == "and")
                    {
                        sqlSelect = "SELECT * FROM " + tableName + " WHERE (" + query1 + " AND " + query2 + ");";
                    }
                    else
                    {
                        sqlSelect = "SELECT * FROM " + tableName + " WHERE (" + query1 + " OR " + query2 + ");";
                    }
                }
                sql = sqlSelect;

                DataTable table = Helper.ExecuteDataTable(fileName, sqlSelect);

                int length = table.Rows.Count;

                if (length == 0)
                {
                    msg = "No users match your conditions.";
                }
                else
                {
                    st += "<tr>";
                    st += "<th style = 'text-align: center; width: 100px;'>Username</th>";
                    st += "<th style = 'text-align: center; width: 80px;'>Last Name</th>";
                    st += "<th style = 'text-align: center; width: 60px;'>First Name</th>";
                    st += "<th style = 'text-align: center; width: 140px;'>ID</th>";
                    st += "<th style = 'text-align: center; width: 60px;'>Gender</th>";
                    st += "<th style = 'text-align: center;'>Birth Year</th>";
                    st += "<th style = 'text-align: center; width: 100px;'>Phone Number</th>";
                    st += "<th style = 'text-align: center;'>Computers</th>";
                    st += "<th style = 'text-align: center;'>Music</th>";
                    st += "<th style = 'text-align: center;'>Movies</th>";
                    st += "<th style = 'text-align: center;'>TV</th>";
                    st += "<th style = 'text-align: center;'>Horses</th>";
                    st += "</tr>";

                    for (int i = 0; i < length; i++)
                    {
                        st += "<tr>";
                        st += "<td style='text-align: center;'>" + table.Rows[i]["uName"] + "</td>";
                        st += "<td>" + table.Rows[i]["lName"] + "</td>";
                        st += "<td>" + table.Rows[i]["fName"] + "</td>";
                        st += "<td style='width: 60; text-align: left;'>" + table.Rows[i]["email"] + "</td>";
                        st += "<td style='text-align: center;'>" + table.Rows[i]["gender"] + "</td>";
                        st += "<td style='text-align: center;'>" + table.Rows[i]["yearBorn"] + "</td>";
                        st += "<td style='text-align: center;'>" + table.Rows[i]["prefix"] + "-" + table.Rows[i]["phone"] + "</td>";
                        st += "<td style='text-align: center;'>" + table.Rows[i]["hob1"] + "</td>";
                        st += "<td style='text-align: center;'>" + table.Rows[i]["hob2"] + "</td>";
                        st += "<td style='text-align: center;'>" + table.Rows[i]["hob3"] + "</td>";
                        st += "<td style='text-align: center;'>" + table.Rows[i]["hob4"] + "</td>";
                        st += "<td style='text-align: center;'>" + table.Rows[i]["hob5"] + "</td>";
                        st += "</tr>";
                    }

                    msg = length + " People that match your conditions.";
                }
            }
        }
    }
}
