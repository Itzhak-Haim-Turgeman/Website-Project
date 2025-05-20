using System;

namespace MasterPageTake2
{
    public partial class AdiosPro3 : System.Web.UI.Page
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
                        <img src='https://assets.adidas.com/images/h_840,f_auto,q_auto,fl_lossy,c_fill,g_auto/b653adb58ab542b9bdcb928b2a9a4b28_9366/Adizero_Adios_Pro_3_Running_Shoes_Blue_IG3132_HM1.jpg' 
                             alt='Adidas Adizero Adios Pro 3' 
                             class='product-image'>
                    </div>
                    
                    <div class='product-info'>
                        <h1 class='product-title'>Adidas Adizero Adios Pro 3</h1>
                        <p>The Adidas Adizero Adios Pro 3 is built for speed and long-distance running. Designed with world-class racing technology, it features ENERGYRODS 2.0 and Lightstrike Pro foam for peak performance.</p>
                        
                        <div class='product-price'>$250.00</div>
                        
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
                                <li>ENERGYRODS 2.0 for improved stability and forward propulsion</li>
                                <li>Lightstrike Pro foam for lightweight cushioning and energy return</li>
                                <li>Continental™ Rubber outsole for reliable grip</li>
                                <li>Breathable engineered mesh upper for optimal ventilation</li>
                                <li>Designed for marathon racing and high-speed training</li>
                                <li>Weight: 7.9oz (men's size 9)</li>
                                <li>Drop: 6.5mm (heel: 39mm, forefoot: 32.5mm)</li>
                            </ul>
                        </div>
                    </div>
                </div>";
            }
        }
    }
}
