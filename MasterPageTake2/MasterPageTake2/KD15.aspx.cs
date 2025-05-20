using System;

namespace MasterPageTake2
{
    public partial class KD15 : System.Web.UI.Page
    {
        public string msg = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uName"] == null || Session["uName"].ToString() == "Guest")
            {
                msg += "<h3>";
                msg += "You are not signed in.";
                msg += "</br>";
                msg += "</h3>";
                msg += "<h3>";
                msg += "<a href='Login.aspx'>Log In</a>";
                msg += "</h3>";
                msg += "<h3>";
                msg += "<a href='SignUp.aspx'>Sign Up</a>";
                msg += "</h3>";
            }
            else
            {
                msg = @"
                <div class='product-details'>
                    <div class='product-image-section'>
                        <img src='https://staticg.sportskeeda.com/editor/2023/03/cb58a-16801582508927-1920.jpg' 
                             alt='Nike KD 15' 
                             class='product-image'>
                    </div>
                    
                    <div class='product-info'>
                        <h1 class='product-title'>Nike KD 15</h1>
                        <p>Step onto the court with precision and performance in the Nike KD 15. Designed for one of the game’s most versatile scorers, this shoe provides unparalleled comfort, responsiveness, and support for your every move.</p>
                        
                        <div class='product-price'>$160.00</div>
                        
                        <div class='size-selection'>
                            <h3>Select Size:</h3>
                            <div class='size-grid'>";

                string[] sizes = { "7", "7.5", "8", "8.5", "9", "9.5", "10", "10.5", "11", "11.5", "12", "12.5", "13", "14", "15" };
                foreach (string size in sizes)
                {
                    msg += $"<button type='button' class='size-button' onclick='selectSize(\"{size}\")'>{size}</button>";
                }

                msg += @"
                            </div>
                        </div>

                        <button type='button' class='add-to-cart'>Add to Cart</button>
                        
                        <div class='product-features'>
                            <h3>Product Features:</h3>
                            <ul class='features-list'>
                                <li>Full-length Zoom Air cushioning for unmatched comfort</li>
                                <li>Lightweight, breathable mesh upper</li>
                                <li>Advanced Flywire cables for dynamic lockdown</li>
                                <li>Durable rubber outsole with enhanced traction pattern</li>
                                <li>Signature KD branding and design details</li>
                                <li>Perfect for indoor and outdoor basketball courts</li>
                            </ul>
                        </div>
                    </div>
                </div>";
            }
        }
    }
}
