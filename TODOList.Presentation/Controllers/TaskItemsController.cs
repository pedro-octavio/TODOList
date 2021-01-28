using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TODOList.Domain.Models.RequestModels.CommandRequestModels;
using TODOList.Domain.Models.RequestModels.QueryRequestModels;

namespace TODOList.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskItemsController : ControllerBase
    {
        public TaskItemsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        private readonly IMediator mediator;

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllTaskItemsQueryRequestModel requestModel)
        {
            var responseModel = await mediator.Send(requestModel);

            return Ok(responseModel);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetTaskItemByIdQueryRequestModel requestModel)
        {
            var responseModel = await mediator.Send(requestModel);

            return Ok(responseModel);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddTaskItemCommandRequestModel requestModel)
        {
            var responseModel = await mediator.Send(requestModel);

            return Ok(responseModel);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateTaskItemCommandRequestModel requestModel)
        {
            await mediator.Send(requestModel);

            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteTaskItemCommandRequestModel requestModel)
        {
            await mediator.Send(requestModel);

            return Ok();
        }
    }
}
