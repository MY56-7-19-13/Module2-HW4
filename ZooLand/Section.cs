using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLand.Models.Herbivores;
using ZooLand.Models.Predators;

namespace ZooLand
{
    public class Section
    {
        private Feliformia[] _feliformias =
        {
            new Feliformia("Lion", 190, "Predators", 12, "Male", "Meat", "King"),
            new Feliformia("Lion", 130, "Predators", 12, "Female", "Meat", "Queen"),
            new Feliformia("Tiger", 250, "Predators", 9, "Male", "Meat", "Hunter"),
            new Feliformia("Cheetah", 68, "Predators", 10, "Male", "Meat", "Speed"),
            new Feliformia("Lynx", 23, "Predators", 6, "Female", "Meat", "Small Cat"),
        };
        private Caniformia[] _caniformias =
        {
            new Caniformia("White Bear", 450, "Predators", 20, "Male", "Meat", "White"),
            new Caniformia("Wolf", 130, "Predators", 13, "Male", "Meat", "Grey"),
            new Caniformia("Grizzly", 500, "Predators", 15, "Male", "Meat", "Brown"),
            new Caniformia("Hyena", 30, "Predators", 7, "Male", "Meat", "Orange"),
            new Caniformia("Coyote", 28, "Predators", 5, "Female", "Meat", "Beige"),
        };
        private Monkey[] _monkeys =
        {
            new Monkey("White-headed langur", 15, "Herbivores", 3, "Male", "Fruits", "Small"),
            new Monkey("Japanese macaque", 16, "Herbivores", 5, "Male", "Fruits", "Small"),
            new Monkey("Gelada", 20, "Herbivores", 7, "Female", "Fruits", "Middle"),
            new Monkey("Orang-utan", 95, "Herbivores", 10, "Male", "Fruits", "Big"),
            new Monkey("Gorilla", 130, "Herbivores", 15, "Male", "Fruits", "King"),
        };
        private Deer[] _deers =
        {
            new Deer("Elk", 200, "Herbivores", 13, "Male", "Grass", 15),
            new Deer("American deer", 100, "Herbivores", 6, "Female", "Grass", 45),
            new Deer("Reindeer", 150, "Herbivores", 10, "Male", "Grass", 25),
            new Deer("Fallow deer", 60, "Herbivores", 4, "Female", "Grass", 55),
            new Deer("Thompson's gazelle", 70, "Herbivores", 9, "Male", "Grass", 80),
        };
        public Feliformia[] GetFeliformias()
        {
            for (int i = 0; i < _feliformias.Length; i++)
            {
                Console.Write(i + 1 + ". ");
                Console.WriteLine(_feliformias[i].GetInfoAnimals());
            }

            return _feliformias;
        }

        public Caniformia[] GetCaniformias()
        {
            for (int i = 0; i < _caniformias.Length; i++)
            {
                Console.Write(i + 1 + ". ");
                Console.WriteLine(_caniformias[i].GetInfoAnimals());
            }

            return _caniformias;
        }

        public Monkey[] GetMonkeys()
        {
            for (int i = 0; i < _monkeys.Length; i++)
            {
                Console.Write(i + 1 + ". ");
                Console.WriteLine(_monkeys[i].GetInfoAnimals());
            }

            return _monkeys;
        }

        public Deer[] GetDeers()
        {
            for (int i = 0; i < _deers.Length; i++)
            {
                Console.Write(i + 1 + ". ");
                Console.WriteLine(_deers[i].GetInfoAnimals());
            }

            return _deers;
        }
    }
}
