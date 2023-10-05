using Verduleria.Entities;

namespace Verduleria.Services.Implementations
{
    public class FruitService
    {
        static List<Fruit> Frutas { get; set; }
        static FruitService()
        {
            Frutas = new List<Fruit>
            {
                new Fruit { Id = 1, Name = "Orange", Description = "Tasty"},
                new Fruit { Id = 2, Name = "Pear", Description = "Not tasty" }
            };
        }

        public List<Fruit> SacarDelCajon()
        {
            return Frutas;
        }

        public Fruit ElegirFrutita(int id)
        {
            return Frutas.FirstOrDefault(fruta => fruta.Id == id);
        }
    }
}
