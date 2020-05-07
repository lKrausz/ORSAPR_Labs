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
        public double BottomRadius { get; private set; }

        /// <summary>
        /// Толщина дна стакана
        /// </summary>
        public double BottomThickness { get; private set; }

        /// <summary>
        /// Высота стакана
        /// </summary>
        public double Height { get; private set; }

        /// <summary>
        /// Радиус горлышка стакана
        /// </summary>
        public double TopRadius { get; private set; }

        /// <summary>
        /// Толщина горлышка стакана
        /// </summary>
        public double TopThickness { get; private set; }

        /// <summary>
        /// Ширина горлышка стакана
        /// </summary>
        public double TopWidth { get; private set; }

        /// <summary>
        /// Толщина стенок стакана
        /// </summary>
        public double WallThickness { get; private set; }
        #endregion

        #region Const
        //Значения констант для бумажного стакана

        /// <summary>
        /// Значение толщины бумаги в мм
        /// </summary>
        public const double PaperThicknes = 4;

        /// <summary>
        /// Значение толщины горлышка для бумажного стакана в мм
        /// </summary>
        public const double PaperTopThickness = 5;

        /// <summary>
        /// Значение ширины горлышка для бумажного стакана в мм
        /// </summary>
        public const double PaperTopWidth = 3;
        #endregion

        /// <summary>
        /// Конструктор для стакана из стекла
        /// </summary>
        public GlassParams(double bottomRadius, double bottomThickness, double height, double topRadius, 
            double topThickness, double topWidth, double wallThickness)
        {
            // Перевод введенных параметров в метры
            BottomRadius = bottomRadius/1000;
            BottomThickness = bottomThickness/1000;
            Height = height/1000;
            TopRadius = topRadius/1000;
            TopThickness = topThickness/1000;
            TopWidth = topWidth/1000;
            WallThickness = wallThickness/1000;
        }
        /// <summary>
        /// Конструктор для стакана из бумаги
        /// </summary>
        public GlassParams(double bottomRadius, double height, double topRadius)
        {
            // Перевод введенных параметров в метры,
            // присвоение значений, заданных константами
            BottomRadius = bottomRadius/1000;
            BottomThickness = PaperThicknes/1000;
            Height = height/1000;
            TopRadius = topRadius/1000;
            TopThickness = PaperTopThickness/1000;
            TopWidth = PaperTopWidth/1000;
            WallThickness = PaperThicknes/1000;
        }

    }
}
