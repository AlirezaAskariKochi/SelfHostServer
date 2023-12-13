using SelfHostServer.Host.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHostServer.Host.Controllers
{
    public class ProductController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product{Id=1, Name="Product 1"},
            new Product{Id=2, Name="Product 2"},
            new Product{Id=3, Name="Product 3"},
            new Product{Id=4, Name="Product 4"}
        };

        [HttpGet]
        public IEnumerable<Product> All()
        {
            return products;
        }
    }
}
