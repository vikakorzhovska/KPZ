using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Virus : IPrototype
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }
        public List<Virus> Children { get; set; }

        public Virus(string name, int weight, int age, string species)
        {
            Name = name;
            Weight = weight;
            Age = age;
            Species = species;
            Children = new List<Virus>();
        }

        public IPrototype Clone()
        {
            Virus clonedVirus = (Virus)this.MemberwiseClone();
            clonedVirus.Children = new List<Virus>();

            foreach (var child in this.Children)
            {
                clonedVirus.Children.Add((Virus)child.Clone());
            }

            return clonedVirus;
        }

        public void AddChild(Virus child)
        {
            Children.Add(child);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Вірус: {Name}, Вид: {Species}, Вага: {Weight}, Вік: {Age}");
            if (Children.Count > 0)
            {
                Console.WriteLine("Діти:");
                foreach (var child in Children)
                {
                    child.DisplayInfo();
                }
            }
            else
            {
                Console.WriteLine("Без дітей");
            }
        }
    }
}
