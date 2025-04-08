using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _5._03
{
    class MethodCat
    {
        private string _name;
        private readonly string _breed;
        private double _height;
        private double _weight;
        private readonly string _owner;

        public MethodCat(string name, string breed, double height, double weight, string owner)
        {
            _name = name;
            _breed = breed;
            _height = height;
            _weight = weight;
            _owner = owner;
        }
        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public double GetHeight()
        {
            return _height;
        }

        public void SetHeight(double height)
        {
            _height = height;
        }


        public double GetWeight()
        {
            return _weight;
        }

        public void SetWeight(double weight)
        {
            _weight = weight;
        }


        public string GetBreed()
        {
            return _breed;
        }


        public string GetOwner()
        {
            return _owner;
        }

        public string GetInformation()
        {
            return $"Кличка: {_name}, Рост: {_height}, Вес: {_weight}, Порода: {_breed}, Владелец: {_owner}";

        }
        
    }
}
