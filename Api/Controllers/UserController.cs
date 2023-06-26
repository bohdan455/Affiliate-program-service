using Api.Extensions.Mapper;
using Api.Model;
using DataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserAccess _userAccess;

        public UserController(IUserAccess userAccess)
        {
            _userAccess = userAccess;
        }
        [HttpPost]
        public async Task<IActionResult> InsertAsync(UserModel userModel)
        {
            if(!ModelState.IsValid) return BadRequest(ModelState);
            await _userAccess.InsertAsync(userModel.ToUser());
            return Ok();
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var user = await _userAccess.GetByIdAsync(id);
            if (user == null) return NotFound();
            return Ok(user);
        }
        [HttpGet("subscribe/{id:int}")]
        public async Task<IActionResult> GetListOfSubscribedAffiliateProgramsAsync(int id)
        {
            var programs = await _userAccess.GetSubscribedAffiliateProgramsAsync(id);
            if(programs == null) return NotFound();
            return Ok(programs);
        }
        [HttpPost("subscribe")]
        public async Task<IActionResult> Subscribe(int userId,int programId)
        {
            await _userAccess.SubscribeToAffiliateAsync(userId, programId);
            return Ok();
        }
    }
}
