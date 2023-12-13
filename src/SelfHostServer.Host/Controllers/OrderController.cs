using SelfHostServer.Host.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHostServer.Host.Controllers
{
    public class OrderController : ApiController
    {
        Order[] Orders = new Order[]
        {
            new Order { Id = 1,Name= "Tomato soup" , Category="Groceries", Price=10},
            new Order { Id = 2,Name= "Yo yo" , Category="Toys", Price=2.67M},
            new Order { Id = 3,Name= "HDD" , Category="Hardware", Price=20.88M},
            new Order { Id = 4,Name= "StrongHold2" , Category="Game", Price=11.25M},
        };

        public IEnumerable<Order> GetAllOrders()
        {
            return Orders;
        }
    }
}
