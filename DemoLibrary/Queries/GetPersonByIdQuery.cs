using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary.Queries
{
    public class GetPersonByIdQuery : IRequest<PersonModel>
    {
        public int Id { get; set; }
        public GetPersonByIdQuery(int id)
        {
            Id = id;
        }
    }
}
