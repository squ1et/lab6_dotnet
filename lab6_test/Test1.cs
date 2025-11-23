using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab6_dotnet;
using System;

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
    }
}
