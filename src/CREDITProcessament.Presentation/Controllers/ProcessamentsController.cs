using CREDITProcessament.Domain.Core.Interfaces;
using CREDITProcessament.Domain.Models.RequestModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CREDITProcessament.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessamentsController : ControllerBase
    {
        public ProcessamentsController(IProcessamentService processamentService)
        {
            this.processamentService = processamentService;
        }

        private readonly IProcessamentService processamentService;

        [HttpGet]
        [Route("GetByCreateDate")]
        public async Task<IActionResult> Get([FromQuery] GetAllProcessamentsByCreateDateRequestModel requestModel)
        {
            return Ok(await processamentService.GetAllAsync(requestModel));
        }

        [HttpGet]
        [Route("GetByProcessed")]
        public async Task<IActionResult> Get([FromQuery] GetAllProcessamentsByProcessedRequestModel requestModel)
        {
            return Ok(await processamentService.GetAllAsync(requestModel));
        }

        [HttpGet]
        [Route("GetByUserCPF/{CPF}")]
        public async Task<IActionResult> Get([FromRoute] GetProcessamentByUserCPFRequestModel requestModel)
        {
            return Ok(await processamentService.GetByUserCPFAsync(requestModel));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddProcessamentRequestModel requestModel)
        {
            await processamentService.AddAsync(requestModel);

            return Ok("Processament created successfully.");
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateProcessamentRequestModel requestModel)
        {
            await processamentService.UpdateAsync(requestModel);

            return Ok("Processament updated successfully.");
        }

        [HttpDelete("{CPF}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteProcessamentRequestModel requestModel)
        {
            await processamentService.DeleteAsync(requestModel);

            return Ok("Processament deleted successfully.");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteRangeProcessamentRequestModel requestModel)
        {
            await processamentService.DeleteRangeAsync(requestModel);

            return Ok("Processaments deleted successfully.");
        }
    }
}
