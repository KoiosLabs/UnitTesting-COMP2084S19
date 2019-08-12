using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitTestingTest.Models
{
    public class MathService : IMathService
    {
        public int Add(int left, int right)
        {
            return left + right;
        }
    }
}