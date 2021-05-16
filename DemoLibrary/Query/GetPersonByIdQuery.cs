﻿using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Query
{
    public record GetPersonByIdQuery(int Id) : IRequest<PersonModel>;

    //public class GetPersonByIdQuery : IRequest<PersonModel>
    //{
    //    public int Id { get; set; }
    //    public GetPersonByIdQuery(int id)
    //    {
    //        Id = id;
    //    }
    //}
}
