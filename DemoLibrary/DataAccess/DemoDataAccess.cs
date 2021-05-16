using DemoLibrary.Interfaces;
using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> people = new();
        public DemoDataAccess()
        {
            people.Add(new PersonModel { Id = 1, FisrstName = "Sunil", LastName = "Adhya" });
            people.Add(new PersonModel { Id = 2, FisrstName = "unny", LastName = "Rao" });
        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel Add(string firstName, string last)
        {
            PersonModel p = new PersonModel {Id= people.Max(x=>x.Id)+1, FisrstName = firstName, LastName = last };
            people.Add(p);
            return p;
        }

        public PersonModel GetPeople(int id)
        {
            PersonModel p = people.Where(x => x.Id == id).FirstOrDefault();
            return p;
        }

        public PersonModel InsertPerson(string firstName, string lastName)
        {
            PersonModel p = this.Add(firstName, lastName);
            return p;
        }

        
    }
}
    