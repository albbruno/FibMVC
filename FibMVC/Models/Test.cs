using FibMVC.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FibMVC.Models
{
    public class Test
    {
        Fibo fiboObj = new Fibo();

        public Test()
        { 
        }

        public List<int> GetNumbers(int num)
        {
            return fiboObj.GetNumbers(num);
        }
    }
}