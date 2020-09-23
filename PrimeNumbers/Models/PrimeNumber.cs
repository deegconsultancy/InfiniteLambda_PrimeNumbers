using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeNumbers.Models
{
    public class PrimeNumber
    {
        public int valueToInvestigate { get; set; }

        public PrimeNumber(int primeInput)
        {
            valueToInvestigate = primeInput;
        }

        public bool IsPrime()
        {
            // making the assumption that we're not going to treat negative numbers as prime
            if (valueToInvestigate < 0) return false;

            // zero is explicitly not considered a prime number
            if (valueToInvestigate == 0) return false;

            // one is explicitly not considered a prime number
            if (valueToInvestigate == 1) return false;

            // two is the first prime number
            if (valueToInvestigate == 2) return true;

            // we can always say that a number divisible by 2 (other than 2 itself) is not prime, meaning we don't have to enter the loop below
            if (valueToInvestigate % 2 == 0) return false;

            // we only need to check divisors up to the candidate's square root to see it it's a prime
            var upperLimit = Math.Ceiling(Math.Sqrt(valueToInvestigate));

            for (int i = 3; i <= upperLimit; i += 2)
            {
                // if the expression below is true, the candidate has a divisior which is not itself or 1, therefor it is not prime
                if (valueToInvestigate % i == 0) return false;
            }

            //we have exhausted all checks for non-primeness, therefore this number is prime
            return true;
        }

        public int InitiateNextPrimeSearch()
        {
            //assuming that negative numbers are never prime, this saves us from entering the recursive call below if the baseValue is below 2 - in that case the next prime is always 2
            if (valueToInvestigate < 2)
            {
                return 2;
            }

            return GetNextPrime();
        }

        private int GetNextPrime()
        {            
            if(IsPrime())
            {
                return valueToInvestigate;
            }

            // create a prime model with the next value up and make a recursive call to the GetNextPrime method
            PrimeNumber incrementModel = new PrimeNumber(valueToInvestigate + 1);
            return incrementModel.GetNextPrime();            
        }
    }
}
