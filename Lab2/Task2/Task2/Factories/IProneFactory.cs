using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Interfaces;
using Task2.Products.IProne;

namespace Task2.Factories
{
    public class IProneFactory : ITechFactory
    {
        public ILaptop CreateLaptop() => new IProneLaptop();
        public INetbook CreateNetbook() => new IProneNetbook();
        public IEBook CreateEBook() => new IProneEBook();
        public ISmartphone CreateSmartphone() => new IProneSmartphone();
    }
}
