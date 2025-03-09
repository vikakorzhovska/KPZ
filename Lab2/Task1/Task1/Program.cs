using System.Text;
using Task1.Factories;
using Task1.Subscriptions;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

SubscriptionFactory websiteFactory = new WebSiteFactory();
SubscriptionFactory mobileAppFactory = new MobileAppFactory();
SubscriptionFactory managerCallFactory = new ManagerCallFactory();

ISubscription websiteSubscription = websiteFactory.CreateSubscription();
ISubscription mobileAppSubscription = mobileAppFactory.CreateSubscription();
ISubscription managerCallSubscription = managerCallFactory.CreateSubscription();

websiteSubscription.DisplayInfo();
mobileAppSubscription.DisplayInfo();
managerCallSubscription.DisplayInfo(); 