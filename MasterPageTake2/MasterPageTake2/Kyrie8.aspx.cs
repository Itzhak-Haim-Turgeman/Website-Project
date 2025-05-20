using System;

namespace MasterPageTake2
{
    public partial class Kyrie8 : System.Web.UI.Page
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
                        <img src='https://sneakerbardetroit.com/wp-content/uploads/2021/08/Nike-Kyrie-8-DC9134-001-Release-Date-4.jpeg' 
                             alt='Nike Kyrie 8' 
                             class='product-image'>
                    </div>
                    
                    <div class='product-info'>
                        <h1 class='product-title'>Nike Kyrie 8</h1>
                        <p>The Nike Kyrie 8 is designed to keep up with your game on the court. Offering lightweight construction, a locked-in fit, and the speed to dominate, this shoe is made for agility and precision.</p>
                        
                        <div class='product-price'>$150.00</div>
                        
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
                                <li>Lightweight upper for quick movements</li>
                                <li>Full-length Zoom Air cushioning for responsiveness</li>
                                <li>Secure fit with Flytrap overlay system</li>
                                <li>Rubber outsole with multidirectional traction</li>
                                <li>Padded collar for ankle comfort</li>
                                <li>Signature Kyrie branding</li>
                                <li>Designed for quick cuts and agility on the court</li>
                            </ul>
                        </div>
                    </div>
                </div>";
            }
        }
    }
}
