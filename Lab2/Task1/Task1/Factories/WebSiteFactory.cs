using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Subscriptions;

namespace Task1.Factories
{
    public class WebSiteFactory : SubscriptionFactory
    {
        public override ISubscription CreateSubscription() => new DomesticSubscription();
    }
}
