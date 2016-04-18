using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train.Interfaces
{
    public interface ITrain
    {
        ICollection<IPassengerWagon> Wagons { get;}
        ILocomotive Locomotiv { get;}

        int CountPassengers();
        double CountBaggage();
        void Find();
    }
}
