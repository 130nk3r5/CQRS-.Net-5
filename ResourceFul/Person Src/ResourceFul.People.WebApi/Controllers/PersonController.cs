using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ResourceFul.People.Application.PersonItems.Dtos;
using ResourceFul.People.Application.Person.Queries.GetPersonItems;
using ResourceFul.People.Application.PersonItems.Commands.CreatePerson;
using ResourceFul.People.Application.PersonItems.Commands.UpdatePerson;
using ResourceFul.People.Application.PersonItems.Commands.DeletePerson;


namespace ResourceFul.People.WebApi.Controllers
{
    public class PersonController : ApiControllerBase
    {     

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
            //_mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<PersonDto>>> Get()
        {            
            return await Mediator.Send(new GetPersonItemsQuery());
        }


        //[Route("GetPerson")]
        [HttpGet("{personId:long}", Name = "GetPerson")]
        public async Task<ActionResult<PersonDto>> GetPerson(int personId)
        {            
            return await Mediator.Send(new GetPersonQuery { personId = personId});
        }

        [HttpPost]
        public async Task<ActionResult<long>> CreatePerson(CreatePersonCommand command)
        {
            var result = await Mediator.Send(command);
            return CreatedAtRoute("GetPerson", new { personId = result }, command);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateUser(UpdatePersonCommand command)
        {
            await Mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{personId:long}")]
        public async Task<ActionResult> DeleteUser(long personId)
        {
            await Mediator.Send(new DeletePersonCommand { PersonId = personId } );
            return NoContent();
        }
    }
}
