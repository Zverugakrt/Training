using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train.Interfaces;
using Train.Сlasses;
using Train.Enums;

namespace Train
{
    class Builder
    {
        ITrain train;
        ICollection<Passenger> passenger;
        ICollection<IPassengerWagon> passengerWagons;
        public ITrain Build()
        {
            Passenger();
            Wagon();
            return train;
        }

        void Passenger()
        {
            passenger = new List<Passenger>();
            passenger.Add(new Passenger() { Id = 1, FullName = "вася", SizeBaggage = 2 });
            passenger.Add(new Passenger() { Id = 2, FullName = "света", SizeBaggage = 3 });
            passenger.Add(new Passenger() { Id = 3, FullName = "павел", SizeBaggage = 1 });
            passenger.Add(new Passenger() { Id = 4, FullName = "олег", SizeBaggage = 1 });
            passenger.Add(new Passenger() { Id = 5, FullName = "евгений", SizeBaggage = 2 });
        }

        void Wagon()
        {
            passengerWagons=new List<IPassengerWagon>();
            IPassengerWagon passengerWagon = new PassengerWagon(1, WagonTypes.Passenger, PassengerWagonTypes.Interregional, passenger, 10, 8);
            passengerWagons.Add(passengerWagon);
            passengerWagon = new PassengerWagon(2, WagonTypes.Passenger, PassengerWagonTypes.EconomClass, passenger, 20, 15);
            passengerWagons.Add(passengerWagon);
            passengerWagon = new PassengerWagon(3, WagonTypes.Passenger, PassengerWagonTypes.Сompartment, passenger, 15, 13);
            passengerWagons.Add(passengerWagon);
            train = new Train.Сlasses.Train(new Locomotive(), passengerWagons);
            Console.WriteLine(train.CountPassengers());
            Console.WriteLine(train.CountBaggage());
            List < IPassengerWagon > qw = train.Wagons as List<IPassengerWagon>;
            
        }
    }
}
