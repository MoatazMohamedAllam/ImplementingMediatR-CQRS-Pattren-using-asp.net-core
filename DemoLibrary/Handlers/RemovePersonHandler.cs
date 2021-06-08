using DemoLibrary.Commands;
using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class RemovePersonCommandHandler : IRequestHandler<RemovePersonCommand, PersonModel>
    {
        private readonly IDataAccess _data;
        public RemovePersonCommandHandler(IDataAccess data)
        {
            _data = data;
        }
        public Task<PersonModel> Handle(RemovePersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.RemovePerson(request.Id));
        }
    }
}
