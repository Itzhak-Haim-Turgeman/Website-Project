<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MasterPageTake2.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .login-container {
            display: flex;
            justify-content: center;
            align-items: center;
            min-height: calc(100vh - 200px);
            background-color: #f4f4f9;
            padding: 20px;
        }
        .login-wrapper {
            background-color: white;
            border-radius: 10px;
            box-shadow: 0 10px 25px rgba(0,0,0,0.1);
            width: 100%;
            max-width: 400px;
            padding: 40px;
            transition: all 0.3s ease;
        }
        .login-wrapper:hover {
            box-shadow: 0 15px 35px rgba(0,0,0,0.15);
            transform: translateY(-5px);
        }
        .login-header {
            text-align: center;
            margin-bottom: 30px;
        }
        .login-header h2 {
            color: #2c3e50;
            font-size: 2rem;
            margin-bottom: 10px;
        }
        .login-form {
            display: flex;
            flex-direction: column;
        }
        .form-group {
            margin-bottom: 20px;
        }
        .form-group label {
            display: block;
            margin-bottom: 8px;
            color: #34495e;
            font-weight: 600;
        }
        .form-control {
            width: 100%;
            padding: 12px 15px;
            border: 1px solid #bdc3c7;
            border-radius: 6px;
            font-size: 16px;
            transition: all 0.3s ease;
        }
        .form-control:focus {
            outline: none;
            border-color: #3498db;
            box-shadow: 0 0 0 3px rgba(52, 152, 219, 0.1);
        }
        .btn-login {
            background-color: #2980b9;
            color: white;
            border: none;
            padding: 15px;
            border-radius: 6px;
            font-size: 18px;
            cursor: pointer;
            transition: all 0.3s ease;
            text-transform: uppercase;
            letter-spacing: 1px;
        }
        .btn-login:hover {
            background-color: #3498db;
            transform: translateY(-2px);
            box-shadow: 0 5px 15px rgba(0,0,0,0.1);
        }
        .login-footer {
            text-align: center;
            margin-top: 20px;
            color: #7f8c8d;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="login-container">
        <div class="login-wrapper">
            <div class="login-header">
                <h2>Login to Isaac's Shoe Store</h2>
            </div>
            <form method="post" runat="server" class="login-form">
                <div class="form-group">
                    <label for="uName">Username</label>
                    <input type="text" name="uName" id="uName" class="form-control" placeholder="Enter your username" />
                </div>
                <div class="form-group">
                    <label for="pw">Password</label>
                    <input type="password" name="pw" id="pw" class="form-control" placeholder="Enter your password" />
                </div>
                <input type="submit" name="submit" value="Log In" class="btn-login" />
            </form>
            <div class="login-footer">
                <p>Secure login for store customers</p>
            </div>
        </div>
    </div>
</asp:Content>