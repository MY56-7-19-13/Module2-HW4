using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLand.Models.Predators
{
    public class Feliformia : Predators
    {
        private string _manner;
        public string Manner
        {
            get { return _manner; }
        }

        public Feliformia(string name, int weight, string type, int age, string gender, string food, string manner)
            : base(name, weight, type, age, gender, food)
        {
            _manner = manner;
        }

        public new string GetInfoAnimals()
        {
            return base.GetInfoAnimals() + $" | Manner: {_manner}";
        }
    }
}
