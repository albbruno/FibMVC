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
        public string test;

        [Required]
        public int lengthOfFibo;

        public FibonacciMdl()
        {
        }

        public List<int> GetNumbers(int lngth)
        {
            return fiboObj.GetNumbers(lngth);
        }
    }
}