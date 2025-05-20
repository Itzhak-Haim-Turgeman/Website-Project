<%@ Page Title="Adidas Adizero Adios Pro 3" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AdiosPro3.aspx.cs" Inherits="MasterPageTake2.AdiosPro3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .product-container {
            max-width: 1200px;
            margin: 40px auto;
            padding: 0 20px;
            font-family: Arial, sans-serif;
        }
        .product-details {
            display: grid;
            grid-template-columns: 1fr 1fr;
            gap: 40px;
            margin-top: 30px;
        }
        .product-image {
            width: 100%;
            border-radius: 8px;
            box-shadow: 0 4px 6px rgba(0,0,0,0.1);
        }
        .product-info {
            padding: 20px;
        }
        .product-title {
            font-size: 32px;
            margin-bottom: 20px;
            color: #111;
        }
        .product-price {
            font-size: 24px;
            font-weight: bold;
            color: #111;
            margin: 20px 0;
        }
        .features-list {
            margin-top: 20px;
            padding-left: 20px;
        }
        .features-list li {
            margin-bottom: 10px;
        }
        .size-grid {
            display: grid;
            grid-template-columns: repeat(auto-fill, minmax(60px, 1fr));
            gap: 10px;
            margin: 20px 0;
        }
        .size-button {
            padding: 10px;
            border: 1px solid #ddd;
            background: white;
            cursor: pointer;
            transition: all 0.2s;
        }
        .add-to-cart {
            width: 100%;
            padding: 15px;
            background: #111;
            color: white;
            border: none;
            border-radius: 4px;
            font-size: 16px;
            cursor: pointer;
            margin-top: 20px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="product-container">
        <%= msg %>
    </div>
</asp:Content>
