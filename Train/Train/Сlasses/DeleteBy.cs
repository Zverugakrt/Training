using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train.Сlasses
{
    public static class Delete
    {
        public static IEnumerable<T> DeleteBy<T>(this ICollection<T> iterator, Func<T, object> parametr, object value)
        {
            foreach(var item in iterator)
            {
                if(parametr(item) == value)
                {
                    iterator.Remove(item);
                }
            }
            return iterator;
        }
    }
}
