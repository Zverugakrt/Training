using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train.Enums;
using Train.Interfaces;

namespace Train.Сlasses
{
    class Train
    {
        IWagon<PassengerWagonTypes> qww = new Wagon<PassengerWagonTypes>();
        void qw()
        { qww.qw = PassengerWagonTypes.EconomClass; }
    }
}
