using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train.Enums;

namespace Train.Сlasses
{
    public class BaseWagon
    {
        protected string Id;
        protected WagonTypes WagonType;
        protected double Weight { get; set; }
    }
}
