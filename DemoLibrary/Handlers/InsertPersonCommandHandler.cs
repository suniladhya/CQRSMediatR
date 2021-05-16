﻿using DemoLibrary.Command;
using DemoLibrary.Interfaces;
using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class InsertPersonCommandHandler : IRequestHandler<InsertPersonCommand, PersonModel>
    {
        private readonly IDataAccess _dataAccess;

        public InsertPersonCommandHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public Task<PersonModel> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.InsertPerson(request.FirstName, request.LastName));
        }
    }
}
