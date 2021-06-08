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
    public class EditPersonHandler : IRequestHandler<EditPersonCommand, PersonModel>
    {
        private readonly IDataAccess _data;
        public EditPersonHandler(IDataAccess dataAccess)
        {
            _data = dataAccess;
        }
        public Task<PersonModel> Handle(EditPersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.EditPerson(request.Person));
        }
    }
}
