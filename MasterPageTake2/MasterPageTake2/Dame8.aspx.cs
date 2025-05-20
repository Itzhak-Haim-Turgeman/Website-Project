using System;
using System.Data;

namespace MasterPageTake2
{
    public partial class Dame8 : System.Web.UI.Page
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
                        <img src='https://sneakernews.com/wp-content/uploads/2021/12/adidas-dame-8-respect-my-name-release-date-2.jpg?w=1140' 
                             alt='Dame 8 Basketball Shoes' 
                             class='product-image'>
                    </div>
                    
                    <div class='product-info'>
                        <h1 class='product-title'>Adidas Dame 8</h1>
                        <p>The Adidas Dame 8 is designed for explosive gameplay and unmatched style on the court. Featuring advanced cushioning and traction technology, these shoes are built for Damian Lillard’s unstoppable game.</p>
                        
                        <div class='product-price'>$130.00</div>
                        
                        <div class='size-selection'>
                            <h3>Select Size:</h3>
                            <div class='size-grid'>";

                string[] sizes = { "6", "6.5", "7", "7.5", "8", "8.5", "9", "9.5", "10", "10.5", "11" };
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
                                <li>Lightstrike cushioning for explosive movements</li>
                                <li>Durable outsole for enhanced traction</li>
                                <li>Breathable upper for comfort during play</li>
                                <li>Eco-friendly materials</li>
                                <li>Signature Damian Lillard detailing</li>
                            </ul>
                        </div>
                    </div>
                </div>";
            }
        }
    }
}
