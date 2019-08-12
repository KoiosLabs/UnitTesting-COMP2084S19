using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitTestingTest.Models
{
    public class SpyMathService : IMathService
    {
        public int Add_Left, Add_Right, Add_Result;
        public int Add(int left, int right)
        {
            Add_Left = left;
            Add_Right = right;
            return Add_Result;
        }
    }
}