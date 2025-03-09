using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Interfaces;

namespace Task2.Client
{
    public class Client
    {
        private ILaptop _laptop;
        private INetbook _netbook;
        private IEBook _ebook;
        private ISmartphone _smartphone;

        public Client(ITechFactory factory)
        {
            _laptop = factory.CreateLaptop();
            _netbook = factory.CreateNetbook();
            _ebook = factory.CreateEBook();
            _smartphone = factory.CreateSmartphone();
        }

        public void Run()
        {
            _laptop.ShowInfo();
            _netbook.ShowInfo();
            _ebook.ShowInfo();
            _smartphone.ShowInfo();
        }
    }
}
