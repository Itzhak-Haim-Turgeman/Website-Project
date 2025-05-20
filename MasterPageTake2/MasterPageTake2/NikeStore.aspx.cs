using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MasterPageTake2
{
    public partial class NikeStore : System.Web.UI.Page
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
                    <h1>Nike Shoes Collection</h1>
                    <p>Discover Nike's innovative footwear collection, crafted with cutting-edge technology and designed for peak performance. From iconic Air technology to responsive Zoom cushioning, each pair embodies decades of athletic excellence and style innovation.</p>
                </div>

                <h2 class='category-title'>Running Collection</h2>
                <div class='products-grid'>
                    <a href='Pegasus38.aspx' class='product-card'>
                        <img src='https://sneakernews.com/wp-content/uploads/2021/04/Nike-Pegasus-38-CW7356-003.jpg?w=1140' alt='Nike Air Zoom Pegasus 38' class='product-image'>
                        <div class='product-info'>
                            <h3 class='product-name'>Nike Air Zoom Pegasus 38</h3>
                            <p class='product-description'>The road running icon returns with the Nike Air Zoom Pegasus 38. More lightweight and responsive than ever, perfect for your daily runs.</p>
                            <div class='product-price'>$120</div>
                        </div>
                    </a>

                    <a href='VaporFlyNext2.aspx' class='product-card'>
                        <img src='https://sneakernews.com/wp-content/uploads/2021/05/Nike-ZoomX-Vaporfly-NEXT-2-CU4111-700-6.jpg?w=1140' alt='Nike ZoomX Vaporfly' class='product-image'>
                        <div class='product-info'>
                            <h3 class='product-name'>Nike ZoomX Vaporfly NEXT% 2</h3>
                            <p class='product-description'>The racing shoe designed to help you chase new records. Features ZoomX foam and a full-length carbon fiber plate.</p>
                            <div class='product-price'>$250</div>
                        </div>
                    </a>

                    <a href='InfinityRun3.aspx' class='product-card'>
                        <img src='https://believeintherun.com/wp-content/uploads/2022/05/nike-react-infinity-run-flyknit-3-cover.jpg' alt='Nike React Infinity Run' class='product-image'>
                        <div class='product-info'>
                            <h3 class='product-name'>Nike React Infinity Run Flyknit 3</h3>
                            <p class='product-description'>Designed to help reduce injury and keep you running. Features React foam and a wider forefoot for stability.</p>
                            <div class='product-price'>$160</div>
                        </div>
                    </a>
                </div>

                <h2 class='category-title'>Basketball Collection</h2>
                <div class='products-grid'>
                    <a href='Lebron19.aspx' class='product-card'>
                        <img src='https://sneakernews.com/wp-content/uploads/2021/09/ike-lebron-19-black-red-DC9340-001-releases-date-1.jpg' alt='Nike LeBron 19' class='product-image'>
                        <div class='product-info'>
                            <h3 class='product-name'>Nike LeBron 19</h3>
                            <p class='product-description'>Built for the King. Features a dual-chamber Air Max unit and Zoom Air cushioning for explosive power and speed.</p>
                            <div class='product-price'>$200</div>
                        </div>
                    </a>

                    <a href='Kyrie8.aspx' class='product-card'>
                        <img src='https://sneakerbardetroit.com/wp-content/uploads/2021/08/Nike-Kyrie-8-DC9134-001-Release-Date-4.jpeg' alt='Nike Kyrie 8' class='product-image'>
                        <div class='product-info'>
                            <h3 class='product-name'>Nike Kyrie 8</h3>
                            <p class='product-description'>Designed for quick cuts and creative play. Features responsive cushioning and multidirectional traction.</p>
                            <div class='product-price'>$140</div>
                        </div>
                    </a>

                    <a href='KD15.aspx' class='product-card'>
                        <img src='https://staticg.sportskeeda.com/editor/2023/03/cb58a-16801582508927-1920.jpg' alt='Nike KD 15' class='product-image'>
                        <div class='product-info'>
                            <h3 class='product-name'>Nike KD 15</h3>
                            <p class='product-description'>Built for versatility and scoring from anywhere. Features a full-length Air Zoom Strobel for responsive cushioning.</p>
                            <div class='product-price'>$150</div>
                        </div>
                    </a>
                </div>";
            }
        }
    }
}