using System;

namespace MasterPageTake2
{
    public partial class Lebron19 : System.Web.UI.Page
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
                        <img src='https://sneakernews.com/wp-content/uploads/2021/09/ike-lebron-19-black-red-DC9340-001-releases-date-1.jpg' 
                             alt='Nike LeBron 19' 
                             class='product-image'>
                    </div>
                    
                    <div class='product-info'>
                        <h1 class='product-title'>Nike LeBron 19</h1>
                        <p>Dominate the court like the King in the Nike LeBron 19. Built for the most powerful player in the game, this shoe combines explosive cushioning with dynamic containment to help you play with force while maintaining control.</p>
                        
                        <div class='product-price'>$200.00</div>
                        
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
                                <li>Dual-chamber Air Max unit delivers powerful cushioning and stability</li>
                                <li>Zoom Air units under the forefoot provide responsive energy return</li>
                                <li>Engineered upper combines lightweight Flywire cables with durable fabric</li>
                                <li>Molded TPU heel counter locks your foot in place</li>
                                <li>Reinforced toe area for enhanced durability during explosive movements</li>
                                <li>Multidirectional traction pattern for superior grip on any court surface</li>
                                <li>Padded collar provides comfortable ankle support</li>
                                <li>Weight: 14.5 oz (men's size 10)</li>
                                <li>Designed for indoor and outdoor basketball courts</li>
                                <li>Signature LeBron details and branding throughout</li>
                            </ul>
                        </div>
                    </div>
                </div>";
            }
        }
    }
}
