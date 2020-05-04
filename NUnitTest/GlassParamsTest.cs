using NUnit.Framework;
using System;
using Model;

namespace NUnitTest
{
    [TestFixture]
    public class GlassParamsTest
    {
        private GlassParams _glass;
        private GlassParams _paperGlass;

        [SetUp]
        public void Test()
        {
            _glass = new GlassParams(15, 20, 45, 3, 3, 3, 3);
            _paperGlass = new GlassParams(15, 20, 45);
        }

        [Test]
        [TestCase(0.015, 0.02, 0.045, 0.003, 0.003, 0.003, 0.003, TestName = "���� ������������ ��� ����������� ������� ")]
        public void ConstructorTest(double bottomRadius, double bottomThickness, double height, double topRadius,
            double topThickness, double topWidth, double wallThickness)
        {
            var actual = _glass;

            Assert.AreEqual
                (bottomRadius, actual.GetBottomRadius(),
                "������������ �������� ������� ���");
            Assert.AreEqual
                (topRadius, actual.GetTopRadius(),
                "������������ �������� ������� ��������");
            Assert.AreEqual
                 (height, actual.GetHeight(),
                "������������ �������� ������");
            Assert.AreEqual
                (topThickness, actual.GetTopThickness(),
                "������������ �������� ������� ��������");
            Assert.AreEqual
                 (topWidth, actual.GetTopWidth(),
                "������������ �������� ������ ��������");
            Assert.AreEqual
               (bottomThickness, actual.GetBottomThickness(),
               "������������ �������� ������� ���");
            Assert.AreEqual
                 (wallThickness, actual.GetWallThickness(),
                "������������ �������� ������� ������");
        }

        [Test]
        [TestCase(0.015, 0.02, 0.045, TestName = "���� ������������ ��� ��������� ������� ")]
        public void PaperConstructorTest(double bottomRadius, double height, double topRadius)
        {
            var actual = _paperGlass;

            Assert.AreEqual
                (bottomRadius, actual.GetBottomRadius(),
                "������������ �������� ������� ���");
            Assert.AreEqual
                (topRadius, actual.GetTopRadius(),
                "������������ �������� ������� ��������");
            Assert.AreEqual
                 (height, actual.GetHeight(),
                "������������ �������� ������");
           
        }



    }
}