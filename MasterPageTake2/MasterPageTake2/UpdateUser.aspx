<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateUser.aspx.cs" Inherits="MasterPageTake2.UpdateUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        /* General styling for the page */
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }

        table {
            width: 100%;
            max-width: 600px;
            margin: 20px auto;
            background-color: #fff;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            padding: 20px;
        }

        td {
            padding: 10px;
        }

        input[type="text"],
        input[type="password"],
        select {
            width: 100%;
            padding: 8px;
            margin-top: 4px;
            margin-bottom: 12px;
            border: 1px solid #ccc;
            border-radius: 4px;
            font-size: 14px;
        }

        input[type="radio"] {
            margin-right: 5px;
        }

        input[type="submit"],
        input[type="button"] {
            background-color: #4CAF50;
            color: white;
            padding: 10px 20px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            font-size: 16px;
        }

        input[type="submit"]:hover,
        input[type="button"]:hover {
            background-color: #45a049;
        }

        .error {
            display: none;
            color: red;
            font-weight: bold;
            background-color: #f8d7da;
            padding: 5px;
            border-radius: 4px;
            margin-top: 8px;
        }

        /* Hobbies section */
        .cdHob {
            width: 120px;
            padding-right: 10px;
        }

        .hobbies-table {
            width: 100%;
            border-spacing: 0;
        }

        .hobbies-table td {
            vertical-align: middle;
        }
    </style>

     <script>
         function check() {
             var uName = document.getElementById("uName").value;
             if (!userNameOK(uName)) return false;

             var fName = document.getElementById("fName").value;
             if (fName.length < 2) {
                 document.getElementById("mFName").textContent = "First name too short or doesn't exist.";
                 document.getElementById("mFName").style.display = "inline";
                 return false;
             } else {
                 document.getElementById("mFName").style.display = "none";
             }

             var lName = document.getElementById("lName").value;
             if (lName.length < 2) {
                 document.getElementById("mLName").textContent = "Last name too short or doesn't exist";
                 document.getElementById("mLName").style.display = "inline";
                 return false;
             } else {
                 document.getElementById("mLName").style.display = "none";
             }

             var email = document.getElementById("email").value;
             if (!emailOK(email)) return false;

             var yearBorn = document.getElementById("yearBorn").value;
             if (!yearBornOk(yearBorn)) return false;

             var city = document.getElementById("city").value;
             if (city === "") {
                 document.getElementById("cityError").style.display = "inline";
                 return false;
             } else {
                 document.getElementById("cityError").style.display = "none";
             }

             var phone = document.getElementById("phone").value;
             if (!phone.match(/^\d{7}$/)) {
                 document.getElementById("phoneError").style.display = "inline";
                 return false;
             } else {
                 document.getElementById("phoneError").style.display = "none";
             }

             // Updated password validation logic
             var password = document.getElementById("pw").value;
             if (!passwordOK(password)) return false;

             var retypePassword = document.getElementById("retypePassword").value;
             if (password != retypePassword) {
                 document.getElementById("retypePasswordError").textContent = "Passwords do not match.";
                 document.getElementById("retypePasswordError").style.display = "inline";
                 return false;
             } else {
                 document.getElementById("retypePasswordError").style.display = "none";
             }

             return true;
         }

         // Password validation function
         function passwordOK(password) {
             // Password must be at least 8 characters long
             if (password.length < 8) {
                 document.getElementById("passwordError").textContent = "Password must be at least 8 characters long.";
                 document.getElementById("passwordError").style.display = "inline";
                 return false;
             }

             // Password must contain at least one uppercase letter, one number, and one special character
             if (!/[A-Z]/.test(password)) {
                 document.getElementById("passwordError").textContent = "Password must contain at least one uppercase letter.";
                 document.getElementById("passwordError").style.display = "inline";
                 return false;
             }
             if (!/[0-9]/.test(password)) {
                 document.getElementById("passwordError").textContent = "Password must contain at least one number.";
                 document.getElementById("passwordError").style.display = "inline";
                 return false;
             }
             if (!/[!@#$%^&*]/.test(password)) {
                 document.getElementById("passwordError").textContent = "Password must contain at least one special character.";
                 document.getElementById("passwordError").style.display = "inline";
                 return false;
             }

             // Clear password error if everything is okay
             document.getElementById("passwordError").style.display = "none";
             return true;
         }


         function userNameOK(name) {
             var msg = "";

             if (name.length < 5) msg = "Username too short or does not exist.";
             else if (name.length > 30) msg = "Username too long.";
             else if (isHebrew(name)) msg = "Username must be in English.";
             else if (isQuot(name)) msg = "Username cannot contain ' '.";
             else if (isBadChars(name)) msg = "Username cannot contain any special characters.";

             if (msg !== "") {
                 document.getElementById("mUName").textContent = msg;
                 document.getElementById("mUName").style.display = "inline";
                 return false;
             } else {
                 document.getElementById("mUName").style.display = "none";
             }

             return true;
         }

         function emailOK(mail) {
             var msg = "";
             var atSign = mail.indexOf('@');
             var dotSign = mail.indexOf('.', atSign);

             if (mail.length < 6) msg = "Mail address too short or doesn't exist.";
             else if (mail.length > 30) msg = "Mail address has to be between 6-30 characters.";
             else if (isHebrew(mail)) msg = "Mail address must be written in English.";
             else if (isQuot(mail) || isBadChars(mail)) msg = "Mail address cannot contain special characters.";
             else if (atSign === -1 || atSign !== mail.lastIndexOf('@')) msg = "Mail address can contain only 1 '@'.";
             else if (dotSign === -1) msg = "Mail address must contain at least 1 '.'.";
             else if (dotSign - atSign < 2) msg = "Period must appear after the '@'.";
             else if (dotSign === mail.length - 1 || mail.indexOf('.') === 0) msg = "Period cannot appear at the start or end of the mail address.";
             else if (atSign === 0 || atSign === mail.length - 1) msg = "The '@' sign cannot appear at the start or end of the mail address.";

             if (msg !== "") {
                 document.getElementById("mEmail").textContent = msg;
                 document.getElementById("mEmail").style.display = "inline";
                 return false;
             } else {
                 document.getElementById("mEmail").style.display = "none";
             }

             return true;
         }

         function isQuot(str) {
             return str.indexOf('"') !== -1 || str.indexOf("'") !== -1;
         }

         function isBadChars(str) {
             var badChars = "%^&*()-![]{}<>?";
             for (var i = 0; i < badChars.length; i++) {
                 if (str.indexOf(badChars.charAt(i)) !== -1) return true;
             }
             return false;
         }

         function isHebrew(str) {
             for (var i = 0; i < str.length; i++) {
                 if (str.charAt(i) >= 'א' && str.charAt(i) <= 'ת') return true;
             }
             return false;
         }

         function yearBornOk(year) {
             var msg = "";
             var d = new Date();
             var current = d.getFullYear();
             var old = current - 100;
             var young = current - 5;

             if (isNaN(year)) {
                 msg = "Birth year must contain only numbers.";
             } else if (year < 1900) {
                 msg = "Birth year must be after 1900.";
             } else if (year < old) {
                 msg = "Too old! Birth year must be after - " + (old - 1);
             } else if (year >= young) {
                 msg = "Too young! Birth year must be before - " + young;
             }

             if (msg !== "") {
                 document.getElementById("yearError").textContent = msg;
                 document.getElementById("yearError").style.display = "inline";
                 return false;
             } else {
                 document.getElementById("yearError").style.display = "none";
             }

             return true;
         }
     </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form method="post" runat="server" obsubmit="return check();">
        <table>
            <tr>
                <td>Username</td>
                <td>
                    <input type="text" id="uName" name="uName" disabled="disabled" value="<%= uName %>" />
                </td>
                <td></td>
            </tr>
            <tr>
                <td>First Name</td>
                <td>
                    <input type="text" id="fName" name="fName" value="<%= fName %>" />
                    <div id="mFName" class="error"></div>
                </td>
            </tr>
            <tr>
                <td>Last Name</td>
                <td>
                    <input type="text" id="lName" name="lName" value="<%= lName %>" />
                    <div id="mLName" class="error"></div>
                </td>
            </tr>
            <tr>
                <td>Email</td>
                <td>
                    <input type="text" id="email" name="email" value="<%= email %>" />
                    <div id="mEmail" class="error"></div>
                </td>
            </tr>
            <tr>
                <td>Gender</td>
                <td>
                    <% if (gender == "male") { %>
                        <input type="radio" id="male" name="gender" value="male" checked /> Male
                        <input type="radio" id="female" name="gender" value="female" /> Female
                    <% } else { %>
                        <input type="radio" id="male" name="gender" value="male" /> Male
                        <input type="radio" id="female" name="gender" value="female" checked /> Female
                    <% } %>
                </td>
            </tr>
            <tr>
                <td>City</td>
                <td>
                    <select id="city" name="city">
                        <option value="">Select City</option>
                        <option value="Afula">Afula</option>
                        <option value="Ashdod">Ashdod</option>
                        <option value="Ashkelon">Ashkelon</option>
                        <option value="Bat Yam">Bat Yam</option>
                        <option value="Beersheba">Beersheba</option>
                        <option value="Beit Shemesh">Beit Shemesh</option>
                        <option value="Bnei Brak">Bnei Brak</option>
                        <option value="Dimona">Dimona</option>
                        <option value="Eilat">Eilat</option>
                        <option value="Haifa">Haifa</option>
                        <option value="Herzliya">Herzliya</option>
                        <option value="Holon">Holon</option>
                        <option value="Jerusalem">Jerusalem</option>
                        <option value="Karmiel">Karmiel</option>
                        <option value="Kfar Saba">Kfar Saba</option>
                        <option value="Lod">Lod</option>
                        <option value="Nahariya">Nahariya</option>
                        <option value="Nazareth">Nazareth</option>
                        <option value="Netanya">Netanya</option>
                        <option value="Petah Tikva">Petah Tikva</option>
                        <option value="Raanana">Raanana</option>
                        <option value="Ramat Gan">Ramat Gan</option>
                        <option value="Ramla">Ramla</option>
                        <option value="Rehovot">Rehovot</option>
                        <option value="Rishon LeZion">Rishon LeZion</option>
                        <option value="Safed">Safed</option>
                        <option value="Sderot">Sderot</option>
                        <option value="Tel Aviv">Tel Aviv</option>
                        <option value="Tiberias">Tiberias</option>
                        <option value="Yavne">Yavne</option>
                    </select>
                    <div id="cityError" class="error"></div>
                </td>
            </tr>
            <tr>
                <td>Phone Number: </td>
                <td>
                    <input type="text" name="phone" id="phone" size="7" value="<%= phone %>" />
                        <select name="prefix" id="prefix">
                        <% if (prefix == "050") { %>
                        <option value="050" selected>050</option>
                        <% } else { %>
                        <option value="050">050</option>
                        <% } %>
            
                        <% if (prefix == "052") { %>
                        <option value="052" selected>052</option>
                        <% } else { %>
                        <option value="052">052</option>
                        <% } %>

                        <% if (prefix == "053") { %>
                        <option value="053" selected>053</option>
                        <% } else { %>
                        <option value="053">053</option>
                        <% } %>

                        <% if (prefix == "054") { %>
                        <option value="054" selected>054</option>
                        <% } else { %>
                        <option value="054">054</option>
                        <% } %>

                        <% if (prefix == "055") { %>
                        <option value="055" selected>055</option>
                        <% } else { %>
                        <option value="055">055</option>
                        <% } %>

                        <% if (prefix == "058") { %>
                        <option value="058" selected>058</option>
                        <% } else { %>
                        <option value="058">058</option>
                        <% } %>
                        </select>
                    <div id="phoneError" class="error"></div>
                    </td>
                    <td>
                        <input type="text" name="mPhone" id="mPhone" style="display:none; background-color:Black; color:White; font-weight:bold;" disabled="disabled" />
                    </td>
            </tr>

            <tr>
                <td>Hobbies</td>
                <td>
                    <table class="hobbies-table">
                        <tr>
                            <td class="cdHob">
                                <% if (hob1 == "T")
                                    { %>
                                    <input type="checkbox" name="hobby" value="1" checked="checked" />
                                <% }
                                    else
                                    { %>
                                    <input type="checkbox" name="hobby" value="1" />
                                <% } %> Computers
                            </td>

                            <td class="cdHob">
                                <% if (hob2 == "T")
                                    { %>
                                    <input type="checkbox" name="hobby" value="2" checked="checked" />
                                <% }
                                    else
                                    { %>
                                    <input type="checkbox" name="hobby" value="2" />
                                <% } %> Music
                            </td>

                            <td class="cdHob">
                                <% if (hob3 == "T")
                                    { %>
                                    <input type="checkbox" name="hobby" value="3" checked="checked" />
                                <% }
                                    else
                                    { %>
                                    <input type="checkbox" name="hobby" value="3" />
                                <% } %> Movies
                            </td>

                            <td class="cdHob">
                                <% if (hob4 == "T")
                                    { %>
                                    <input type="checkbox" name="hobby" value="4" checked="checked" />
                                <% }
                                    else
                                    { %>
                                    <input type="checkbox" name="hobby" value="4" />
                                <% } %> TV
                            </td>

                            <td class="cdHob">
                                <% if (hob5 == "T")
                                    { %>
                                    <input type="checkbox" name="hobby" value="5" checked="checked" />
                                <% }
                                    else
                                    { %>
                                    <input type="checkbox" name="hobby" value="5" />
                                <% } %> Horses
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>Password: </td>
                <td>
                    <input type="password" name="pw" id="pw" size="10" value="<%= pw %>" maxlength="10" />
                    <span style="color: red; font-size: 15pt;">Max 10 characters*</span>
                    <div id="passwordError" class="error"></div>
                </td>
                <td>
                    <input type="text" name="mPw" id="mPw" style="display:none; background-color:Black; color: White; font-weight:bold;" disabled="disabled" />
                </td>
            </tr>
            <tr>
                <td>Confirm password: </td>
                <td>
                    <input type="password" name="pw1" id="pw1" size="10" value="<%= pw %>" maxlength="10" />
                    <div id="retypePasswordError" class="error"></div>
                </td>
                <td>
                    <input type="text" name="mPw1" id="mPw1" style="display:none; background-color:Black; color: White; font-weight:bold;" disabled="disabled" />
                </td>
            </tr>

            <tr>
                <td>Birth Year: </td>
                <td>
                    <select name="yearBorn">
                        <%= yearList %>
                    </select>
                </td>
            </tr>

            <tr>
                <td colspan="2" style="text-align: center;">
                    <input type="submit" name="submit" value="Update" />
                </td>
            </tr>

        </table>
    </form>
</asp:Content>
