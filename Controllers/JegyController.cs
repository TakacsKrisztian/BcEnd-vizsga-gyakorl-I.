﻿using Microsoft.AspNetCore.Mvc;
using Takács_Krisztián_backend.Repositories.Interfaces;

namespace Takács_Krisztián_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JegyController : ControllerBase
    {
        private readonly IJegyInterface jegyInterface;

        public JegyController(IJegyInterface jegyInterface)
        {
            this.jegyInterface = jegyInterface;
        }

        [HttpPost("jegy")]
        public async Task<ActionResult<JegyDto>> Post(CreateJegyDto createJegyDto)
        {
            return StatusCode(200, await jegyInterface.Post(createJegyDto));
        }

        [HttpGet("alljegy")]
        public async Task<IEnumerable<Jegyek>> Get()
        {
            return await jegyInterface.GetAll();
        }

        [HttpGet("jegybyid/{id}")]
        public async Task<ActionResult<Jegyek>> GetById(int id)
        {
            var eredmeny = await jegyInterface.GetById(id);
            if (eredmeny == null)
            {
                return StatusCode(400, "Error");
            }

            return StatusCode(200, eredmeny);
        }

        [HttpPut("updatebyid/{id}")]
        public async Task<ActionResult<Jegyek>> Put(int id, ModifyJegyDto modifyJegyDto)
        {
            var eredmeny = await jegyInterface.Put(id, modifyJegyDto);

            if (eredmeny == null)
            {
                return StatusCode(400, "Error");
            }

            return StatusCode(200, eredmeny);
        }

        [HttpDelete("deletebyid/{id}")]
        public async Task<ActionResult<Jegyek>> DeleteById(int id)
        {
            var eredmeny = await jegyInterface.DeleteById(id);

            if(eredmeny == null)
            {
                return StatusCode(400, "Error");
            }

            return StatusCode(200, eredmeny);
        }
    }
}