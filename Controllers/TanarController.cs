using Microsoft.AspNetCore.Mvc;
using Takács_Krisztián_backend.Repositories.Interfaces;

namespace Takács_Krisztián_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TanarController : ControllerBase
    {
        private readonly ITanarInterface tanarInterface;

        public TanarController(ITanarInterface tanarInterface)
        {
            this.tanarInterface = tanarInterface;
        }

        [HttpPost("tanar")]
        public async Task<ActionResult<TanarDto>> Post(CreateTanarDto createTanarDto)
        {
            return StatusCode(200, await tanarInterface.Post(createTanarDto));
        }

        [HttpGet("alltanar")]
        public async Task<IEnumerable<Tanarok>> Get()
        {
            return await tanarInterface.GetAll();
        }

        [HttpGet("tanarbyid/{id}")]
        public async Task<ActionResult<Tanarok>> GetById(int id)
        {
            var eredmeny = await tanarInterface.GetById(id);
            if (eredmeny == null)
            {
                return StatusCode(400, "Error");
            }

            return StatusCode(200, eredmeny);
        }

        [HttpPut("updatebyid/{id}")]
        public async Task<ActionResult<Tanarok>> Put(int id, ModifyTanarDto modifyTanarDto)
        {
            var eredmeny = await tanarInterface.Put(id, modifyTanarDto);

            if (eredmeny == null)
            {
                return StatusCode(400, "Error");
            }

            return StatusCode(200, eredmeny);
        }

        [HttpDelete("deletebyid/{id}")]
        public async Task<ActionResult<Tanarok>> DeleteById(int id)
        {
            var eredmeny = await tanarInterface.DeleteById(id);

            if (eredmeny == null)
            {
                return StatusCode(400, "Error");
            }

            return StatusCode(200, eredmeny);
        }
    }
}
