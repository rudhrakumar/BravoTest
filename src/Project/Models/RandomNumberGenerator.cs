using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{

    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        private readonly Random randomNumber = new Random();
        public int GetRandomNumber()
        {
           return randomNumber.Next();
        }

    }
}
