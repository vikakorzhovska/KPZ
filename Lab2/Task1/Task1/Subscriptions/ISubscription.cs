using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Subscriptions
{
    public interface ISubscription
    {
        string Name { get; }
        decimal MonthlyFee { get; }
        int MinPeriod { get; }
        List<string> Channels { get; }
        void DisplayInfo();
    }
}
