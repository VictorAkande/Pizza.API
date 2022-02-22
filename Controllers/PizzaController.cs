using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pizza.API.Models;
using Pizza.API.Services;

namespace Pizza.API.Controllers
{
#pragma warning disable CS1591
    [Route("api/pizza")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        public PizzaController()
        {

        }

        /// <summary>
        /// To get list of Pizza
        /// </summary>
        /// <returns>List of Pizza</returns>

        // GET all action
        [HttpGet()]
        public ActionResult<List<Pizzas>> GetAll() => PizzaService.GetAll();

        //GET by Id action

        [HttpGet()]
        [Route("{Id}")]

        public ActionResult<Pizzas> Get(int Id)
        {
            var pizza = PizzaService.Get(Id);

            if (pizza == null)
                return NotFound();
            return Ok(pizza);
        }

        
        //POST action

        //[HttpPost("{Id}")]
        //public ActionResult

        //PUT action

        //DELETE action
    }
}
