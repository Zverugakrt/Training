using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train.Enums;
using Train.Сlasses;

namespace Train.Interfaces
{
    public interface IPassengerWagon:IWagon
    {
        ICollection<Passenger> Passengers { get; }
        PassengerWagonTypes PassengerWagonType { get;}
        int MaxCountPassengers { get;}
        double MaxCountBaggage { get;}
        
        void AddPassenger(Passenger passenger);
        void DeletePassengerByFullName(string fullname);
        void DeletePassengerById(int id);
        int CountPassengers();
        double CountBaggage();
    }
}
