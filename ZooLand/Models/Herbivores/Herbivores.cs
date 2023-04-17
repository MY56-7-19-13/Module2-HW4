using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLand.Models.Herbivores
{
    public class Herbivores : Animals
    {
        private string _food;
        public string Food
        {
            get { return _food; }
        }

        public Herbivores(string name, int weight, string type, int age, string gender, string food)
            : base(name, weight, type, age, gender)
        {
            _food = food;
        }

        public new string GetInfoAnimals()
        {
            return base.GetInfoAnimals() + $" | Food: {_food}";
        }
    }
}
