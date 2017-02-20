using FibMVC.Biz;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FibMVC.Models
{
    public class FibonacciMdl
    {
        Fibo fiboObj = new Fibo();
        public string test { get; set; }

        public int lengthOfFibo { get; set; }

        public List<int> GetNumbers(int lngth)
        {
            return fiboObj.GetNumbers(lngth);
        }
    }
}