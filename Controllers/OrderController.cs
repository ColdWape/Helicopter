using Helicopter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helicopter.Controllers
{
    public class OrderController : Controller
    {
        private readonly DataContext _dataContext;


        public OrderController(DataContext dataContext)
        {
            _dataContext = dataContext;

        }


        [HttpGet]
        public IActionResult ShowOrder(int inputId, int quantity)
        {
            ViewBag.Person = _dataContext.Users;

            ViewBag.Item = _dataContext.Vehicles.FirstOrDefault(v => v.Id == inputId);
            ViewBag.Quantity = quantity;
            ViewBag.Summ = quantity * ViewBag.Item.Price;
            return View();
        }
        [HttpGet]
        public IActionResult Success()
        {
            ViewBag.Person = _dataContext.Users;

            return View();
        }
        [HttpGet]
        public IActionResult NoMoney()
        {
            ViewBag.Person = _dataContext.Users;

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ShowOrder(int money)
        {
            
                UserModel user = await _dataContext.Users.FirstOrDefaultAsync(u => u.Email == User.Identity.Name);
                if (user.Balance - money < 0)
                {
                    return RedirectToAction("NoMoney", "Order");
                }
                else
                {
                    user.Balance -= money;
                    _dataContext.SaveChanges();
                    return RedirectToAction("Success", "Order");
                }
            
            
        }

    }
}
