using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_dotnet
{
    public class CarList
    {
        public List<Car> Cars { get; private set; } = new List<Car>();

        public void Add(Car car)
        {
            Cars.Add(car);
        }

        public List<Car> FilterByYear(int year)
        {
            return Cars.Where(c => c.Year > year).ToList();
        }

        public void SortByMileage()
        {
            Cars = Cars.OrderBy(c => c.Mileage).ToList();
        }

        public List<string> GetAllBrands()
        {
            return Cars.Select(c => c.Brand).Distinct().ToList();
        }

        public IEnumerable<IGrouping<int, Car>> GroupByYear()
        {
            return Cars.GroupBy(c => c.Year);
        }

        public double AverageMileage()
        {
            if (!Cars.Any())
                return 0;
            return Cars.Average(c => c.Mileage);
        }

        public Dictionary<int, int> CountByYear()
        {
            return Cars.GroupBy(c => c.Year)
                       .ToDictionary(g => g.Key, g => g.Count());
        }

        public int MaxMileageForBrand(string brand)
        {
            var filtered = Cars.Where(c => c.Brand == brand);
            if (!filtered.Any())
                return 0;
            return filtered.Max(c => c.Mileage);
        }

        public void SaveToFile(string filename)
        {
            using (var sw = new StreamWriter(filename))
            {
                foreach (var c in Cars)
                {
                    sw.WriteLine($"{c.Brand};{c.OwnerSurname};{c.Year};{c.Mileage}");
                }
            }
        }

        public void LoadFromFile(string filename)
        {
            Cars.Clear();
            foreach (var line in File.ReadLines(filename))
            {
                var parts = line.Split(';');
                if (parts.Length == 4)
                {
                    var brand = parts[0];
                    var owner = parts[1];
                    if (int.TryParse(parts[2], out int year) && int.TryParse(parts[3], out int mileage))
                    {
                        Cars.Add(new Car(brand, owner, year, mileage));
                    }
                }
            }
        }
    }
}
