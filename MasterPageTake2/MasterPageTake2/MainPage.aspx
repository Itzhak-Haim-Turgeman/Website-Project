<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="MasterPageTake2.MainPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .hero-section {
            display: flex;
            align-items: center;
            background-color: #f8f9fa;
            padding: 50px 30px;
            border-radius: 10px;
            margin-bottom: 30px;
            box-shadow: 0 4px 6px rgba(0,0,0,0.1);
        }
        .hero-content {
            flex: 1;
            padding-right: 30px;
        }
        .hero-image {
            flex: 1;
            text-align: center;
        }
        .hero-image img {
            max-width: 100%;
            border-radius: 10px;
            box-shadow: 0 4px 6px rgba(0,0,0,0.2);
        }
        .section-title {
            color: #2c3e50;
            margin-bottom: 20px;
            font-size: 2rem;
            border-bottom: 3px solid #3498db;
            padding-bottom: 10px;
        }
        .about-content {
            background-color: white;
            padding: 30px;
            border-radius: 10px;
            box-shadow: 0 4px 6px rgba(0,0,0,0.1);
            margin-bottom: 30px;
        }
        .key-features {
            display: flex;
            justify-content: space-between;
            margin-top: 30px;
        }
        .feature {
            flex: 1;
            text-align: center;
            padding: 20px;
            margin: 0 15px;
            background-color: #f4f4f4;
            border-radius: 10px;
            transition: transform 0.3s ease;
        }
        .feature:hover {
            transform: translateY(-10px);
            box-shadow: 0 6px 12px rgba(0,0,0,0.1);
        }
        .feature h3 {
            color: #2980b9;
            margin-bottom: 15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="hero-section">
        <div class="hero-content">
            <h1 class="section-title">Welcome to Isaac's Shoe Store</h1>
            <p>Discover the perfect blend of comfort, style, and quality. We're not just selling shoes; we're crafting experiences for your feet.</p>
            <p>With over a decade of passion for footwear, we curate collections that speak to every individual's unique style and comfort needs.</p>
        </div>
        <div class="hero-image">
            <img src="https://cdn.shopify.com/s/files/1/0603/3031/1875/articles/j05_1024x1024.jpg?v=1632191944" alt="Stylish Shoe Collection" />
        </div>
    </div>

    <div class="about-content">
        <h2 class="section-title">About Isaac</h2>
        <p>Hi, I'm Isaac, a high-school student with a lifelong passion for programming. This is my Web-Form website project and I really enjoyed making it.</p>
    </div>

    <div class="key-features">
        <div class="feature">
            <h3>Curated Selection</h3>
            <p>Carefully selected shoes from the best brands, ensuring quality and style in every pair.</p>
        </div>
        <div class="feature">
            <h3>Perfect Fit</h3>
            <p>Personalized fitting advice and a wide range of sizes to ensure comfort for everyone.</p>
        </div>
        <div class="feature">
            <h3>Customer Passion</h3>
            <p>We're not just selling shoes, we're building a community of happy, comfortable customers.</p>
        </div>
    </div>
</asp:Content>