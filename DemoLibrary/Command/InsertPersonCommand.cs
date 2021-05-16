using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Command
{
    public record InsertPersonCommand(string FirstName, string LastName):IRequest<PersonModel>;
    
    //Class equivalent of Record
    //public class InsertPersonCommandClass
    //{
    //    public string FirstName { get; set; }
    //    public string LastName{ get; set; }

    //    public InsertPersonCommandClass(string firstName, string lastName)
    //    {
    //        FirstName = firstName;
    //        LastName = lastName;
    //    }
    //}
}
