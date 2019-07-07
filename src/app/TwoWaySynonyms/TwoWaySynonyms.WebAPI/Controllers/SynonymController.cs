using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TwoWaySynonyms.Services.Synonym;
using TwoWaySynonyms.ViewModels.Synonym;

namespace TwoWaySynonyms.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SynonymController : ControllerBase
    {
        private readonly ISynonymService synonymService;

        public SynonymController(ISynonymService synonymService)
        {
            this.synonymService = synonymService;
        }

        [HttpGet]
        public IActionResult GetAllSynonyms()
        {
            var result = this.synonymService.GetAllSynonyms();
            if (!result.Any())
            {
                return NotFound();
            }

            return Ok(result);
        }

      
        [HttpPost]
        public IActionResult SaveSyonyms([FromBody]SynonymViewModel synonym)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                this.synonymService.SaveSyonyms(synonym);
                return CreatedAtAction(nameof(GetAllSynonyms), synonym);
            }
        }
    }
}