using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train.Enums;
using Train.Interfaces;

namespace Train.Сlasses
{
    public class FreightWagon : BaseWagon, IFreightWagon
    {
        double _CountFreight;
        public double CountFreight
        {
            get
            {
                return _CountFreight;
            }
        }

        public double MaxCountFreight
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public FreightWagon(int id, WagonTypes wagontype, double countFreight) :base(id, wagontype)
        {
            _CountFreight = countFreight;
        }

        public void AddFreight(int value)
        {
            _CountFreight += value;
        }
    }
}
