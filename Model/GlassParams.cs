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
        /// Значение толщины бумаги
        /// </summary>
        double papperThicknes = 0.004;
        /// <summary>
        /// Значение толщины горлышка для бумажного стакана
        /// </summary>
        double papperTopThickness = 0.005;
        /// <summary>
        /// Значение ширины горлышка для бумажного стакана
        /// </summary>
        double papperTopWidth = 0.003;

        #endregion
        /// <summary>
        /// Конструктор для стакана из стекла
        /// </summary>
        /// <param name="bottomRadius"></param>
        /// <param name="bottomThickness"></param>
        /// <param name="height"></param>
        /// <param name="topRadius"></param>
        /// <param name="topThickness"></param>
        /// <param name="topWidth"></param>
        /// <param name="wallThickness"></param>
        public GlassParams(double bottomRadius, double bottomThickness, double height, double topRadius, double topThickness, double topWidth, double wallThickness)
        {
            //validation

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
            //validation

            // Перевод введенных параметров в метры,
            // присвоение значений, заданных константами
            _bottomRadius = bottomRadius/1000;
            _bottomThickness = papperThicknes;
            _height = height/1000;
            _topRadius = topRadius/1000;
            _topThickness = papperTopThickness;
            _topWidth = papperTopWidth;
            _wallThickness = papperThicknes;
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
