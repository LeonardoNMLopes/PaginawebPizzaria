using Microsoft.AspNetCore.Authorization;
using System.Reflection.Metadata.Ecma335;

namespace PizzariaMVC.Models
{
    public class PizzaModel
    {
        public int Id { get; set; }
        public string Sabor { get; set; } = string.Empty;
        public string capa { get; set; } = string.Empty;
        public string Descricao { get; set;} = string.Empty;
        public double Valor { get; set; }


    }
}
