using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train.Enums;
using Train.Interfaces;

namespace Train.Сlasses
{
    public class Wagon<T> : IWagon<T>
    {
        public T qw
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
