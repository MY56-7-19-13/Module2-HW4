using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLand.Interface;

namespace ZooLand
{
    public class Animals : IShowInfoAnimals, IComparable<Animals>
    {
        private string _name;
        private int _weight;
        private string _type;
        private int _age;
        private string _gender;
        public string Name
        {
            get { return _name; }
        }

        public int Weight
        {
            get { return _weight; }
        }

        public string Type
        {
            get { return _type; }
        }

        public int Age
        {
            get { return _age; }
        }

        public string Gender
        {
            get { return _gender; }
        }

        public Animals(string name, int weight, string type, int age, string gender)
        {
            _name = name;
            _weight = weight;
            _type = type;
            _age = age;
            _gender = gender;
        }

        public string GetInfoAnimals()
        {
            return $"Title: {_name} | Weight: {_weight}kg | Age: {_age} | Type: {_type} | Geender: {_gender}";
        }

        public int CompareTo(Animals? other)
        {
            if (other != null)
            {
            }

            return Weight.CompareTo(other.Weight);
        }
    }
}
