using System;

namespace MasterPageTake2
{
    public partial class InfinityRun3 : System.Web.UI.Page
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
                        <img src='https://believeintherun.com/wp-content/uploads/2022/05/nike-react-infinity-run-flyknit-3-cover.jpg' 
                             alt='Nike React Infinity Run Flyknit 3' 
                             class='product-image'>
                    </div>
                    
                    <div class='product-info'>
                        <h1 class='product-title'>Nike React Infinity Run Flyknit 3</h1>
                        <p>Keep running with confidence in the Nike React Infinity Run Flyknit 3. Designed to help reduce injury and keep you going, this shoe provides a smooth ride for every mile. Whether you're a seasoned runner or just starting out, experience the perfect blend of comfort and support.</p>
                        
                        <div class='product-price'>$160.00</div>
                        
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
                                <li>Nike React foam provides a smooth, responsive ride with enhanced cushioning</li>
                                <li>Improved Flyknit upper with better ventilation in high-heat areas</li>
                                <li>Wider base for enhanced stability during your run</li>
                                <li>Rocker geometry promotes smooth heel-to-toe transitions</li>
                                <li>Reinforced heel clip helps keep your foot secure</li>
                                <li>Higher foam stack heights provide soft cushioning</li>
                                <li>Redesigned rubber outsole pattern for improved traction</li>
                                <li>Weight: 9.8 oz (men's size 10)</li>
                                <li>Drop: 8.4mm (heel: 33.3mm, forefoot: 24.9mm)</li>
                            </ul>
                        </div>
                    </div>
                </div>";
            }
        }
    }
}
