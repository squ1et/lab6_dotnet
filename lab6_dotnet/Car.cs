using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_dotnet
{
    public class Car : IComparable<Car>
    {
        public string Brand { get; set; }
        public string OwnerSurname { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        public Car(string brand, string owner, int year, int mileage)
        {
            if (string.IsNullOrWhiteSpace(brand))
                throw new ArgumentException("Марка не може бути порожньою");

            if (string.IsNullOrWhiteSpace(owner))
                throw new ArgumentException("Прізвище власника не може бути порожнім");

            if (year < 1900 || year > DateTime.Now.Year)
                throw new ArgumentException("Некоректний рік");

            if (mileage < 0)
                throw new ArgumentException("Пробіг не може бути від'ємним");

            Brand = brand;
            OwnerSurname = owner;
            Year = year;
            Mileage = mileage;
        }

        public int CompareTo(Car? other)
        {
            if (other == null) return 1;
            return Mileage.CompareTo(other.Mileage);  // сортування за пробігом
        }

        public override string ToString()
            => $"{Brand} | {OwnerSurname} | {Year} | {Mileage} км";
    }
}
