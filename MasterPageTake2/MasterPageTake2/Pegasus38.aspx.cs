using System;

namespace MasterPageTake2
{
    public partial class Pegasus38 : System.Web.UI.Page
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
                        <img src='https://sneakernews.com/wp-content/uploads/2021/04/Nike-Pegasus-38-CW7356-003.jpg?w=1140' 
                             alt='Nike Air Zoom Pegasus 38' 
                             class='product-image'>
                    </div>
                    
                    <div class='product-info'>
                        <h1 class='product-title'>Nike Air Zoom Pegasus 38</h1>
                        <p>The road running icon returns with the Nike Air Zoom Pegasus 38. Stay on pace during your daily running routine with the same responsive cushioning that's been trusted by runners for nearly four decades.</p>
                        
                        <div class='product-price'>$120.00</div>
                        
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
                                <li>Nike React foam delivers responsive cushioning while keeping the shoe lightweight and durable</li>
                                <li>Zoom Air unit in the forefoot provides responsive cushioning and enhanced energy return</li>
                                <li>Engineered mesh upper offers targeted breathability and structured support</li>
                                <li>Wider forefoot provides more space for your toes</li>
                                <li>Midfoot webbing provides a secure fit when you tighten the laces</li>
                                <li>Traditional lacing system allows for customized fit</li>
                                <li>Weight: 10.0oz (men's size 10)</li>
                                <li>Drop: 10mm (heel: 24mm, forefoot: 14mm)</li>
                            </ul>
                        </div>
                    </div>
                </div>";
            }
        }
    }
}
