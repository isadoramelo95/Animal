using Domain;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;


namespace AnimalAPI1.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AnimaisController : ControllerBase
    {
        IAnimalService<Animal> _services;

        public AnimaisController(IAnimalService<Animal> services)
        {
            _services = services;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Animal>> Get(int id)
        {
            try
            {
                return _services.ObterTodos(id); ;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost("EmitirSom")]
        public ActionResult<string> EmitirSom([FromBody] Gato gato)
        {
            try
            {
                return gato.EmitirSom();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        public IActionResult Post([FromBody] Animal animal)
        {
            try
            {
                _services.Inserir(animal);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut()]
        public IActionResult Put([FromBody] Animal animal)
        {
            try
            {
                _services.Atualizar(animal);
                return Ok("Atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete()]
        public IActionResult Delete([FromBody] Animal animal)
        {
            try
            {
                _services.Remover(animal);
                return Ok("Removido com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}