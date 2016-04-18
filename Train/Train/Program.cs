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
    class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new Builder();
            builder.Build();
        }
    }
}
