
using Microsoft.AspNetCore.Mvc;
using SimplCommerce.Module.Orders.Services;

namespace StormyCommerce.Module.Orders.Controllers
{
    public class StormyOrderController : Controller
    {
        private readonly IOrderService _orderService;        
        public StormyOrderController()
        {
            
        }        
    }   
}
