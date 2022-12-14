using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YlvasKaffelager.DataModels;
using YlvasKaffelager.ViewModels;

namespace YlvasKaffelager.Controllers
{
    public class OrdersController : Controller
    {
        public DbContext _dbContext { get; set; }
        public int NumberOfOrders { get; set; }

        private Calculator _calculator;

        public OrdersController()
        {
            _dbContext = new DbContext();

            NumberOfOrders = 0;
            _calculator = new Calculator();
        }
        public IActionResult Index()
        {
            var model = new OrderViewModel();
            
            return View(model);
        }

        [HttpPost]
        public IActionResult Orders(OrderViewModel model)
        {
            var coffee = _dbContext.GetCoffe(model.CoffeeId);
            
            int amount = model.Amount;

            var viewModel = new ViewOrderModel
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Brand = coffee.Brand,
                Amount = amount,
                Total = _calculator.GetTotal(amount, coffee.Price)
            };

            return View("ViewOrder", viewModel);
        }

        public IActionResult ViewOrder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Confirm(ViewOrderModel model)
        {
            NumberOfOrders++;

            var order = new Order
            {
                Id = NumberOfOrders,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Brand = model.Brand,
                Amount= model.Amount,
                Total = model.Total,
            };

            _dbContext.AddOrder(order);

            return View("Completed");
        }

        public IActionResult Completed()
        {
            return View();
        }
    }
}