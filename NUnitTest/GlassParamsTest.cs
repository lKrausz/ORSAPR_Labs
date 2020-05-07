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
        [TestCase(0.015, 0.02, 0.045, 0.003, 0.003, 0.003, 0.003, TestName = "���� ������������ ��� ����������� ������� ")]
        public void ConstructorTest(double bottomRadius, double bottomThickness, double height, double topRadius,
            double topThickness, double topWidth, double wallThickness)
        {
            var actual = _glass;

            Assert.AreEqual
                (bottomRadius, actual.BottomRadius,
                "������������ �������� ������� ���");
            Assert.AreEqual
                (topRadius, actual.TopRadius,
                "������������ �������� ������� ��������");
            Assert.AreEqual
                 (height, actual.Height,
                "������������ �������� ������");
            Assert.AreEqual
                (topThickness, actual.TopThickness,
                "������������ �������� ������� ��������");
            Assert.AreEqual
                 (topWidth, actual.TopWidth,
                "������������ �������� ������ ��������");
            Assert.AreEqual
               (bottomThickness, actual.BottomThickness,
               "������������ �������� ������� ���");
            Assert.AreEqual
                 (wallThickness, actual.WallThickness,
                "������������ �������� ������� ������");
        }

        [Test]
        [TestCase(0.015, 0.02, 0.045, TestName = "���� ������������ ��� ��������� ������� ")]
        public void PaperConstructorTest(double bottomRadius, double height, double topRadius)
        {
            var actual = _paperGlass;

            Assert.AreEqual
                (bottomRadius, actual.BottomRadius,
                "������������ �������� ������� ���");
            Assert.AreEqual
                (topRadius, actual.TopRadius,
                "������������ �������� ������� ��������");
            Assert.AreEqual
                 (height, actual.Height,
                "������������ �������� ������");
           
        }



    }
}