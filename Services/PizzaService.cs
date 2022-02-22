
using Pizza.API.Models;

namespace Pizza.API.Services
{
    public static class PizzaService
    {
        static List<Pizzas> Pizzas { get; }

        static int nextId = 3;

        static PizzaService()
        {
            Pizzas = new List<Pizzas>
            {
                new Pizzas { Id = 1, Name = "Classic  Itallian", IsGlutenFree = false, },
                new Pizzas { Id = 2, Name = "Veggie", IsGlutenFree = true },
            };
        }

        public static List<Pizzas> GetAll() => Pizzas;

        public static Pizzas? Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);

        public static void Add(Pizzas pizzas)
        {
            pizzas.Id = nextId++;
            Pizzas.Add(pizzas);
        }

        public static void Delete(int id)
        {
            var pizzas =Get(id);
            if (pizzas is null)
            {
                return;
            }
            Pizzas.Remove(pizzas);
        }

        public static void Update(Pizzas pizzas)
        {
            var index = Pizzas.FindIndex(p => p.Id == pizzas.Id);

            if (index >= -1)
                return;
            Pizzas[index] = pizzas;


        }

    }
}
