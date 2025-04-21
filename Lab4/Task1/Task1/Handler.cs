using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract public class Handler
    {
        protected Handler _next;

        public Handler SetNext(Handler next)
        {
            _next = next;
            return next;
        }

        public abstract void Handle();
    }
}
