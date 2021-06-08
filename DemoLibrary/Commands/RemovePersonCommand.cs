using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary.Commands
{
    public class RemovePersonCommand : IRequest<PersonModel>
    {
        public int Id { get; set; }
        public RemovePersonCommand(int id)
        {
            Id = id;
        }
    }
}
