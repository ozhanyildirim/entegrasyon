using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cart_app.Models
{
    public class ProductModel
    {
        public List<Product> FindAll()
        {
            return new List<Product>
            {
                new Product
                {
                    Id="p01",
                    Name="Kinetix",
                    Price="10.99",
                    Currency = "EUR" ,
                    Title = "Anchor Mesh",
                    Photo="https://www.carikcim.com/bagcikli-bayan-spor-ayakkabi-gri-yesil-paxton-30625-22-B.jpg"
                },
                new Product
                {
                    Id="p02",
                    Name="Sketchers",
                    Price="50",
                    Currency = "EUR" ,
                      Title = "Go Walk Joy",
                    Photo ="https://www.sariyildizspor.com/UserFiles/ProductImages/0/232291gry/orj/skechers-skech-air-dynamight-tuned-up-spor-ayakkabi-gri-123451.jpg"
                },
                new Product
                {
                    Id="p03",
                    Name="Nike",
                    Price="550",
                    Currency = "EUR" ,
                      Title = "Air Zoom 2090",
                    Photo="https://www.bestofayakkabi.com/images/large/bestofayakkabi/Nike%20Erkek%20Spor%20Ayakkab%20Air%20Zoom%20Peg%202171_ZOOM.jpg"
                }
            };
        }


    }
}


