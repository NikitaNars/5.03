﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._03
{
    public class Attractions
    {
        private string _name;
        private double _duration;
        private int _maxSeats;
        private double _price;

        public Attractions(string name, double duration, int maxSeats, double price)
        {
            _name = name;
            _duration = duration;
            _maxSeats = maxSeats;
            _price = price;
        }

        public virtual double GetRevenue(int people = 0)
        {
            if (people == 0)
            {
                return _price * _maxSeats;
            }
            else
            {
                return people * _price;
            }
        }

        public virtual string Information()
        {
            return $"Название: {_name}\nПродолжительность поездки: {_duration}\nМаксимальное кол-во мест: {_maxSeats}";
        }
    }
}
