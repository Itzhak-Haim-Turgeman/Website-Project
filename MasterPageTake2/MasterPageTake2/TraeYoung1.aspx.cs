using System;
using System.Data;

namespace MasterPageTake2
{
    public partial class TraeYoung1 : System.Web.UI.Page
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
                        <img src='https://sneakerbardetroit.com/wp-content/uploads/2021/12/adidas-Trae-Young-1-Atlanta-Hawks-GY3772-Release-Date.jpg' 
                             alt='Adidas Trae Young 1 Basketball Shoes' 
                             class='product-image'>
                    </div>
                    
                    <div class='product-info'>
                        <h1 class='product-title'>Adidas Trae Young 1</h1>
                        <p>The Adidas Trae Young 1 brings together bold style and ultimate comfort. Designed for the dynamic gameplay of Trae Young, these shoes feature responsive cushioning and exceptional grip.</p>
                        
                        <div class='product-price'>$140.00</div>
                        
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
                                <li>Adaptive fit for enhanced support</li>
                                <li>Durable outsole for reliable grip</li>
                                <li>Breathable materials for all-day comfort</li>
                                <li>Signature Trae Young details</li>
                            </ul>
                        </div>
                    </div>
                </div>";
            }
        }
    }
}
