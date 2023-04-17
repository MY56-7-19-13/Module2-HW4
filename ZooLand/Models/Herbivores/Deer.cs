using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLand.Models.Herbivores
{
    public class Deer : Herbivores
    {
        private int _speed;
        public Deer(string name, int weight, string type, int age, string gender, string food, int speed)
            : base(name, weight, type, age, gender, food)
        {
            _speed = speed;
        }

        public new string GetInfoAnimals()
        {
            return base.GetInfoAnimals() + $" | Speed: {_speed}km/h";
        }
    }
}
