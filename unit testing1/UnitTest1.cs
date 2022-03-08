using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;
namespace unit_testing1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFeetToMiles()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.fromUnit = DistanceConverter.MILES;
            converter.toUnit = DistanceConverter.FEET;

            converter.fromDistance = 2.0;
            converter.CalculateDistance();
            double expectedDistance = 10560;
            Assert.AreEqual(expectedDistance, converter.toDistance);
        }
        [TestMethod]
        public void TestMilesToFeet()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.fromUnit = DistanceConverter.FEET;
            converter.toUnit = DistanceConverter.MILES;

            converter.fromDistance = 10560;
            converter.CalculateDistance();
            double expectedDistance = 2.0;
            Assert.AreEqual(expectedDistance, converter.toDistance);
        }
        [TestMethod]
        public void TestMilesToMetres()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.fromUnit = DistanceConverter.MILES;
            converter.toUnit = DistanceConverter.METRES;

            converter.fromDistance = 2.0;
            converter.CalculateDistance();
            double expectedDistance = 3218;
            Assert.AreEqual(expectedDistance,(int)converter.toDistance);
        }
        [TestMethod]
        public void TestMetresToMiles()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.fromUnit = DistanceConverter.METRES;
            converter.toUnit = DistanceConverter.MILES;

            converter.fromDistance = 3218.69;
            converter.CalculateDistance();
            double expectedDistance = 2;
            Assert.AreEqual(expectedDistance, (int)converter.toDistance);
        }
        [TestMethod]
        public void TestMetresToFeet()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.fromUnit = DistanceConverter.METRES;
            converter.toUnit = DistanceConverter.FEET;

            converter.fromDistance = 2.0;
            converter.CalculateDistance();
            double expectedDistance = 6.5616798;
            Assert.AreEqual(expectedDistance, (int)converter.toDistance);
        }
        [TestMethod]
        public void TestFeetToMetres()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.fromUnit = DistanceConverter.METRES;
            converter.toUnit = DistanceConverter.FEET;

            converter.fromDistance = 6.56168;
            converter.CalculateDistance();
            double expectedDistance = 2.0;
            Assert.AreEqual(expectedDistance, (int)converter.toDistance);
        }


    }

}