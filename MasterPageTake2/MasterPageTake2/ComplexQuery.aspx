<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ComplexQuery.aspx.cs" Inherits="MasterPageTake2.ComplexQuery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />

    <style>
        body {
            background-color: #f8f9fa;
            font-family: Arial, sans-serif;
        }

        h1 {
            color: #343a40;
            margin-bottom: 30px;
        }

        table {
            margin: auto;
            background-color: #ffffff;
            border-collapse: collapse;
            box-shadow: 0px 0px 15px rgba(0, 0, 0, 0.1);
        }

        td {
            padding: 10px;
            text-align: left;
        }

        select,
        input[type="text"],
        input[type="submit"],
        input[type="radio"] {
            margin: 5px 0;
        }

        #query1,
        #query2 {
            text-align: center;
        }

        .custom-table {
            width: 100%;
            margin-top: 20px;
            box-shadow: 0px 0px 15px rgba(0, 0, 0, 0.1);
        }

        .custom-table thead {
            background-color: #007bff;
            color: #ffffff;
        }

        .custom-table th, .custom-table td {
            padding: 10px;
            text-align: center;
        }

        .custom-table tbody tr:nth-child(even) {
            background-color: #f2f2f2;
        }
    </style>
    <script>
        function detectField1() {
            const field1 = document.getElementById("field1").value;
            let query1HTML = "";

            if (field1 === "gender") {
                query1HTML = `
            <input type='radio' name='value1' value='male' checked='checked' />M
            <input type='radio' name='value1' value='female' />F
        `;
            } else if (field1 === "yearBorn" || field1 === "yearFrom") {
                const currYear = new Date().getFullYear();
                const fromYear = currYear - 40;
                const toYear = currYear - 10;

                query1HTML = "<select name='value1'><option value='0'>Choose a year</option>";
                for (let i = fromYear; i <= toYear; i++) {
                    query1HTML += `<option value='${i}'>${i}</option>\n`;
                }
                query1HTML += "</select>";
            } else if (field1 === "prefix") {
                query1HTML = `
            <select name='value1'>
                <option value='050'>050</option>
                <option value='052'>052</option>
                <option value='054'>054</option>
                <option value='057'>057</option>
                <option value='077'>077</option>
                <option value='03'>03</option>
                <option value='02'>02</option>
                <option value='04'>04</option>
                <option value='08'>08</option>
                <option value='09'>09</option>
            </select>
        `;
            } else if (field1 === "hobby") {
                query1HTML = `
            <select name='value1'>
                <option value='1'>Computers</option>
                <option value='2'>Music</option>
                <option value='3'>Movies</option>
                <option value='4'>TV</option>
                <option value='5'>Horses</option>
            </select>
        `;
            } else {
                query1HTML = "<input type='text' name='value1' />";
            }

            document.getElementById("query1").innerHTML = query1HTML;
        }

        function detectField2() {
            const field2 = document.getElementById("field2").value;
            let query2HTML = "";

            if (field2 === "gender") {
                query2HTML = `
            <input type='radio' name='value2' value='male' checked='checked' />M
            <input type='radio' name='value2' value='female' />F
        `;
            } else if (field2 === "yearBorn" || field2 === "yearTo") {
                const currYear = new Date().getFullYear();
                const fromYear = currYear - 40;
                const toYear = currYear - 10;

                query2HTML = "<select name='value2'><option value='0'>Choose a year</option>";
                for (let i = fromYear; i <= toYear; i++) {
                    query2HTML += `<option value='${i}'>${i}</option>\n`;
                }
                query2HTML += "</select>";
            } else if (field2 === "prefix") {
                query2HTML = `
            <select name='value2'>
                <option value='050'>050</option>
                <option value='052'>052</option>
                <option value='054'>054</option>
                <option value='057'>057</option>
                <option value='077'>077</option>
                <option value='03'>03</option>
                <option value='02'>02</option>
                <option value='04'>04</option>
                <option value='08'>08</option>
                <option value='09'>09</option>
            </select>
        `;
            } else if (field2 === "hobby") {
                query2HTML = `
            <select name='value2'>
                <option value='1'>Computers</option>
                <option value='2'>Music</option>
                <option value='3'>Movies</option>
                <option value='4'>TV</option>
                <option value='5'>Horses</option>
            </select>
        `;
            } else {
                query2HTML = "<input type='text' name='value2' />";
            }

            document.getElementById("query2").innerHTML = query2HTML;
        }


        

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-5">
        <div class="text-center">
            <h1>Presenting people that match 1 condition or 2 conditions.</h1>
        </div>

        <form id="Form1" method="post" runat="server" class="p-3">
            <table class="table table-bordered">
                <tr>
                    <td>
                        <select name="field1" id="field1" class="form-control" onclick="detectField1();">
                            <option value="lName">Last Name</option>
                            <option value="fName">First Name</option>
                            <option value="email">Email</option>
                            <option value="gender">Gender</option>
                            <option value="yearBorn">Birth year</option>
                            <option value="yearTo">Year to</option>
                            <option value="prefix">Prefix</option>
                            <option value="phone">Phone Number</option>
                            <option value="hobby">Hobby</option>
                        </select>
                    </td>
                    <td>
                        <div id="query1"></div>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" class="text-center">
                        <input type="radio" name="op" value="and" checked='checked' /> AND
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <input type="radio" name="op" value="or" /> OR
                    </td>
                </tr>
                <tr>
                    <td>
                        <select name="field2" id="field2" class="form-control" onclick="detectField2();">
                            <option value="lName">Last Name</option>
                            <option value="fName">First Name</option>
                            <option value="email">Email</option>
                            <option value="gender">Gender</option>
                            <option value="yearBorn">Birth year</option>
                            <option value="yearTo">Year to</option>
                            <option value="prefix">Prefix</option>
                            <option value="phone">Phone Number</option>
                            <option value="hobby">Hobby</option>
                        </select>
                    </td>
                    <td>
                        <div id="query2"></div>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" class="text-center">
                        <input type="submit" name="submit" value="Search" class="btn btn-primary" />
                    </td>
                </tr>
            </table>
        </form>

        <div class="text-center mt-3">
            <p><%= sql %></p>
            <div class="custom-table">
                <table class="table table-striped table-hover">
                    <thead>
                    </thead>
                    <tbody>
                        <%= st %>
                    </tbody>
                </table>
            </div>
            <p><%= msg %></p>
        </div>
    </div>
</asp:Content>