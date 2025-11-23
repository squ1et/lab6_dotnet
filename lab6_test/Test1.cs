using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab6_dotnet;
using System;
using System.IO;
using System.Collections.Generic;

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

            Assert.AreEqual(0, result.Count);
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
