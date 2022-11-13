using Microsoft.AspNetCore.Mvc;

using System.ComponentModel.DataAnnotations;

namespace Algo.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            List<ProductList> model = new List<ProductList>
            {
                new ProductList {
                    Product = new Product
                    {
                        Id = 1,
                        Name = "ПТК «ТИСАМ»",
                        Description = "Современная высокотехнологичная платформа IIoT объединяющая в себе решения по мониторингу состояния, " +
                        "диагностике и оптимизации систем разного типа и уровней сложности.",
                    },
                    SubProducts = new List<Product>
                    {
                        new Product
                        {
                             Id = 1,
                        Name = "Устройство измерения: А-УИ-1РЛ",
                        Description = "Современная высокотехнологичная платформа IIoT объединяющая в себе решения по мониторингу состояния, " +
                        "диагностике и оптимизации систем разного типа и уровней сложности.",
                        },
                        new Product
                        {
                             Id = 1,
                        Name = "Устройство измерения: А-УИ-1ПС",
                        Description = "Современная высокотехнологичная платформа IIoT объединяющая в себе решения по мониторингу состояния, " +
                        "диагностике и оптимизации систем разного типа и уровней сложности.",
                        },
                    }
                },
                new ProductList {
                    Product = new Product
                    {
                        Id = 1,
                        Name = "ПТК «Горизонт»",
                        Description = "Современная высокотехнологичная платформа IIoT объединяющая в себе решения по мониторингу состояния, " +
                        "диагностике и оптимизации систем разного типа и уровней сложности.",
                    },
                }
            };
            return View(model);
        }

        public IActionResult ProductInfo()
        {
            return View();
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgURL { get; set; }
    }

    public class ProductList
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public List<Product> SubProducts { get; set; }
    }
}
