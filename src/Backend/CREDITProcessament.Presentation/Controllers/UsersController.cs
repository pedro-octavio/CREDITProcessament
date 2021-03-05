using CREDITProcessament.Domain.Core.Interfaces;
using CREDITProcessament.Domain.Models.RequestModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CREDITProcessament.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        private readonly IUserService userService;

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await userService.GetAllAsync());
        }

        [HttpGet("{CPF}")]
        public async Task<IActionResult> Get([FromRoute] GetUserByCPFRequestModel requestModel)
        {
            return Ok(await userService.GetByCPFAsync(requestModel.CPF));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddUserRequestModel requestModel)
        {
            await userService.AddAsync(requestModel);

            return Ok("User created successfully.");
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateUserRequestModel requestModel)
        {
            await userService.UpdateAsync(requestModel);

            return Ok("User updated successfully.");
        }

        [HttpDelete("{CPF}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteUserRequestModel requestModel)
        {
            await userService.DeleteAsync(requestModel.CPF);

            return Ok("User deleted successfully.");
        }
    }
}
