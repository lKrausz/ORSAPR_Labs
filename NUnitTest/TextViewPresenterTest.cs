using NUnit.Framework;
using System;
using Model;

namespace NUnitTest
{
    [TestFixture]
    public class TextViewPresenterTest
    {
        [TestCase(TextViewType.BottomRadius, 20, TestName = "Позитивный тест валидации радиуса дна стакана ")]
        [TestCase(TextViewType.TopRadius, 50, TestName = "Позитивный тест валидации радиуса горлышка стакана ")]
        [TestCase(TextViewType.Height, 120, TestName = "Позитивный тест валидации высоты стакана ")]
        [TestCase(TextViewType.TopThickness, 5, TestName = "Позитивный тест валидации толщины горлышка стакана ")]
        [TestCase(TextViewType.TopWidth, 5, TestName = "Позитивный тест валидации ширины горлышка стакана ")]
        [TestCase(TextViewType.BottomThickness, 5, TestName = "Позитивный тест валидации толщины дна стакана ")]
        [TestCase(TextViewType.WallThickness, 5, TestName = "Позитивный тест валидации толщины стенок стакана ")]
        public void ValidationTest(TextViewType type, double value)
        {
            TextViewValidation.Validation(type, value);
        }


        [TestCase(TextViewType.BottomRadius, 2, "BottomRadius", TestName = "Негативный тест валидации радиуса дна стакана ")]
        [TestCase(TextViewType.TopRadius, 2, "TopRadius", TestName = "Негативный тест валидации радиуса горлышка стакана ")]
        [TestCase(TextViewType.Height, 2, "Height", TestName = "Негативный тест валидации высоты стакана ")]
        [TestCase(TextViewType.TopThickness, 90, "TopThickness", TestName = "Негативный тест валидации толщины горлышка стакана ")]
        [TestCase(TextViewType.TopWidth, 30, "TopWidth", TestName = "Негативный тест валидации ширины горлышка стакана ")]
        [TestCase(TextViewType.BottomThickness, 30, "BottomThickness", TestName = "Негативный тест валидации толщины дна стакана ")]
        [TestCase(TextViewType.WallThickness, 30, "WallThickness", TestName = "Негативный тест валидации толщины стенок стакана ")]
        public void ValidationNegativeTest(TextViewType type, double value, string attr)
        {
            Assert.Throws<ArgumentException>(
              () => {
                  TextViewValidation.Validation(type, value);
              },
               "Должно возникнуть исключение если значение поля "
               + attr + "выходит за диапозон доп-х значений");
        }
    }
}