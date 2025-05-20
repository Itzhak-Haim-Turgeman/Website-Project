<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UsersTable.aspx.cs" Inherits="MasterPageTake2.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background-color: #f7f8fc;
            color: #2c3e50;
            margin: 0;
            padding: 0;
        }

        h1 {
            text-align: center;
            font-size: 2.5rem;
            color: #34495e;
            margin-bottom: 20px;
        }

        h2 {
            text-align: center;
            font-size: 1.5rem;
            color: #7f8c8d;
            margin-bottom: 20px;
        }

        h3 {
            text-align: center;
            font-size: 1rem;
            color: #95a5a6;
            margin-top: 20px;
            font-style: italic;
        }

        .table-container {
            width: 90%;
            margin: 20px auto;
            border-radius: 12px;
            overflow: hidden;
            box-shadow: 0 4px 12px rgba(0, 0, 0, 0.1);
            background-color: #ffffff;
        }

        .tableDB {
            width: 100%;
            border-collapse: collapse;
        }

        .tblTH {
            background-color: #3498db;
            color: white;
            text-transform: uppercase;
            font-size: 1rem;
            font-weight: 600;
            letter-spacing: 0.05em;
            padding: 15px;
            text-align: center;
        }

        .tblTD1, .tblTD2, .tblTD3 {
            padding: 15px;
            text-align: center;
            font-size: 1rem;
            color: #2c3e50;
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
            background-color: #ecf0f1;
            cursor: pointer;
        }

        td, th {
            border-bottom: 1px solid #ddd;
            transition: background-color 0.3s ease;
        }

        .no-data {
            text-align: center;
            font-size: 1.2rem;
            color: #e74c3c;
            padding: 20px;
        }

        /* Responsive styling */
        @media (max-width: 768px) {
            h1 {
                font-size: 2rem;
            }

            h2 {
                font-size: 1.2rem;
            }

            .tblTH, .tblTD1, .tblTD2, .tblTD3 {
                font-size: 0.9rem;
            }
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Users Table</h1>
    <h2><%= sqlSelect %></h2>

    <table class="tableDB">
        <%= st %>
    </table>

    <h3><%= msg %></h3>
</asp:Content>
