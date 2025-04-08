﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._03
{
    public class CafeAssortment
    {
        private string _dishName;
        private double _price;
        private string _category;
        private double _weight;

        public CafeAssortment(string dishName, double price, string category, double weight)
        {
            _dishName = dishName;
            _price = price;
            _category = category;
            _weight = weight;
        }

        public virtual string GetDishPrice()
        {
            double res = _price / _weight;
            return $"Стоимость одного грамма: {res}";
        }

        public virtual string CostOfDrink(int percent)
        {
            double res;
            res = _price - (_price * percent / 100);
            return $"Стоимость напитка со скидкой: {res}";
        }

        public virtual string Information()
        {
            return$"Название блюда: {_dishName}\nЦена: {_price}\nКатегория: {_category}";
        }
    }
}
