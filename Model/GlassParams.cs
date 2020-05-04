using System;
using System.Collections.Generic;

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
        //Значения констант для бумажного стакана

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

        #endregion

        /// <summary>
        /// Конструктор для стакана из стекла
        /// </summary>
        public GlassParams(double bottomRadius, double bottomThickness, double height, double topRadius, 
            double topThickness, double topWidth, double wallThickness)
        {
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
