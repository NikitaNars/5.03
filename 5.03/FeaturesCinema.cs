using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._03
{
    class FeaturesCinema
    {
        private string _movieTitle;
        private readonly decimal _ticketPrice;
        private int _peopleCapacity;


        public string MovieTitle
        {
            get => _movieTitle;
            set => _movieTitle = value;
        }

        
        public decimal TicketPrice => _ticketPrice;

      
        public int AudienceCount
        {
            get => _peopleCapacity;
            set => _peopleCapacity = value;
        }

        
        public string _cinemaHall { get; }

        
        public string Information()
        {
            return $"Название фильма: {_movieTitle}\nЦена билета: {_ticketPrice}\nВместимось: {_peopleCapacity}\nКинозал: {_cinemaHall}";
        }

        // Constructor
        public FeaturesCinema(string movieTitle, decimal ticketPrice,
                             int peopleCapacity, string CinemaHall)
        {
            _movieTitle = movieTitle;
            _ticketPrice = ticketPrice;
            _peopleCapacity = peopleCapacity;
            _cinemaHall = CinemaHall;
        }
    }
}
