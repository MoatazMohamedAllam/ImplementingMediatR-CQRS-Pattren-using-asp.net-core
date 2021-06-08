using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> People = new List<PersonModel>();

        public DemoDataAccess()
        {
            People.Add(new PersonModel { Id = 1, FirstName = "moataz", LastName = "allam" });
            People.Add(new PersonModel { Id = 2, FirstName = "mohamed", LastName = "ali" });
        }

        
        public List<PersonModel> GetPeople()
        {
            return People;
        }

        public PersonModel InsertPerson(string firstName, string lastName)
        {
            var person = new PersonModel
            {
                FirstName = firstName,
                LastName = lastName,
                Id = People.Max(x => x.Id) + 1
            };
            People.Add(person);
            return person;
        }
        public PersonModel EditPerson(PersonModel person)
        {
            var personInDb = People.Find(p => p.Id == person.Id);
            People.Remove(personInDb);
            person.Id = People.Max(x => x.Id) + 1;
            People.Add(person);
            return person;
        }

        public PersonModel RemovePerson(int id)
        {
            var person = People.Find(p => p.Id == id);
            People.Remove(person);
            return person;
        }
    }
}
