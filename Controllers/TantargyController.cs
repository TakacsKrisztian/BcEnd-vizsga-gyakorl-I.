using Microsoft.AspNetCore.Mvc;

namespace Takács_Krisztián_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TantargyController : ControllerBase
    {
        private readonly ITantargyInterface tantargyInterface;

        public TantargyController(ITantargyInterface tantargyInterface)
        {
            this.tantargyInterface = tantargyInterface;
        }

        [HttpPost("tantargy")]
        public async Task<ActionResult<TantargyDto>> Post(CreateTantargyDto createTantargyDto)
        {
            return StatusCode(200, await tantargyInterface.Post(createTantargyDto));
        }

        [HttpGet("alltantargy")]
        public async Task<IEnumerable<Tantargyak>> Get()
        {
            return await tantargyInterface.GetAll();
        }

        [HttpGet("tantargybyid/{id}")]
        public async Task<ActionResult<Tantargyak>> GetById(int id)
        {
            var eredmeny = await tantargyInterface.GetById(id);
            if (eredmeny == null)
            {
                return StatusCode(400, "Error");
            }

            return StatusCode(200, eredmeny);
        }

        [HttpPut("updatebyid/{id}")]
        public async Task<ActionResult<Tantargyak>> Put(int id, ModifyTantargyDto modifyTantargyDto)
        {
            var eredmeny = await tantargyInterface.Put(id, modifyTantargyDto);

            if (eredmeny == null)
            {
                return StatusCode(400, "Error");
            }

            return StatusCode(200, eredmeny);
        }

        [HttpDelete("deletebyid/{id}")]
        public async Task<ActionResult<Tantargyak>> DeleteById(int id)
        {
            var eredmeny = await tantargyInterface.DeleteById(id);

            if (eredmeny == null)
            {
                return StatusCode(400, "Error");
            }

            return StatusCode(200, eredmeny);
        }
    }
}