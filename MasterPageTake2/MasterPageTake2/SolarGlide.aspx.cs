using System;

namespace MasterPageTake2
{
    public partial class SolarGlide : System.Web.UI.Page
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
                        <img src='https://assets.adidas.com/images/w_1880,f_auto,q_auto/6ab0b105497848768f286e024ca65125_9366/HP9813_HM3_hover.jpg' 
                             alt='Adidas Solar Glide' 
                             class='product-image'>
                    </div>
                    
                    <div class='product-info'>
                        <h1 class='product-title'>Adidas Solar Glide</h1>
                        <p>Experience ultimate comfort and durability with the Adidas Solar Glide, designed for long-distance running and everyday use. Perfect for runners who want responsive cushioning and a smooth ride.</p>
                        
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
                                <li>Boost midsole for energy return and comfort</li>
                                <li>Primegreen upper made with recycled materials</li>
                                <li>Stretchweb outsole for natural flexibility</li>
                                <li>Continental™ Rubber for exceptional grip</li>
                                <li>Weight: 11.2oz (men's size 9)</li>
                                <li>Drop: 10mm (heel: 32mm, forefoot: 22mm)</li>
                                <li>Breathable mesh for optimal airflow</li>
                            </ul>
                        </div>
                    </div>
                </div>";
            }
        }
    }
}
