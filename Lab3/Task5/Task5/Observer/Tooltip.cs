using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Observer
{
    public class Tooltip : IEventListener
    {
        public void Update(string eventType)
        {
            Console.WriteLine($"Tooltip received event: {eventType}");
        }
    }

}
