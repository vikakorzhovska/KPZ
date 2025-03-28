using Task2.Heroes;
using Task2.Inventory;
using Task2;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Console.WriteLine("=== Гра RPG ===");

IHero warrior = new Warrior();
Console.WriteLine("\n--- Базовий воїн ---");
warrior.Attack();

IHero warriorWithSword = new Sword(warrior);
Console.WriteLine("\n--- Воїн з мечем ---");
warriorWithSword.Attack();

IHero warriorWithSwordAndArmor = new Armor(warriorWithSword);
Console.WriteLine("\n--- Воїн з мечем і бронею ---");
warriorWithSwordAndArmor.Attack();

IHero warriorFullyEquipped = new Artifact(warriorWithSwordAndArmor);
Console.WriteLine("\n--- Воїн з мечем, бронею та артефактом ---");
warriorFullyEquipped.Attack();