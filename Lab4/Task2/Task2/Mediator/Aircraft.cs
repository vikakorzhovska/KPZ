using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Mediator
{
    public class Aircraft
    {
        public string Name { get; }
        public bool IsTakingOff { get; set; }
        private readonly IMediator _mediator;

        public Aircraft(string name, IMediator mediator)
        {
            this.Name = name;
            this._mediator = mediator;
        }

        public void Land()
        {
            Console.WriteLine($"Aircraft {this.Name} is requesting to land...");
            _mediator.RequestLanding(this);
        }

        public void TakeOff()
        {
            Console.WriteLine($"Aircraft {this.Name} is requesting to take off...");
            _mediator.RequestTakeOff(this);
        }
    }
}
