<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ManagerPage.aspx.cs" Inherits="MasterPageTake2.ManagerPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body {
            margin: 0;
            padding: 0;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background-color: #f7f8fc;
            color: #2c3e50;
        }

        .message-container {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            background-color: #f7f8fc;
            padding: 1rem;
        }

        .message-box {
            background-color: #ffffff;
            padding: 2rem;
            border-radius: 12px;
            box-shadow: 0 4px 12px rgba(0, 0, 0, 0.15);
            max-width: 600px;
            width: 100%;
            text-align: center;
        }

        .message-box h1 {
            font-size: 28px;
            margin-bottom: 1rem;
            color: #34495e;
            font-weight: 600;
        }

        .message-box p {
            font-size: 18px;
            color: #7f8c8d;
            line-height: 1.8;
            margin-bottom: 0;
        }

        .message-box p strong {
            color: #3498db;
        }

        @media (max-width: 768px) {
            .message-box h1 {
                font-size: 24px;
            }

            .message-box p {
                font-size: 16px;
            }
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="message-container">
        <div class="message-box">
            <h1>Manager Notification</h1>
            <p>
                <%= msg %>
            </p>
        </div>
    </div>
</asp:Content>
