using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MasterPageTake2
{
    public partial class AdidasStore : System.Web.UI.Page
    {
        public string msg = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uName"].ToString() == "Guest")
            {
                msg += "<h3>";
                msg += "You are not signed in.";
                msg += "</br>";
                msg += "</h3>";
                msg += "<h3>";
                msg += "<a href = 'Login.aspx'>Log In</a>";
                msg += "</h3>";
                msg += "<h3>";
                msg += "<a href = 'SignUp.aspx'>Sign Up</a>";
            }
            else
            {
                msg = @"
    <div class='hero-section'>
        <h1>Adidas Shoes Collection</h1>
        <p>Step into innovation with Adidas shoes. From premium performance footwear to stylish everyday sneakers, our collection blends cutting-edge technology and iconic design for athletes and trendsetters alike.</p>
    </div>

    <h2 class='category-title'>Running Collection</h2>
    <div class='products-grid'>
        <a href='Ultraboost22.aspx' class='product-card'>
            <img src='https://www.roadrunningreview.com/Adidas-Ultraboost-22_1920_1_100990.jpg' alt='Adidas Ultraboost 22' class='product-image'>
            <div class='product-info'>
                <h3 class='product-name'>Adidas Ultraboost 22</h3>
                <p class='product-description'>Experience comfort and energy return with the Adidas Ultraboost 22, crafted for runners of all levels.</p>
                <div class='product-price'>$180</div>
            </div>
        </a>

        <a href='AdiosPro3.aspx' class='product-card'>
            <img src='https://assets.adidas.com/images/h_840,f_auto,q_auto,fl_lossy,c_fill,g_auto/b653adb58ab542b9bdcb928b2a9a4b28_9366/Adizero_Adios_Pro_3_Running_Shoes_Blue_IG3132_HM1.jpg' alt='Adidas Adizero Adios Pro 3' class='product-image'>
            <div class='product-info'>
                <h3 class='product-name'>Adidas Adizero Adios Pro 3</h3>
                <p class='product-description'>Engineered for speed, the Adizero Adios Pro 3 is designed to help you achieve your personal best.</p>
                <div class='product-price'>$220</div>
            </div>
        </a>

        <a href='SolarGlide.aspx' class='product-card'>
            <img src='https://assets.adidas.com/images/w_1880,f_auto,q_auto/6ab0b105497848768f286e024ca65125_9366/HP9813_HM3_hover.jpg' alt='Adidas Solar Glide' class='product-image'>
            <div class='product-info'>
                <h3 class='product-name'>Adidas Solar Glide</h3>
                <p class='product-description'>Reliable and comfortable, the Solar Glide is perfect for daily training and long-distance runs.</p>
                <div class='product-price'>$140</div>
            </div>
        </a>
    </div>

    <h2 class='category-title'>Basketball Collection</h2>
    <div class='products-grid'>
        <a href='HardenVol6.aspx' class='product-card'>
            <img src='https://sneakerbardetroit.com/wp-content/uploads/2021/11/adidas-Harden-Vol.-6-Black-White-GV8704-Release-Date-1068x668.jpeg' alt='Adidas Harden Vol. 6' class='product-image'>
            <div class='product-info'>
                <h3 class='product-name'>Adidas Harden Vol. 6</h3>
                <p class='product-description'>Built for the game’s most dynamic players, featuring responsive cushioning and exceptional grip.</p>
                <div class='product-price'>$140</div>
            </div>
        </a>

        <a href='Dame8.aspx' class='product-card'>
            <img src='https://sneakernews.com/wp-content/uploads/2021/12/adidas-dame-8-respect-my-name-release-date-2.jpg?w=1140' alt='Adidas Dame 8' class='product-image'>
            <div class='product-info'>
                <h3 class='product-name'>Adidas Dame 8</h3>
                <p class='product-description'>Dame 8 delivers explosive power and control, ideal for players who demand versatility.</p>
                <div class='product-price'>$120</div>
            </div>
        </a>

        <a href='TraeYoung1.aspx' class='product-card'>
            <img src='https://sneakerbardetroit.com/wp-content/uploads/2021/12/adidas-Trae-Young-1-Atlanta-Hawks-GY3772-Release-Date.jpg' alt='Adidas Trae Young 1' class='product-image'>
            <div class='product-info'>
                <h3 class='product-name'>Adidas Trae Young 1</h3>
                <p class='product-description'>Step up your game with Trae Young's first signature shoe, combining style and performance.</p>
                <div class='product-price'>$130</div>
            </div>
        </a>
    </div>";
            }
        }
    }
}
