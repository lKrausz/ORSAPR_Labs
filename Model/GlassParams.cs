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

        public GlassParams(double bottomRadius, double bottomThickness, double height, double topRadius, double topThickness, double topWidth, double wallThickness)
        {
            //validation

            _bottomRadius = bottomRadius;
            _bottomThickness = bottomThickness;
            _height = height;
            _topRadius = topRadius;
            _topThickness = topThickness;
            _topWidth = topWidth;
            _wallThickness = wallThickness;
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
