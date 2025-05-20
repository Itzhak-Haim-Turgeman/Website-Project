<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="MasterPageTake2.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        /* Form Container Styles */
        .form-container {
            max-width: 800px;
            margin: 2rem auto;
            padding: 2rem;
            background: white;
            border-radius: 10px;
            box-shadow: 0 4px 6px rgba(0,0,0,0.1);
        }

        h1 {
            color: #2c3e50;
            text-align: center;
            font-size: 2.5rem;
            margin-bottom: 2rem;
            font-weight: 600;
        }

        .form-table {
            width: 100%;
            margin: 0 auto;
        }

        .form-table td {
            padding: 1rem;
            vertical-align: middle;
        }

        .form-table td:first-child {
            width: 30%;
            font-size: 1.1rem;
            color: #2c3e50;
            font-weight: 500;
        }

        /* Input Styles */
        input[type="text"], 
        input[type="password"], 
        select {
            width: 100%;
            height: 45px;
            padding: 0.5rem 1rem;
            font-size: 1rem;
            border: 2px solid #e0e0e0;
            border-radius: 6px;
            transition: border-color 0.3s ease;
            background-color: #f8f9fa;
        }

        input[type="text"]:focus, 
        input[type="password"]:focus, 
        select:focus {
            outline: none;
            border-color: #3498db;
            box-shadow: 0 0 0 3px rgba(52, 152, 219, 0.1);
        }

        /* Radio and Checkbox Styles */
        input[type="radio"], 
        input[type="checkbox"] {
            transform: scale(1.2);
            margin-right: 0.5rem;
            accent-color: #3498db;
        }

        .radio-group,
        .checkbox-group {
            display: flex;
            gap: 1.5rem;
            align-items: center;
        }

        /* Phone Number Input Group */
        .phone-group {
            display: flex;
            gap: 1rem;
        }

        .phone-group select {
            width: 120px;
        }

        .phone-group input {
            flex: 1;
        }

        /* Button Styles */
        .button-group {
            display: flex;
            gap: 1rem;
            justify-content: center;
            margin-top: 2rem;
        }

        input[type="submit"],
        input[type="button"] {
            padding: 0.75rem 2rem;
            font-size: 1rem;
            border: none;
            border-radius: 6px;
            cursor: pointer;
            transition: all 0.3s ease;
            font-weight: 500;
        }

        input[type="submit"] {
            background-color: #3498db;
            color: white;
        }

        input[type="submit"]:hover {
            background-color: #2980b9;
            transform: translateY(-2px);
        }

        input[type="button"] {
            background-color: #e0e0e0;
            color: #2c3e50;
        }

        input[type="button"]:hover {
            background-color: #d0d0d0;
            transform: translateY(-2px);
        }

        /* Error Message Styles */
        .error {
            color: #e74c3c;
            font-size: 0.9rem;
            margin-top: 0.5rem;
            display: none;
            font-weight: 500;
        }

        /* Response Messages */
        h3 {
            text-align: center;
            color: #2c3e50;
            margin-top: 1rem;
        }
    </style>
    <script>
        function clearForm() {
            document.getElementById("uName").value = "";
            document.getElementById("fName").value = "";
            document.getElementById("lName").value = "";
            document.getElementById("email").value = "";
            document.getElementById("yearBorn").selectedIndex = 0;
            document.getElementById("city").selectedIndex = 0;
            document.getElementById("phone").value = "";
            document.getElementById("pw").value = "";
            document.getElementById("retypePassword").value = "";
            document.getElementById("prefix").selectedIndex = 0;

            var checkboxes = document.querySelectorAll('input[type="checkbox"]');
            checkboxes.forEach((checkbox) => {
                checkbox.checked = false;
            });

            document.getElementById("male").checked = false;
            document.getElementById("female").checked = false;

            var errors = document.querySelectorAll('.error');
            errors.forEach((error) => {
                error.style.display = 'none';
            });
        }

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
    <div class="form-container">
        <h1>Registration Form</h1>
        <form method="post" runat="server" onsubmit="return check();">
            <table class="form-table">
                <tr>
                    <td style="font-size: 30px;">Username:</td>
                    <td><input type="text" id="uName" name="uName" /></td>
                    <td><span id="mUName" class="error">Username is too short or does not exist</span></td>
                </tr>
                <tr>
                    <td style="font-size: 30px;">First Name:</td>
                    <td><input type="text" id="fName" name="fName" /></td>
                    <td><span id="mFName" class="error">First name is too short or does not exist</span></td>
                </tr>
                <tr>
                    <td style="font-size: 30px;">Last Name:</td>
                    <td><input type="text" id="lName" name="lName" /></td>
                    <td><span id="mLName" class="error">Last name is too short or does not exist</span></td>
                </tr>
                <tr>
                    <td style="font-size: 30px;">Email:</td>
                    <td><input type="text" id="email" name="email" /></td>
                    <td><span id="mEmail" class="error">Email is too short or does not exist</span></td>
                </tr>
                <tr>
                    <td style="font-size: 30px;">Gender:</td>
                    <td>
                        <input type="radio" id="male" name="gender" value="male"> Male
                        <input type="radio" id="female" name="gender" value="female"> Female
                    </td>
                </tr>
                <tr>
                    <td style="font-size: 30px;">Birth Year:</td>
                    <td>
                        <select id="yearBorn" name="yearBorn">
                            <script>
                                var currentYear = new Date().getFullYear();
                                for (var year = currentYear - 100; year <= currentYear; year++) {
                                    document.write('<option value="' + year + '">' + year + '</option>');
                                }
                            </script>
                        </select>
                        <span id="yearError" class="error">Invalid birth year</span>
                    </td>
                </tr>
                <tr>
                    <td style="font-size: 30px;">City:</td>
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
                        <span id="cityError" class="error">City is required</span>
                    </td>
                </tr>
                <tr>
                    <td style="font-size: 30px;">Phone Number:</td>
                    <td>
                        <select id="prefix" name="prefix" style="width: 20%;">
                            <option value="">05X</option>
                            <option value="050">050</option>
                            <option value="052">052</option>
                            <option value="053">053</option>
                            <option value="054">054</option>
                            <option value="055">055</option>
                            <option value="058">058</option>                    
                        </select>
                        <input type="text" id="phone" name="phone" placeholder="Enter the rest of the number" style="width: 75%;" />
                    </td>
                    <td><span id="phoneError" class="error">Invalid phone number</span></td>
                </tr>
                <tr>
                    <td style="font-size: 30px;">Hobbies:</td>
                    <td>
                        <input type="checkbox" id="computers" name="hobby" value="1"> Computers
                        <input type="checkbox" id="music" name="hobby" value="2"> Music
                        <input type="checkbox" id="movies" name="hobby" value="3"> Movies
                        <input type="checkbox" id="tv" name="hobby" value="4"> TV
                        <input type="checkbox" id="horses" name="hobby" value="5"> Horses
                    </td>
                </tr>
                <tr>
                    <td style="font-size: 30px;">Password:</td>
                    <td><input type="password" id="pw" name="pw" /></td>
                    <td><span id="passwordError" class="error">Password is required</span></td>
                </tr>
                <tr>
                    <td style="font-size: 30px;">Retype Password:</td>
                    <td><input type="password" id="retypePassword" name="retypePassword" /></td>
                    <td><span id="retypePasswordError" class="error">Passwords do not match</span></td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align: center;">
                        <input type="submit" name="submit" value="Sign Up" />
                        <input type="button" value="Clear" onclick="clearForm();" />
                    </td>
                </tr>
            </table>
        </form>
        <h3><%= sqlMsg %></h3>
        <h3><%= msg %></h3>
    </div>
</asp:Content>
