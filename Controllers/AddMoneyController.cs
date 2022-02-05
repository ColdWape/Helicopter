using Helicopter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Helicopter.Controllers
{
    public class AddMoneyController : Controller
    {
        private readonly DataContext _dataContext;


        public AddMoneyController(DataContext dataContext)
        {
            _dataContext = dataContext;

        }

        [HttpGet]
        public IActionResult Money()
        {
            ViewBag.Person = _dataContext.Users;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Money(BalanceModel model)
        {
            if (ModelState.IsValid)
            {
                UserModel user = await _dataContext.Users.FirstOrDefaultAsync(u => u.Email == User.Identity.Name);

                user.Balance += model.Quantity;

                _dataContext.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            else
            {
                ModelState.AddModelError("", "Проверьте правильность заполненных полей!");
            }
            ViewBag.Person = _dataContext.Users;

            return View(model);


        }
    }
}
