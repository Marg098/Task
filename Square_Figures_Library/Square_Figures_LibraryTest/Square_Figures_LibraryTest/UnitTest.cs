using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Square_Figures_Library;

namespace Square_Figures_LibraryTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void AreaCircle_20_1257returned()
        {
            //arrange
            double r = 20;
            double expected = 1257;
            //act
            Circle shape = new Circle(r);
            double actual = shape.Area();
            //assert
            Assert.AreEqual(expected, Math.Round(actual));

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "The radius value must be positive.")]
        public void ParamCircle_posit()
        {
            //arrange
            double r = -1;  
            //act
            Circle shape = new Circle(r);
        }

        [TestMethod]
        public void AreaTriangle_4_6_8_12returned()
        {
            //arrange
            double a = 4;
            double b = 6;
            double c = 8;
            double expected = 12;
            //act
            Triangle shape = new Triangle(a, b, c);
            double actual = shape.Area();
            //assert
            Assert.AreEqual(expected, Math.Round(actual));

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "The value ​​of side must be positive.")]
        public void ParamTriangle_posit()
        {
            //arrange
            double a = -1;
            double b = 6;
            double c = 8;
            //act
            Triangle shape = new Triangle(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "The value of the larger side must be less than " +
            "the sum of the values ​​of other parties.")]
        public void ParamTriangle_incorr()
        {
            //arrange
            double a = 2;
            double b = 6;
            double c = 8;
            //act
            Triangle shape = new Triangle(a, b, c);
        }

        [TestMethod]
        public void RightTriangle_true_returned()
        {
            //arrange
            double a = 3;
            double b = 4;
            double c = 5;
            bool expected = true;
            //act
            Triangle shape = new Triangle(a, b, c);
            bool actual = shape.IsRighTriangle();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UnknownShape_15_707returned()
        {
            //arrange
            double a = 15;
            double expected = 707;
            //act
            UnknownFigure shape = new UnknownFigure();
            double actual = shape.AreaObject(a);
            //assert
            Assert.AreEqual(expected, Math.Round(actual));
        }

        [TestMethod]
        public void UnknownShape_3_4_5_6returned()
        {
            //arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;
            //act
            UnknownFigure shape = new UnknownFigure();
            double actual = shape.AreaObject(a, b, c);
            //assert
            Assert.AreEqual(expected, Math.Round(actual));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "Not enough data.")]
        public void UnknownShape_15_12()
        {
            //arrange
            double a = 15;
            double b = 12;
            //act
            UnknownFigure shape = new UnknownFigure();
            double actual = shape.AreaObject(a, b);
        }
    }
}
