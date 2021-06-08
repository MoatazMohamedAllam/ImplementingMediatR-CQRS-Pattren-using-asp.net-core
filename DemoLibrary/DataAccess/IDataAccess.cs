using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary.DataAccess
{
    public interface IDataAccess
    {
        List<PersonModel> GetPeople();
        PersonModel InsertPerson(string firstName, string lastName);
        PersonModel RemovePerson(int id);
        PersonModel EditPerson(PersonModel person);
    }
}
