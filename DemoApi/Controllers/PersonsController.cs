using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoLibrary.Commands;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonsController(IMediator mediator)
        {
            _mediator = mediator;
        }
      
        [HttpGet]
        public Task<List<PersonModel>> Get()
        {
            return _mediator.Send(new GetPersonListQuery());
        }

        [HttpGet("{id}")]
        public Task<PersonModel> GetById(int id)
        {
            return _mediator.Send(new GetPersonByIdQuery(id));
        }

        [HttpPost]
        public Task<PersonModel> Post([FromBody] PersonModel person)
        {
            return _mediator.Send(new InsertPersonCommand(person.FirstName, person.LastName));
        }

        [HttpPut]
        public Task<PersonModel> Edit(PersonModel person)
        {
            return _mediator.Send(new EditPersonCommand(person));
        }

        [HttpDelete("{id}")]
        public Task<PersonModel> Delete(int id)
        {
            return _mediator.Send(new RemovePersonCommand(id));
        }


    }
}