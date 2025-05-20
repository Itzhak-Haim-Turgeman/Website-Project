<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SimpleQuery.aspx.cs" Inherits="MasterPageTake2.SimpleQuery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        function detectField() {
            var field = document.getElementById("field").value;
            var queryDiv = document.getElementById("query");
            queryDiv.innerHTML = "";  

            if (field === "gender") {
                queryDiv.innerHTML = `
            <label>
                <input type="radio" name="value" value="male" checked="checked" /> Male
            </label>
            <label>
                <input type="radio" name="value" value="female" /> Female
            </label>`;
            } else if (field === "yearBorn") {
                var currYear = new Date().getFullYear();
                var fromYear = currYear - 40;
                var toYear = currYear - 10;
                var yearOptions = "<option value='0'>Choose a year</option>";

                for (var i = fromYear; i <= toYear; i++) {
                    yearOptions += `<option value='${i}'>${i}</option>`;
                }

                queryDiv.innerHTML = `<select name='value'>${yearOptions}</select>`;
            } else if (field === "prefix") {
                var prefixes = ['050', '052', '054', '057', '077', '03', '02', '04', '08', '09'];
                var prefixOptions = prefixes.map(p => `<option value='${p}'>${p}</option>`).join("");

                queryDiv.innerHTML = `<select name='value'>${prefixOptions}</select>`;
            } else if (field === "hobby") {
                var hobbies = [
                    { value: 1, text: "Computers" },
                    { value: 2, text: "Music" },
                    { value: 3, text: "Movies" },
                    { value: 4, text: "TV" },
                    { value: 5, text: "Horses" }
                ];
                var hobbyOptions = hobbies.map(h => `<option value='${h.value}'>${h.text}</option>`).join("");

                queryDiv.innerHTML = `<select name='value'>${hobbyOptions}</select>`;
            } else {
                queryDiv.innerHTML = "<input type='text' name='value' placeholder='Enter value' />";
            }
        }
    </script>
    <style type="text/css">
        body {
        font-family: Arial, sans-serif;
        background-color: #f4f4f9;
        color: #333;
        margin: 0;
        padding: 0;
        }
        h1 {
            color: #444;
            text-align: center;
            font-size: 2.5em;
            margin-bottom: 20px;
        }
        h3 {
            text-align: center;
            color: #777;
            margin-top: 20px;
        }
        form {
            text-align: center;
            margin-bottom: 20px;
            background-color: #fff;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.1);
            display: inline-block;
            width: 80%;
        }
        select, input[type="text"], input[type="submit"], input[type="radio"] {
            margin: 10px;
            padding: 10px;
            font-size: 1em;
            border-radius: 5px;
            border: 1px solid #ccc;
            box-shadow: inset 0 1px 3px rgba(0, 0, 0, 0.1);
            width: 90%;
            max-width: 300px;
        }
        input[type="submit"] {
            background-color: #007bff;
            color: white;
            border: none;
            cursor: pointer;
            transition: background-color 0.3s ease;
        }
        input[type="submit"]:hover {
            background-color: #0056b3;
        }
        #query select, #query input[type="text"] {
            margin-left: 5px;
        }
        label {
            margin-right: 10px;
            font-size: 1em;
        }
        .tableDB {
            border-collapse: collapse;
            width: 90%;
            margin: 20px auto;
            background-color: #fff;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            border-radius: 10px;
            overflow: hidden;
        }
        .tblTH {
            text-align: center;
            border: 1px solid #ddd;
            padding: 15px;
            background-color: #007bff;
            color: white;
            font-weight: bold;
            text-transform: uppercase;
            letter-spacing: 1px;
        }
        .tblTD1, .tblTD2, .tblTD3 {
            border: 1px solid #ddd;
            padding: 15px;
            text-align: center;
            color: #555;
        }
        .tblTD2 {
            text-align: left;
        }
        .tblTD3 {
            text-align: right;
        }
        tr:nth-child(even) {
            background-color: #f9f9f9;
        }
        tr:hover {
            background-color: #e9e9e9;
            cursor: pointer;
        }
        td, th {
            transition: background-color 0.3s ease;
        }

        @media screen and (max-width: 768px) {
            form {
                width: 100%;
            }
            select, input[type="text"], input[type="submit"] {
                width: 100%;
            }
            .tableDB, .tblTH, .tblTD1, .tblTD2, .tblTD3 {
                font-size: 14px;
            }
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Data Display by Query</h1>
    <form method="post" Runat="Server">
        <select name="field" id="field" onchange="detectField();">
            <option value="lName">Last Name</option>
            <option value="fName">First Name</option>
            <option value="email">Email</option>
            <option value="gender">Gender</option>
            <option value="yearBorn">Year Born</option>
            <option value="prefix">Phone Prefix</option>
            <option value="phone">Phone</option>
            <option value="hobby">Hobby</option>
        </select>
        <div id="query"></div>
        <br /><br />
        <input type="submit" name="submit" value="Search" />
    </form>
    <%= sql %>
    
        <%= st %>
    <h3><%= msg %></h3>

</asp:Content>
