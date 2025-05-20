using System;

namespace MasterPageTake2
{
    public partial class Ultraboost22 : System.Web.UI.Page
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
                        <img src='https://www.roadrunningreview.com/Adidas-Ultraboost-22_1920_1_100990.jpg' 
                             alt='Adidas Ultraboost 22' 
                             class='product-image'>
                    </div>
                    
                    <div class='product-info'>
                        <h1 class='product-title'>Adidas Ultraboost 22</h1>
                        <p>The Adidas Ultraboost 22 is designed for runners of all levels. It features a Boost midsole for unmatched energy return and cushioning, along with a Primeknit upper for a snug, sock-like fit.</p>
                        
                        <div class='product-price'>$180.00</div>
                        
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
                                <li>Boost midsole technology for exceptional energy return</li>
                                <li>Primeknit upper for a snug, sock-like fit</li>
                                <li>Continental™ Rubber outsole for superior traction</li>
                                <li>Sustainably made with Primeblue, a high-performance recycled material</li>
                                <li>Enhanced heel counter for added support</li>
                                <li>Weight: 10.9oz (men's size 9)</li>
                                <li>Drop: 10mm (heel: 22mm, forefoot: 12mm)</li>
                            </ul>
                        </div>
                    </div>
                </div>";
            }
        }
    }
}
