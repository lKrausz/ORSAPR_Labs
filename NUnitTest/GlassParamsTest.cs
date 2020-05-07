using NUnit.Framework;
using System;
using Model;

namespace NUnitTest
{
    [TestFixture]
    public class GlassParamsTest
    {
        private GlassParams _glass = new GlassParams(15, 20, 45, 3, 3, 3, 3);
        private GlassParams _paperGlass = new GlassParams(15, 20, 45);

        [Test]
        [TestCase(0.015, 0.02, 0.045, 0.003, 0.003, 0.003, 0.003, TestName = "Тест конструктора для стеклянного стакана ")]
        public void ConstructorTest(double bottomRadius, double bottomThickness, double height, double topRadius,
            double topThickness, double topWidth, double wallThickness)
        {
            var actual = _glass;

            Assert.AreEqual
                (bottomRadius, actual.BottomRadius,
                "Некорректное значение радиуса дна");
            Assert.AreEqual
                (topRadius, actual.TopRadius,
                "Некорректное значение радиуса горлышка");
            Assert.AreEqual
                 (height, actual.Height,
                "Некорректное значение высоты");
            Assert.AreEqual
                (topThickness, actual.TopThickness,
                "Некорректное значение толщины горлышка");
            Assert.AreEqual
                 (topWidth, actual.TopWidth,
                "Некорректное значение ширины горлышка");
            Assert.AreEqual
               (bottomThickness, actual.BottomThickness,
               "Некорректное значение толщины дна");
            Assert.AreEqual
                 (wallThickness, actual.WallThickness,
                "Некорректное значение толщины стенок");
        }

        [Test]
        [TestCase(0.015, 0.02, 0.045, TestName = "Тест конструктора для бумажного стакана ")]
        public void PaperConstructorTest(double bottomRadius, double height, double topRadius)
        {
            var actual = _paperGlass;

            Assert.AreEqual
                (bottomRadius, actual.BottomRadius,
                "Некорректное значение радиуса дна");
            Assert.AreEqual
                (topRadius, actual.TopRadius,
                "Некорректное значение радиуса горлышка");
            Assert.AreEqual
                 (height, actual.Height,
                "Некорректное значение высоты");
           
        }



    }
}