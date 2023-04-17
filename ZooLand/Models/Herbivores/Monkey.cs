using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLand.Models.Herbivores
{
    public class Monkey : Herbivores
    {
        private string _size;
        public string Size
        {
            get { return _size; }
        }

        public Monkey(string name, int weight, string type, int age, string gender, string food, string size)
            : base(name, weight, type, age, gender, food)
        {
            _size = size;
        }

        public new string GetInfoAnimals()
        {
            return base.GetInfoAnimals() + $" | Size: {_size}";
        }
    }
}
