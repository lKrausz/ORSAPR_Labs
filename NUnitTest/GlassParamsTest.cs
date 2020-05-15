using NUnit.Framework;
using System;
using Model;

namespace NUnitTest
{
    [TestFixture]
    public class GlassParamsTest
    {

        [Test]
        [TestCase(0.015, 0.003, 0.045, 0.02, 0.003, 0.003, 0.003, TestName = "���������� ���� ������������ ��� ����������� ������� ")]
        public void GlassParamsTest_CorrectValue(double bottomRadius, double bottomThickness, double height, double topRadius,
            double topThickness, double topWidth, double wallThickness)
        {
            GlassParams glass = new GlassParams(15, 3, 45, 20, 3, 3, 3);

                Assert.AreEqual
                    (bottomRadius, glass.BottomRadius,
                    "������������ �������� ������� ���");
                Assert.AreEqual
                    (topRadius, glass.TopRadius,
                    "������������ �������� ������� ��������");
                Assert.AreEqual
                     (height, glass.Height,
                    "������������ �������� ������");
                Assert.AreEqual
                    (topThickness, glass.TopThickness,
                    "������������ �������� ������� ��������");
                Assert.AreEqual
                     (topWidth, glass.TopWidth,
                    "������������ �������� ������ ��������");
                Assert.AreEqual
                   (bottomThickness, glass.BottomThickness,
                   "������������ �������� ������� ���");
                Assert.AreEqual
                     (wallThickness, glass.WallThickness,
                    "������������ �������� ������� ������");
        }

        [TestCase(0.015, 0.045, 0.02, TestName = "���������� ���� ������������ ��� ��������� ������� ")]
        public void GlassParamsPaperTest_CorrectValue(double bottomRadius, double height, double topRadius)
        {
            GlassParams paperGlass = new GlassParams(15, 45, 20);

            Assert.AreEqual
                (bottomRadius, paperGlass.BottomRadius,
                "������������ �������� ������� ���");
            Assert.AreEqual
                (topRadius, paperGlass.TopRadius,
                "������������ �������� ������� ��������");
            Assert.AreEqual
                 (height, paperGlass.Height,
                "������������ �������� ������");
           
        }
        [TestCase(0.015, 0.003, 0.045, 0.05, 0.003, 0.003, 0.003, "topRadius", TestName = "���������� ���� ������������ ��� ������ �� �������� �������� ������� �������� ���������� �������")]
        [TestCase(0.015, 0.012, 0.045, 0.02, 0.003, 0.003, 0.003, "bottomThickness", TestName = "���������� ���� ������������ ��� ������ �� �������� �������� ������� ��� ���������� �������")]
        [TestCase(0.015, 0.003, 0.045, 0.02, 0.003, 0.003, 0.012, "wallThickness", TestName = "���������� ���� ������������ ��� ������ �� �������� �������� ������� ������ ���������� �������")]
        [TestCase(0.015, 0.003, 0.045, 0.02, 0.012, 0.003, 0.003, "topThickness", TestName = "���������� ���� ������������ ��� ������ �� �������� �������� ������� �������� ���������� �������")]
        public void GlassParamsTest_IsInRange(double bottomRadius, double bottomThickness, double height, double topRadius,
            double topThickness, double topWidth, double wallThickness, string attr)
        {
            Assert.Throws<ArgumentException>(
              () => {
                  GlassParams glass = new GlassParams(bottomRadius, bottomThickness, height, topRadius, topThickness, topWidth, wallThickness);
              },
               "������ ���������� ���������� ���� �������� ���� "
               + attr + "������� �� �������� ���-� ��������");
        }

        [TestCase(0.015, 0.045, 0.05, "topRadius", TestName = "���������� ���� ������������ ��� ������ �� �������� �������� ������� �������� ��������� �������")]
        public void GlassParamsPaperTest_IsInRange(double bottomRadius, double height, double topRadius, string attr)
        {
            Assert.Throws<ArgumentException>(
               () => {
                   GlassParams glass = new GlassParams(bottomRadius, height, topRadius);
               },
                "������ ���������� ���������� ���� �������� ���� "
                + attr + "������� �� �������� ���-� ��������");
        }


    }
}