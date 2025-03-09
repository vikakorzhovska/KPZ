using System.Text;
using Task2.Client;
using Task2.Factories;
using Task2.Interfaces;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

ITechFactory iproneFactory = new IProneFactory();
Client client1 = new Client(iproneFactory);
Console.WriteLine("--- Продукція IProne ---");
client1.Run();

ITechFactory kiaomiFactory = new KiaomiFactory();
Client client2 = new Client(kiaomiFactory);
Console.WriteLine("--- Продукція Kiaomi ---");
client2.Run();

ITechFactory balaxyFactory = new BalaxyFactory();
Client client3 = new Client(balaxyFactory);
Console.WriteLine("--- Продукція Balaxy ---");
client3.Run();