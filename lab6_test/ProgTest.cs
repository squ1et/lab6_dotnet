using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab6_dotnet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace lab6_test
{
    [TestClass]
    public sealed class CarTests
    {
        [TestMethod]
        public void Car_Validation_WrongYear_Throws()
        {
            Assert.ThrowsException<ArgumentException>(() =>
                new Car("VW", "Test", 1800, 10000));
        }

        [TestMethod]
        public void Filter_ReturnsCorrectCars()
        {
            CarList list = new CarList();
            list.Add(new Car("A", "A", 2000, 100));
            list.Add(new Car("B", "B", 2020, 200));

            var result = list.FilterByYear(2010);

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("B", result[0].Brand);  // Врахуй, що це > 2010, тому "B"
        }

        [TestMethod]
        public void SortByMileage_Works()
        {
            CarList list = new CarList();
            list.Add(new Car("A", "A", 2000, 300));
            list.Add(new Car("B", "B", 2000, 100));

            list.SortByMileage();

            Assert.AreEqual(100, list.Cars[0].Mileage);
        }

        [TestMethod]
        public void GetAllBrands_ReturnsDistinctBrands()
        {
            CarList list = new CarList();
            list.Add(new Car("Toyota", "Ivanov", 2015, 50000));
            list.Add(new Car("Ford", "Petrenko", 2018, 30000));
            list.Add(new Car("Toyota", "Shevchenko", 2017, 45000));

            var brands = list.GetAllBrands();

            Assert.AreEqual(2, brands.Count);
            Assert.IsTrue(brands.Contains("Toyota"));
            Assert.IsTrue(brands.Contains("Ford"));
        }

        [TestMethod]
        public void GroupByYear_Works()
        {
            CarList list = new CarList();
            list.Add(new Car("A", "A", 2000, 100));
            list.Add(new Car("B", "B", 2020, 200));
            list.Add(new Car("C", "C", 2000, 150));

            var groups = list.GroupByYear().ToList();

            Assert.AreEqual(2, groups.Count); // 2 різні роки
            var group2000 = groups.FirstOrDefault(g => g.Key == 2000);
            Assert.IsNotNull(group2000);
            Assert.AreEqual(2, group2000.Count());
        }

        [TestMethod]
        public void AverageMileage_Works()
        {
            CarList list = new CarList();
            list.Add(new Car("A", "A", 2000, 100));
            list.Add(new Car("B", "B", 2000, 300));

            var avg = list.AverageMileage();

            Assert.AreEqual(200, avg);
        }

        [TestMethod]
        public void CountByYear_Works()
        {
            CarList list = new CarList();
            list.Add(new Car("A", "A", 2000, 100));
            list.Add(new Car("B", "B", 2000, 300));
            list.Add(new Car("C", "C", 2010, 400));

            var dict = list.CountByYear();

            Assert.AreEqual(2, dict[2000]);
            Assert.AreEqual(1, dict[2010]);
        }

        [TestMethod]
        public void MaxMileageForBrand_Works()
        {
            CarList list = new CarList();
            list.Add(new Car("Toyota", "A", 2000, 100));
            list.Add(new Car("Toyota", "B", 2005, 300));
            list.Add(new Car("Ford", "C", 2010, 400));

            int maxMileage = list.MaxMileageForBrand("Toyota");

            Assert.AreEqual(300, maxMileage);
        }

        // Інтеграційні тести для Save/Load

        [TestMethod]
        public void SaveToFile_And_LoadFromFile_WorkCorrectly()
        {
            string tempFile = Path.GetTempFileName();

            try
            {
                CarList listToSave = new CarList();
                listToSave.Add(new Car("Toyota", "Ivanov", 2015, 50000));
                listToSave.Add(new Car("Ford", "Petrenko", 2018, 30000));

                listToSave.SaveToFile(tempFile);

                CarList listLoaded = new CarList();
                listLoaded.LoadFromFile(tempFile);

                Assert.AreEqual(listToSave.Cars.Count, listLoaded.Cars.Count);

                for (int i = 0; i < listToSave.Cars.Count; i++)
                {
                    Assert.AreEqual(listToSave.Cars[i].Brand, listLoaded.Cars[i].Brand);
                    Assert.AreEqual(listToSave.Cars[i].OwnerSurname, listLoaded.Cars[i].OwnerSurname);
                    Assert.AreEqual(listToSave.Cars[i].Year, listLoaded.Cars[i].Year);
                    Assert.AreEqual(listToSave.Cars[i].Mileage, listLoaded.Cars[i].Mileage);
                }
            }
            finally
            {
                if (File.Exists(tempFile))
                    File.Delete(tempFile);
            }
        }

        [TestMethod]
        public void LoadFromFile_InvalidPath_ThrowsException()
        {
            CarList list = new CarList();

            Assert.ThrowsException<FileNotFoundException>(() =>
                list.LoadFromFile("non_existing_file.txt"));
        }
    }
}
