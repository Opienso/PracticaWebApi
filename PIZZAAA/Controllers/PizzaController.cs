using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PIZZAAA.Entities;
using PIZZAAA.Services.Interfaces;

namespace PIZZAAA.Controllers
{
    [Route("api/[controller]")] //ESTO TE LO DA API
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly IPizzaService _pizzaService; //primer paso
        //le inyectamos al objeto la interfaz, y entonces a partir de ese objeto podemos usar todos los metodos
        //que estan en la interfaz
        public PizzaController(IPizzaService pizzaService) //segundo paso
        {
            _pizzaService = pizzaService;
        }



        //ENDPOINT
        [HttpGet]
        public IActionResult AllPizzas()
        {
            return Ok(_pizzaService.AllPizzas());
        }

        [HttpGet("caca")]
        public IActionResult OnePizza(int id)
        {
            Pizza? pizza = _pizzaService.OnePizza(id);

            if (pizza == null)
            {
                return BadRequest("no se encontro pibe");
            }

            return Ok(pizza);
        }

    }
}
