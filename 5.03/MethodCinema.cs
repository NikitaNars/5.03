using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._03
{
    class MethodCinema
    {
        private string _movieName;
        private double _price;
        private int _peopleCapacity;
        private string _cinemaHall;

        public void SetMovieName(string movieName) => _movieName = movieName;
        public string GetMovieName() => _movieName;

        public double GetPrice() => _price;

        public string GetCinemaHall() => _cinemaHall;

        public MethodCinema(string movieName, double price, int peopleCapacity, string cinemaHall)
        {
            _movieName = movieName;
            _price = price;
            _peopleCapacity = peopleCapacity;
            _cinemaHall = cinemaHall;
        }

        public string Information()
        {
            return $"Название фильма: {_movieName}\nЦена билета: {_price}\nВместимось: {_peopleCapacity}\nКинозал: {_cinemaHall}";
        }
    }
}
