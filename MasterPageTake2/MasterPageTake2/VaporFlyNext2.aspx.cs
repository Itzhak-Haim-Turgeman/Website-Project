using System;

namespace MasterPageTake2
{
    public partial class VaporFlyNext2 : System.Web.UI.Page
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
                        <img src='https://sneakernews.com/wp-content/uploads/2021/05/Nike-ZoomX-Vaporfly-NEXT-2-CU4111-700-6.jpg' 
                             alt='Nike ZoomX Vaporfly NEXT% 2' 
                             class='product-image'>
                    </div>
                    
                    <div class='product-info'>
                        <h1 class='product-title'>Nike ZoomX Vaporfly NEXT% 2</h1>
                        <p>Break records and push your limits with the Nike ZoomX Vaporfly NEXT% 2. Built for elite performance and record-breaking speed, this revolutionary racing shoe combines cutting-edge technology with lightweight design.</p>
                        
                        <div class='product-price'>$250.00</div>
                        
                        <div class='size-selection'>
                            <h3>Select Size:</h3>
                            <div class='size-grid'>";

                string[] sizes = { "7", "7.5", "8", "8.5", "9", "9.5", "10", "10.5", "11", "11.5", "12" };
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
                                <li>Full-length carbon fiber plate delivers a propulsive sensation for unparalleled energy return</li>
                                <li>ZoomX foam provides Nike's most responsive cushioning for maximum speed and energy return</li>
                                <li>Engineered mesh upper with reinforced elements for enhanced breathability and support</li>
                                <li>Redesigned heel shape provides enhanced comfort and support for Achilles tendon</li>
                                <li>Wider forefoot for improved stability during toe-off</li>
                                <li>Internal foam pods in the tongue for secure fit</li>
                                <li>Weight: 6.9 oz (men's size 10)</li>
                                <li>Drop: 8mm (heel: 40mm, forefoot: 32mm)</li>
                                <li>World Athletics approved for competition use</li>
                            </ul>
                        </div>
                    </div>
                </div>";
            }
        }
    }
}
