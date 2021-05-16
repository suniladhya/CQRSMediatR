using DemoLibrary.Models;
using System;
using System.Collections.Generic;

namespace DemoLibrary.Interfaces
{
    public interface IDataAccess
    {
        List<PersonModel> GetPeople();
        PersonModel GetPeople(int id);
        PersonModel InsertPerson(string firstName, string lastName);
    }
}
