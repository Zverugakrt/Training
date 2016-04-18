using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train.Interfaces
{
    public interface IFreightWagon:IWagon
    {
        double MaxCountFreight { get; }
        double CountFreight { get; }
        void AddFreight(int value);
    }
}
