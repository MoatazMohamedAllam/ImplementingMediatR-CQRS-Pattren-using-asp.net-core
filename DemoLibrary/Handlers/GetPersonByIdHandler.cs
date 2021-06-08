using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, PersonModel>
    {
        private readonly IDataAccess _data;

        public GetPersonByIdHandler(IDataAccess dataAccess)
        {
            _data = dataAccess;
        }
        public Task<PersonModel> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            var people = _data.GetPeople();
            return Task.FromResult(people.FirstOrDefault(p => p.Id == request.Id));
        }
    }
}
