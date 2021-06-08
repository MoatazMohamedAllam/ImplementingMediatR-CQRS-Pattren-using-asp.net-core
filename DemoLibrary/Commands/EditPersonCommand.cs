using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary.Commands
{
    public class EditPersonCommand : IRequest<PersonModel>
    {
        public PersonModel Person { get; set; }
        public EditPersonCommand(PersonModel person)
        {
            Person = person;
        }
    }
}
