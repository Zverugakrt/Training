using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Train.Enums;
using Train.Interfaces;

namespace Train.Сlasses
{
    public class PassengerWagon : BaseWagon,IPassengerWagon
    {
        double _MaxCountBaggage;
        public double MaxCountBaggage
        {
            get
            {
                return _MaxCountBaggage;
            }
        }
        int _MaxCountPassengers;
        public int MaxCountPassengers
        {
            get
            {
                return _MaxCountPassengers;
            }
        }
        ICollection<Passenger> _Passengers;
        public ICollection<Passenger> Passengers
        {
            get
            {
                return _Passengers;
            }
        }
        PassengerWagonTypes _PassengerWagonType;
        public PassengerWagonTypes PassengerWagonType
        {
            get
            {
                return _PassengerWagonType;
            }
        }

        public PassengerWagon(int id, WagonTypes wagontype, PassengerWagonTypes passengerWagonType, ICollection<Passenger> passengers, double maxCountBaggage, int maxCountPassengers):base (id, wagontype)
        {
            _PassengerWagonType = passengerWagonType;
            _Passengers = passengers;
            _MaxCountBaggage = maxCountBaggage;
            _MaxCountPassengers = maxCountPassengers;
        }
        public void AddPassenger(Passenger passenger)
        {
            _Passengers.Add(passenger);
        }

        public double CountBaggage()
        {
            return _Passengers.Sum(x => x.SizeBaggage);
        }

        public int CountPassengers()
        {
            return _Passengers.Count;
        }

        public void DeletePassengerByFullName(string fullname)
        {
            _Passengers.DeleteBy(x => x.FullName, fullname);
        }

        public void DeletePassengerById(int id)
        {
            _Passengers.DeleteBy(x => x.Id, id);
        }
    }
}
