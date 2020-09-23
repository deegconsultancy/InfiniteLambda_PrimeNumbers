using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using PrimeNumbers.Models;

namespace PrimeNumbers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NextPrimeNumberController : ControllerBase
    {
        /// <summary>
        /// Method which accepts a number and returns the next prime number
        ///</summary>
        [HttpGet("{baseValue:int}")]
        public int GetNextPrime(int baseValue)
        {
            PrimeNumber checkModel = new PrimeNumber(baseValue);
            return checkModel.InitiateNextPrimeSearch();
        }
    }
}
