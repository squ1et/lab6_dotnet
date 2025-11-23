using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_dotnet
{
    public class CarList
    {
        public List<Car> Cars { get; private set; } = new();

        public void Add(Car car) => Cars.Add(car);

        public void Remove(Car car) => Cars.Remove(car);

        public void SaveToFile(string path)
        {
            File.WriteAllLines(path, Cars.Select(c =>
                $"{c.Brand};{c.OwnerSurname};{c.Year};{c.Mileage}"));
        }

        public void LoadFromFile(string path)
        {
            Cars = File.ReadAllLines(path)
                .Select(line =>
                {
                    var p = line.Split(';');
                    return new Car(p[0], p[1], int.Parse(p[2]), int.Parse(p[3]));
                }).ToList();
        }

        public List<Car> FilterByYear(int year)
            => Cars.Where(c => c.Year == year).ToList();

        public void SortByMileage()
            => Cars.Sort();

        public void SortByYear()
            => Cars.Sort(new CarYearComparer());
    }
}
