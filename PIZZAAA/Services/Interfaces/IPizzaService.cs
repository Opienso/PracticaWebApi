using PIZZAAA.Entities;

namespace PIZZAAA.Services.Interfaces
{
    public interface IPizzaService
    {
        List<Pizza> AllPizzas(); //no va public
        Pizza OnePizza(int id);

    }
    //UN CONTRATO
}
