using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PizzariaMVC.Services.Pizza;
using System.Diagnostics;

namespace PizzariaMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPizzaInterface _pizzaInterface;

        public HomeController(IPizzaInterface pizzaInterface)
        {
            _pizzaInterface = pizzaInterface;
        }
        public async Task<IActionResult> Index(string? pesquisar)
        {
            if(pesquisar == null)
            {
                var pizzas = await _pizzaInterface.GetPizza();
                return View(pizzas);
            }
            else
            {
                var pizzas = await _pizzaInterface.GetPizzasFiltro(pesquisar);
                return View(pizzas);
            }

        }
    }
}
