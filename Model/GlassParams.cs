using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GlassParams
    {
        #region Private params
        /// <summary>
        /// Радиус дна стакана
        /// </summary>
        private double _bottomRadius;

        /// <summary>
        /// Толщина дна стакана
        /// </summary>
        private double _bottomThickness;

        /// <summary>
        /// Высота стакана
        /// </summary>
        private double _height;

        /// <summary>
        /// Радиус горлышка стакана
        /// </summary>
        private double _topRadius;

        /// <summary>
        /// Толщина горлышка стакана
        /// </summary>
        private double _topThickness;

        /// <summary>
        /// Ширина горлышка стакана
        /// </summary>
        private double _topWidth;

        /// <summary>
        /// Толщина стенок стакана
        /// </summary>
        private double _wallThickness;
        #endregion

        #region Const
        /// <summary>
        /// Значение толщины бумаги в мм
        /// </summary>
        double papperThicknes = 4;
        /// <summary>
        /// Значение толщины горлышка для бумажного стакана в мм
        /// </summary>
        double papperTopThickness = 5;
        /// <summary>
        /// Значение ширины горлышка для бумажного стакана в мм
        /// </summary>
        double papperTopWidth = 3;

        int minBottomRadius = 15;
        int maxBottomRadius = 80;

        int minBottomThickness = 3;
        int maxbottomThickness = 24;

        int minHeight = 45;
        int maxHeight = 500;

        int minTopRadius = 15;
        int maxTopRadius = 120;

        int maxTopThickness = 75;

        int maxTopWidth = 20;

        int minWallThickness = 3;
        int maxWallThickness = 24;

        #endregion
        /// <summary>
        /// Конструктор для стакана из стекла
        /// </summary>
        public GlassParams(double bottomRadius, double bottomThickness, double height, double topRadius, 
            double topThickness, double topWidth, double wallThickness)
        {
            IsCorrectType(bottomRadius, bottomThickness, height, topRadius,
            topThickness, topWidth, wallThickness);
            IsInRange(bottomRadius, bottomThickness, height, topRadius,
            topThickness, topWidth, wallThickness);

            // Перевод введенных параметров в метры
            _bottomRadius = bottomRadius/1000;
            _bottomThickness = bottomThickness/1000;
            _height = height/1000;
            _topRadius = topRadius/1000;
            _topThickness = topThickness/1000;
            _topWidth = topWidth/1000;
            _wallThickness = wallThickness/1000;
        }
        /// <summary>
        /// Конструктор для стакана из бумаги
        /// </summary>
        /// <param name="bottomRadius"></param>
        /// <param name="height"></param>
        /// <param name="topRadius"></param>
        public GlassParams(double bottomRadius, double height, double topRadius)
        {

            IsCorrectType(bottomRadius, height, topRadius);
            IsInRange(bottomRadius, height, topRadius);

            // Перевод введенных параметров в метры,
            // присвоение значений, заданных константами
            _bottomRadius = bottomRadius/1000;
            _bottomThickness = papperThicknes/1000;
            _height = height/1000;
            _topRadius = topRadius/1000;
            _topThickness = papperTopThickness/1000;
            _topWidth = papperTopWidth/1000;
            _wallThickness = papperThicknes/1000;
        }
        private void IsCorrect(List<string> errorList, double value, string name)
        {
            if (double.IsNaN(value) || double.IsInfinity(value))
            {
                errorList.Add($"Значение поля '{name}' бесконечно или не существует.\n");
            }
        }

        private void IsCorrectType(double bottomRadius, double bottomThickness, double height, double topRadius,
            double topThickness, double topWidth, double wallThickness)
        {
            var errorMessage = new List<string>();

            IsCorrect(errorMessage, bottomRadius, "Радиус дна");
            IsCorrect(errorMessage, bottomThickness, "Радиус горлышка");
            IsCorrect(errorMessage, height, "Высота стакана");
            IsCorrect(errorMessage, topRadius, "Толщина дна");
            IsCorrect(errorMessage, topThickness, "Толщина горлышка");
            IsCorrect(errorMessage, topWidth, "Ширина горлышка");
            IsCorrect(errorMessage, wallThickness, "Толщина стенки");

            if (errorMessage.Count > 0)
            {
                throw new ArgumentException(string.Join("\n", errorMessage));
            }
        }

        private void IsCorrectType(double bottomRadius, double height, double topRadius)
        {
            var errorMessage = new List<string>();

            IsCorrect(errorMessage, bottomRadius, "Радиус дна");
            IsCorrect(errorMessage, height, "Высота стакана");
            IsCorrect(errorMessage, topRadius, "Толщина дна");

            if (errorMessage.Count > 0)
            {
                throw new ArgumentException(string.Join("\n", errorMessage));
            }
        }
        private void IsInRange(double bottomRadius, double bottomThickness, double height, double topRadius,
            double topThickness, double topWidth, double wallThickness)
        {
            var errorMessage = new List<string>();
            //проверка радиуса дна
            if (bottomRadius < minBottomRadius || bottomRadius > maxBottomRadius)
            {
                errorMessage.Add("Область допустимых значений дна стакана: " +
                    "от " + minBottomRadius + "до" + maxBottomRadius + ".\n");
            }
            //проверка радиуса горлышка
            if (topRadius < minTopRadius || topRadius > maxTopRadius)
            {
                errorMessage.Add("Область допустимых значений горлышка стакана: " +
                    "от " + minTopRadius + "до" + maxTopRadius + ".\n");
            }
            else if (topRadius < bottomRadius || topRadius > (1.5 * bottomRadius))
            {
                errorMessage.Add("Нарушены пропорции стакана. Область допустимых значений горлышка стакана: " +
                    "от " + bottomRadius + "до" + (1.5 * bottomRadius) + ".\n");
            }
            //проверка высоты стакана
            if (height < minHeight || (height > maxHeight))
            {
                errorMessage.Add("Область допустимых значений высоты стакана: " +
                    "от " + minHeight + "до" + maxHeight + ".\n");
            }
            //проверка толщины дна
            if (bottomThickness < minBottomThickness || (bottomThickness > maxbottomThickness))
            {
                errorMessage.Add("Область допустимых значений толщины дна стакана: " +
                    "от " + minBottomThickness + "до" + maxbottomThickness + ".\n");
            }
            else if (bottomThickness > 0.3 * height)
            {
                errorMessage.Add("Нарушены пропорции стакана. Область допустимых значений толщины дна стакана: " +
                    "от " + minBottomThickness + "до" + (0.3 * height + ".\n"));
            }
            //проверка толщины стенок стакана
            if (wallThickness < minWallThickness || (wallThickness > maxWallThickness))
            {
                errorMessage.Add("Область допустимых значений толщины стенок стакана: " +
                    "от " + minBottomThickness + "до" + maxbottomThickness + ".\n");
            }
            else if(wallThickness > 0.2 * bottomRadius)
            {
                errorMessage.Add("Нарушены пропорции стакана. Область допустимых значений толщины стенок стакана: " +
                    "от " + minWallThickness + "до" + (0.2 * bottomRadius + ".\n"));
            }
            //проверка толщины горлышка 
            if (topThickness > maxTopThickness)
            {
                errorMessage.Add("Область допустимых значений толщины горлышка стакана: " +
                    "от 0 до" + maxTopThickness + ".\n");
            }
            else if ((0.15 * height) < topThickness)
            {
                errorMessage.Add("Нарушены пропорции стакана. Область допустимых значений толщины горлышка стакана: " +
                    "от 0 до" + (0.15 * height) + ".\n");
            }
            //проверка ширины горлышка
            if (topWidth > maxTopWidth)
            {
                errorMessage.Add("Область допустимых значений ширины горлышка стакана: " +
                    "от 0 до" + maxTopWidth + ".\n");
            }


            if (errorMessage.Count > 0)
            {
                throw new ArgumentException(string.Join("\n", errorMessage));
            }
        }
        private void IsInRange(double bottomRadius, double height, double topRadius)
        {
            var errorMessage = new List<string>();

            //проверка радиуса дна
            if (bottomRadius < minBottomRadius || bottomRadius > maxBottomRadius)
            {
                errorMessage.Add("Область допустимых значений дна стакана: " +
                    "от " + minBottomRadius + "до" + maxBottomRadius + ".\n");
            }
            //проверка радиуса горлышка
            if (topRadius < minTopRadius || topRadius > maxTopRadius)
            {
                errorMessage.Add("Область допустимых значений горлышка стакана: " +
                    "от " + minTopRadius + "до" + maxTopRadius + ".\n");
            }
            else if (topRadius < bottomRadius || topRadius > (1.5 * bottomRadius))
            {
                errorMessage.Add("Нарушены пропорции стакана. Область допустимых значений горлышка стакана: " +
                    "от " + bottomRadius + "до" + (1.5 * bottomRadius) + ".\n");
            }
            //проверка высоты стакана
            if (height < minHeight || (height > maxHeight))
            {
                errorMessage.Add("Область допустимых значений высоты стакана: " +
                    "от " + minHeight + "до" + maxHeight + ".\n");
            }
            if (errorMessage.Count > 0)
            {
                throw new ArgumentException(string.Join("\n", errorMessage));
            }
        }


            #region Get properties
            public double GetBottomRadius()
        {
            return _bottomRadius;
        }

        public double GetBottomThickness()
        {
            return _bottomThickness;
        }
        public double GetHeight()
        {
            return _height;
        }
        public double GetTopRadius()
        {
            return _topRadius;
        }
        public double GetTopThickness()
        {
            return _topThickness;
        }
        public double GetTopWidth()
        {
            return _topWidth;
        }
        public double GetWallThickness()
        {
            return _wallThickness;
        }
        #endregion
    }
}
