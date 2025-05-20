using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MasterPageTake2
{
    public partial class SignUp : System.Web.UI.Page
    {
        public string st = "";
        public string sqlMsg = "";
        public string msg = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["submit"] != null)
            {
                string fileName = "usersDB.mdf";
                string tableName = "usersTbl";
                string uName = Request.Form["uName"];
                string fName = Request.Form["fName"];
                string lName = Request.Form["lName"];
                string email = Request.Form["email"];
                string gender = Request.Form["gender"];
                string yearBorn = Request.Form["yearBorn"];
                int yBorn = int.Parse(yearBorn);
                string city = Request.Form["city"];
                string prefix = Request.Form["prefix"];
                string phone = Request.Form["phone"];
                char hob1 = 'F', hob2 = 'F', hob3 = 'F', hob4 = 'F', hob5 = 'F';
                if (Request.Form["hobby"] != null)
                {
                    string hobby = Request.Form["hobby"].ToString();
                    if (hobby.Contains('1'))
                    {
                        hob1 = 'T';
                    }

                    if (hobby.Contains('2'))
                    {
                        hob2 = 'T';
                    }

                    if (hobby.Contains('3'))
                    {
                        hob3 = 'T';
                    }

                    if (hobby.Contains('4'))
                    {
                        hob4 = 'T';
                    }

                    if (hobby.Contains('5'))
                    {
                        hob5 = 'T';
                    }
                }

                

                string pw = Request.Form["pw"];

                string sqlSelect = $"SELECT * FROM {tableName} WHERE uName = '{uName}'";

                if (Helper.IsExist(fileName, sqlSelect))
                {
                    msg = "Username already taken.";
                    sqlMsg = sqlSelect;
                }

                else
                {
                    string sqlInsert = $"INSERT INTO {tableName} VALUES ('{uName}' , N'{fName}' , N'{lName}' , '{email}' , {yearBorn} , '{gender}' , '{prefix}' , '{phone}' , '{city}' , '{hob1}' , '{hob2}' , '{hob3}' , '{hob4}' , '{hob5}' , '{pw}')";
                    Helper.DoQuery(fileName, sqlInsert);
                    sqlMsg = sqlInsert;
                    msg = "Success";
                }


                /*
                st += "<tr><td>user name: </td><td>" + uName + "</td></tr>";
                st += "<tr><td>first name: </td><td>" + fName + "</td></tr>";
                st += "<tr><td>last name: </td><td>" + lName + "</td></tr>";
                st += "<tr><td>email: </td><td>" + email + "</td></tr>";
                st += "<tr><td>yearBorn: </td><td>" + yBorn + "</td></tr>";
                st += "<tr><td>gender: </td><td>" + gender + "</td></tr>";
                st += "<tr><td>city: </td><td>" + city + "</td></tr>";
                st += "<tr><td>phone: </td><td>" + prefix + "-" + phone + "</td></tr>";
                st += "<tr><td>hobbies: </td><td>";

                if (hob1 == 'T')
                    st += "Computers, ";
                if (hob2 == 'T')
                    st += "Music, ";
                if (hob3 == 'T')
                    st += "Movies, ";
                if (hob4 == 'T')
                    st += "TV, ";
                if (hob5 == 'T')
                    st += "Horses";
                st += "</td></tr>";

                st += "<tr><td>Password: </td><td>" + pw + "</td></tr>";
                */
            }
            
            
        }
    }
}