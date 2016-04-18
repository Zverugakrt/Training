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
        protected int Id;
        protected WagonTypes WagonType;
        protected double Weight { get; set; }
        protected int YearOfRelease;

        public BaseWagon(int id, WagonTypes wagontype)
        {
            Id = id;
            WagonType = wagontype;
        }
    }
}
