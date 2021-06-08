using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary.Commands
{
    public class InsertPersonCommand : IRequest<PersonModel>
    {
        public string FirstName{ get; set; }
        public string LastName { get; set; }

        public InsertPersonCommand(string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

    }
}
