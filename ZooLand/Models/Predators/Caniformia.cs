using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLand.Models.Predators
{
    public class Caniformia : Predators
    {
        private string _furСolor;
        public string FurColor
        {
            get { return _furСolor; }
        }

        public Caniformia(string name, int weight, string type, int age, string gender, string food, string furColor)
            : base(name, weight, type, age, gender, food)
        {
            _furСolor = furColor;
        }

        public new string GetInfoAnimals()
        {
            return base.GetInfoAnimals() + $" | Fur-Color: {_furСolor}";
        }
    }
}
