using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train.Interfaces;

namespace Train.Сlasses
{
    class Locomotive : ILocomotive
    {
        double _MaxSpeed;
        public double MaxSpeed
        {
            get
            {
                return _MaxSpeed;
            }
        }
    }
}
