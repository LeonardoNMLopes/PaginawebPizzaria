using PizzariaMVC.Dto;
using PizzariaMVC.Models;

namespace PizzariaMVC.Services.Pizza
{
    public interface IPizzaInterface
    {
        Task<PizzaModel>CriarPizza(PizzaCriacaoDto pizzaCriacaoDto, IFormFile foto);
        Task<List<PizzaModel>> GetPizza();
        Task<PizzaModel> GetPizzaPorId(int id);
        Task<PizzaModel> EditarPizza(PizzaModel pizza, IFormFile? foto);
        Task<PizzaModel> RemoverPizza(int id);
        Task<List<PizzaModel>> GetPizzasFiltro(string? pesquisar);
    }
}
