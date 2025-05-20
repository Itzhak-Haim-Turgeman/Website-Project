using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MasterPageTake2
{
    public partial class HardenVol6 : System.Web.UI.Page
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
                        <img src='https://sneakerbardetroit.com/wp-content/uploads/2021/11/adidas-Harden-Vol.-6-Black-White-GV8704-Release-Date-1068x668.jpeg' 
                             alt='Harden Vol. 6 Basketball Shoes' 
                             class='product-image'>
                    </div>
                    
                    <div class='product-info'>
                        <h1 class='product-title'>Adidas Harden Vol. 6</h1>
                        <p>The Adidas Harden Vol. 6 delivers the perfect balance of performance and style. Designed for James Harden's signature moves, these basketball shoes feature BOOST technology and a unique traction pattern for on-court excellence.</p>
                        
                        <div class='product-price'>$150.00</div>
                        
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
                                <li>BOOST midsole for exceptional energy return</li>
                                <li>Herringbone traction pattern for superior grip</li>
                                <li>Durable rubber outsole for long-lasting performance</li>
                                <li>Padded collar for ankle support and comfort</li>
                                <li>Lightweight and breathable upper</li>
                                <li>Signature Harden detailing</li>
                                <li>Designed for dynamic play and quick movements</li>
                            </ul>
                        </div>
                    </div>
                </div>";
            }
        }
    }
}