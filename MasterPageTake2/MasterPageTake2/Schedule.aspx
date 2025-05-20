<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Schedule.aspx.cs" Inherits="MasterPageTake2.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    td {
        width: 150px;
        color: #4B0082;
        font-size: 17px;
    }

    tr {
        height: 50px;
    }

    th {
        font-size: 23px;
        color: #4B0082;
    }

    body {
        background-image: url(https://www.pptbackgrounds.net/uploads/hours-backgrounds-wallpapers.jpg);
        background-size: cover;
    }

    table, th, td {
        border: medium;
        border-style: solid;
        border-color: mediumpurple;
        text-align: center;
    }

    table, td, th {
        border: 1px solid navy;
    }

    td {
        width: 150px;
    }

    tr {
        height: 50px;
    }

</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
    <tr>
        <th>10'th Grade Hours Sheet</th>
    </tr>
    <tr>
        <th>Time</th>
        <th>Sunday</th>
        <th>Monday</th>
        <th>Tuesday</th>
        <th>Wednesday</th>
        <th>Thursday</th>
        <th>Friday</th>
    </tr>
    <tr>
        <td>1 </br> 8:15 - 9:00</td>
        <td>Hebrew</td>
        <td>Computer Science</td>
        <td>Math</td>
        <td>Math</td>
        <td>Biology</td>
        <td>Computer Science</td>
    </tr>
    <tr>
        <td>2 </br> 9:00 - 9:45</td>
        <td>English</td>
        <td>Computer Science</td>
        <td>Math</td>
        <td>Computer Science</td>
        <td>History</td>
        <td>Computer Science</td>
    </tr>
    <tr>
        <td>3 </br> 10:05 - 10:50</td>
        <td>History</td>
        <td>Psychology</td>
        <td>Hebrew</td>
        <td>Chemistery</td>
        <td>Math</td>
        <td>English</td>
    </tr>
    <tr>
        <td>4 </br> 10:50 - 11:35</td>
        <td>Physical Education</td>
        <td>Chemistery</td>
        <td>Hebrew</td>
        <td>Literature</td>
        <td>Math</td>
        <td>English</td>
    </tr>
    <tr>
        <td>5 </br> 11:55 - 12:40</td>
        <td>Financial Education</td>
        <td>Chemistery</td>
        <td>Physical Education</td>
        <td>Math</td>
        <td>Shaharit</td>
        <td>Hebrew</td>
    </tr>
    <tr>
        <td>6 </br> 12:40 - 13:25</td>
        <td>Math</td>
        <td>Biology</td>
        <td>English</td>
        <td>English</td>
        <td>Biology</td>
        <td>History</td>
    </tr>
    <tr>
        <td>7 </br> 13:40 - 14:25</td>
        <td>Math</td>
        <td>Diplomatic English</td>
        <td></td>
        <td>Transportation Education</td>
        <td>Literature</td>
        <td></td>
    </tr>
    <tr>
        <td>8 </br> 14:30 - 15:15</td>
        <td></td>
        <td>Diplomatic English</td>
        <td></td>
        <td>Computer Science</td>
        <td>Computer Science</td>
        <td></td>
    </tr>
    <tr>
        <td>9 </br> 15:15 - 16:00</td>
        <td></td>
        <td>Diplomatic English</td>
        <td></td>
        <td></td>
        <td>Computer Science</td>
        <td></td>
    </tr>
</table>
</asp:Content>
