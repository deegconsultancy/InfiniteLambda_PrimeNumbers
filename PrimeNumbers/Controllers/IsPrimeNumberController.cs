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
    public class IsPrimeNumberController : ControllerBase
    {
        /// <summary>
        /// Method which checks if a given number is prime
        ///</summary>
        [HttpGet]
        [Route("{candidate:int}")]
        public bool CheckIsPrime(int candidate)
        {
            PrimeNumber checkModel = new PrimeNumber(candidate);
            return checkModel.IsPrime();
        }
    }
}
