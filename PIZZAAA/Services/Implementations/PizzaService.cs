using PIZZAAA.Entities;
using PIZZAAA.Services.Interfaces;
using System.Reflection.Metadata.Ecma335;

namespace PIZZAAA.Services.Implementations

{
    public class PizzaService : IPizzaService //Es implementacion no herencia :p
    {
        static List<Pizza> Pizzas { get; set; } //Una propiedad estatica que genera una lista de objetos de tipo pizza que se llama Pizzas
        static PizzaService()
        {
            Pizzas = new List<Pizza>
            {
                new Pizza { Id = 1, Name = "Classic Italian", IsGlutenFree = false },
                new Pizza { Id = 2, Name = "Veggie", IsGlutenFree = true }
            };
        }

        public List<Pizza> AllPizzas()
        {
            return Pizzas;
        }

        public Pizza? OnePizza(int id)
        {
            return Pizzas.FirstOrDefault(pizza => pizza.Id == id);
        }
    }
    //la logica de negocio
}
