using NUnit.Framework;
using System;
using Model;

namespace NUnitTest
{
    [TestFixture]
    public class ValidatorTest
    {
        [TestCase(Params.BottomRadius, 20, TestName = "Позитивный тест валидации радиуса дна стакана ")]
        [TestCase(Params.TopRadius, 50, TestName = "Позитивный тест валидации радиуса горлышка стакана ")]
        [TestCase(Params.Height, 120, TestName = "Позитивный тест валидации высоты стакана ")]
        [TestCase(Params.TopThickness, 5, TestName = "Позитивный тест валидации толщины горлышка стакана ")]
        [TestCase(Params.TopWidth, 5, TestName = "Позитивный тест валидации ширины горлышка стакана ")]
        [TestCase(Params.BottomThickness, 5, TestName = "Позитивный тест валидации толщины дна стакана ")]
        [TestCase(Params.WallThickness, 5, TestName = "Позитивный тест валидации толщины стенок стакана ")]
        public void ValidationTest(Params type, double value)
        {
            Model.Validator.Validation(type, value);
        }


        [TestCase(Params.BottomRadius, 2, "BottomRadius", TestName = "Негативный тест валидации радиуса дна стакана ")]
        [TestCase(Params.TopRadius, 2, "TopRadius", TestName = "Негативный тест валидации радиуса горлышка стакана ")]
        [TestCase(Params.Height, 2, "Height", TestName = "Негативный тест валидации высоты стакана ")]
        [TestCase(Params.TopThickness, 90, "TopThickness", TestName = "Негативный тест валидации толщины горлышка стакана ")]
        [TestCase(Params.TopWidth, 30, "TopWidth", TestName = "Негативный тест валидации ширины горлышка стакана ")]
        [TestCase(Params.BottomThickness, 30, "BottomThickness", TestName = "Негативный тест валидации толщины дна стакана ")]
        [TestCase(Params.WallThickness, 30, "WallThickness", TestName = "Негативный тест валидации толщины стенок стакана ")]
        public void ValidationNegativeTest(Params type, double value, string attr)
        {
            Assert.Throws<ArgumentException>(
              () => {
                  Model.Validator.Validation(type, value);
              },
               "Должно возникнуть исключение если значение поля "
               + attr + "выходит за диапозон доп-х значений");
        }
    }
}