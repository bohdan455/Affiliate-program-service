using DataAccess.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AffiliateProgramController : ControllerBase
    {
        private readonly IAffiliateProgramAccess _affiliateProgramAccess;

        public AffiliateProgramController(IAffiliateProgramAccess affiliateProgramAccess)
        {
            _affiliateProgramAccess = affiliateProgramAccess;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var affiliatePrograms = await _affiliateProgramAccess.GetAllAsync();
            if (affiliatePrograms == null) return NotFound();
            return Ok(affiliatePrograms);
        }
        [HttpGet("search/{term}")]
        public async Task<IActionResult> SearchAffiliateProgramAsync(string term)
        {
            var affiliateProgram = await _affiliateProgramAccess.GetByTitleSortedByPopularityAsync(term);
            if(affiliateProgram == null) return NotFound();
            return Ok(affiliateProgram);
        }
    }
}
