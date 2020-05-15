using NUnit.Framework;
using System;
using Model;

namespace NUnitTest
{
    [TestFixture]
    public class GlassParamsTest
    {

        [Test]
        [TestCase(0.015, 0.003, 0.045, 0.02, 0.003, 0.003, 0.003, TestName = "Позитивный тест конструктора для стеклянного стакана ")]
        public void GlassParamsTest_CorrectValue(double bottomRadius, double bottomThickness, double height, double topRadius,
            double topThickness, double topWidth, double wallThickness)
        {
            GlassParams glass = new GlassParams(15, 3, 45, 20, 3, 3, 3);

                Assert.AreEqual
                    (bottomRadius, glass.BottomRadius,
                    "Некорректное значение радиуса дна");
                Assert.AreEqual
                    (topRadius, glass.TopRadius,
                    "Некорректное значение радиуса горлышка");
                Assert.AreEqual
                     (height, glass.Height,
                    "Некорректное значение высоты");
                Assert.AreEqual
                    (topThickness, glass.TopThickness,
                    "Некорректное значение толщины горлышка");
                Assert.AreEqual
                     (topWidth, glass.TopWidth,
                    "Некорректное значение ширины горлышка");
                Assert.AreEqual
                   (bottomThickness, glass.BottomThickness,
                   "Некорректное значение толщины дна");
                Assert.AreEqual
                     (wallThickness, glass.WallThickness,
                    "Некорректное значение толщины стенок");
        }

        [TestCase(0.015, 0.045, 0.02, TestName = "Позитивный тест конструктора для бумажного стакана ")]
        public void GlassParamsPaperTest_CorrectValue(double bottomRadius, double height, double topRadius)
        {
            GlassParams paperGlass = new GlassParams(15, 45, 20);

            Assert.AreEqual
                (bottomRadius, paperGlass.BottomRadius,
                "Некорректное значение радиуса дна");
            Assert.AreEqual
                (topRadius, paperGlass.TopRadius,
                "Некорректное значение радиуса горлышка");
            Assert.AreEqual
                 (height, paperGlass.Height,
                "Некорректное значение высоты");
           
        }
        [TestCase(0.015, 0.003, 0.045, 0.05, 0.003, 0.003, 0.003, "topRadius", TestName = "Негативный тест конструктора при выходе за диапазон значения радиуса горлышка стекляного стакана")]
        [TestCase(0.015, 0.012, 0.045, 0.02, 0.003, 0.003, 0.003, "bottomThickness", TestName = "Негативный тест конструктора при выходе за диапазон значения толщины дна стекляного стакана")]
        [TestCase(0.015, 0.003, 0.045, 0.02, 0.003, 0.003, 0.012, "wallThickness", TestName = "Негативный тест конструктора при выходе за диапазон значения толщины стенок стекляного стакана")]
        [TestCase(0.015, 0.003, 0.045, 0.02, 0.012, 0.003, 0.003, "topThickness", TestName = "Негативный тест конструктора при выходе за диапазон значения толщины горлышка стекляного стакана")]
        public void GlassParamsTest_IsInRange(double bottomRadius, double bottomThickness, double height, double topRadius,
            double topThickness, double topWidth, double wallThickness, string attr)
        {
            Assert.Throws<ArgumentException>(
              () => {
                  GlassParams glass = new GlassParams(bottomRadius, bottomThickness, height, topRadius, topThickness, topWidth, wallThickness);
              },
               "Должно возникнуть исключение если значение поля "
               + attr + "выходит за диапозон доп-х значений");
        }

        [TestCase(0.015, 0.045, 0.05, "topRadius", TestName = "Негативный тест конструктора при выходе за диапазон значения радиуса горлышка бумажного стакана")]
        public void GlassParamsPaperTest_IsInRange(double bottomRadius, double height, double topRadius, string attr)
        {
            Assert.Throws<ArgumentException>(
               () => {
                   GlassParams glass = new GlassParams(bottomRadius, height, topRadius);
               },
                "Должно возникнуть исключение если значение поля "
                + attr + "выходит за диапозон доп-х значений");
        }


    }
}