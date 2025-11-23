using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_dotnet
{
    public class CarYearComparer : IComparer<Car>
    {
        public int Compare(Car? x, Car? y)
        {
            if (x == null || y == null) return 0;
            return x.Year.CompareTo(y.Year);
        }
    }
}
