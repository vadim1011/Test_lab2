
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_lab2
{
    [TestClass]
    public class AllLaboratoryTests
    {
        private const double Delta = 0.0001;

        //Вариант 1
        [TestMethod]
        public void ReversePositiveTest()
        {
            NumberUtils utils = new NumberUtils();
            Assert.AreEqual(4321, utils.ReverseNumber(1234));
        }

        [TestMethod]
        public void ReverseNegativeTest()
        {
            NumberUtils utils = new NumberUtils();
            Assert.AreEqual(-765, utils.ReverseNumber(-567));
        }

        [TestMethod]
        public void ReverseTrailingZeroTest()
        {
            NumberUtils utils = new NumberUtils();
            Assert.AreEqual(21, utils.ReverseNumber(120));
        }

        //Вариант 2
        [TestMethod]
        public void StandardAreaTest()
        {
            RoomUtils utils = new RoomUtils();
            Assert.AreEqual(12.0, utils.GetAreaPerPerson(6.0, 4.0, 2), Delta);
        }

        [TestMethod]
        public void InvalidDataTest()
        {
            RoomUtils utils = new RoomUtils();
            Assert.AreEqual(0, utils.GetAreaPerPerson(-5.0, 3.0, 2), Delta);
            Assert.AreEqual(0, utils.GetAreaPerPerson(4.0, 3.0, 0), Delta);
        }

        //Вариант 3
        [TestMethod]
        public void RealNumberOperationsTest()
        {
            RealNumber nr = new RealNumber { Value = 5.75 };
            Assert.AreEqual(5.8, nr.Round(1), Delta);
            Assert.AreEqual(5, nr.GetIntegerPart(), Delta);
            Assert.AreEqual(0.75, nr.GetFractionalPart(), Delta);
        }

        //Вариант 4 
        [TestMethod]
        public void MatrixTransposeTest()
        {
            SquareMatrix matrix = new SquareMatrix { Size = 2, Data = new int[,] { { 1, 2 }, { 3, 4 } } };
            matrix.TransposeMain();
            CollectionAssert.AreEqual(new int[,] { { 1, 3 }, { 2, 4 } }, matrix.Data);
        }
    }
}
