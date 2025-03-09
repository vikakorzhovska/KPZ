using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Interfaces;

namespace Task2.Products.Balaxy
{
    public class BalaxyLaptop : ILaptop
    {
        public void ShowInfo() => Console.WriteLine("Balaxy Laptop створено");
    }
}
