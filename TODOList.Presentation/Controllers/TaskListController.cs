using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TODOList.Domain.Models.RequestModels.CommandRequestModels;
using TODOList.Domain.Models.RequestModels.QueryRequestModels;

namespace TODOList.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskListController : ControllerBase
    {
        public TaskListController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        private readonly IMediator mediator;

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllTaskListsQueryRequestModel requestModel)
        {
            var responseModel = await mediator.Send(requestModel);

            return Ok(responseModel);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetTaskListByIdQueryRequestModel requestModel)
        {
            var responseModel = await mediator.Send(requestModel);

            return Ok(responseModel);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddTaskListCommandRequestModel requestModel)
        {
            var responseModel = await mediator.Send(requestModel);

            return Ok(responseModel);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateTaskListCommandRequestModel requestModel)
        {
            await mediator.Send(requestModel);

            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteTaskListCommandRequestModel requestModel)
        {
            await mediator.Send(requestModel);

            return Ok();
        }
    }
}
