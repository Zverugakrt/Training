using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train.Enums;
using Train.Interfaces;

namespace Train.Сlasses
{
    public class Train : ITrain
    {
        ILocomotive _Locomotiv;
        public ILocomotive Locomotiv
        {
            get
            {
                return _Locomotiv;
            }
        }
        ICollection<IPassengerWagon> _Wagons;
        public ICollection<IPassengerWagon> Wagons
        {
            get
            {
                return _Wagons;
            }
        }

        public Train(ILocomotive locomotiv, ICollection<IPassengerWagon> wagons)
        {
            _Locomotiv = locomotiv;
            _Wagons = wagons;
        }

        public double CountBaggage()
        {
            return _Wagons.Sum(x => x.CountBaggage());
        }

        public int CountPassengers()
        {
            return _Wagons.Sum(x => x.CountPassengers());
        }

        public void Find()
        {
            throw new NotImplementedException();
        }
    }
}
