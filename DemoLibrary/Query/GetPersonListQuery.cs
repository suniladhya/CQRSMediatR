using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Query
{
    public record GetPersonListQuery():IRequest<List<PersonModel>>;
    
    //the below class is the equivalent of Above Statement
    //Only advantage is the above statement is readonly in Nature
    public class GetPersonListQueryClass: IRequest<List<PersonModel>>
    {
        
    }
}
