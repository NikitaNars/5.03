using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._03
{
    class FeaturesCat
    {
        private string _name;
        private readonly string _breed;
        private double _height;
        private double _weight;

        public FeaturesCat(string name, string breed, double height, double weight, string owner)
        {
            _name = name;
            _breed = breed;
            _height = height;
            _weight = weight;
            Owner = owner;
        }
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        
        public string Breed { get; }

       
        public string Owner { get; }

       
        public string Information()
        {
            return $"Кличка: {Name}, Рост: {Height}, Вес: {Weight}, Порода: {Breed}, Владелец: {Owner}";
        }
            

        
        
    }
}
