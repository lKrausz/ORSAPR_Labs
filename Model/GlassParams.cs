using System;
using System.Collections.Generic;


namespace Model
{   /// <summary>
    /// Класс, содержащий параметры стакана
    /// </summary>
    public class GlassParams
    {
        #region Params
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
        private const double PaperThicknes = 4;

        /// <summary>
        /// Значение толщины горлышка для бумажного стакана в мм
        /// </summary>
        private const double PaperTopThickness = 5;

        /// <summary>
        /// Значение ширины горлышка для бумажного стакана в мм
        /// </summary>
        private const double PaperTopWidth = 3;
        #endregion

        #region Значение max и min значений параметров стакана
        public const int MinBottomRadius = 15;
        public const int MaxBottomRadius = 80;

        public const int MinTopRadius = 15;
        public const int MaxTopRadius = 120;

        public const int MinHeight = 45;
        public const int MaxHeight = 480;

        public const int MinTopThickness = 0;
        public const int MaxTopThickness = 72;

        public const int MinTopWidth = 0;
        public const int MaxTopWidth = 20;

        public const int MinWallThickness = 3;
        public const int MaxWallThickness = 16;

        public const int MinBottomThickness = 3;
        public const int MaxbottomThickness = 144;
        #endregion

        #region Constructor
        /// <summary>
        /// Конструктор для стакана из стекла
        /// </summary>
        public GlassParams(double bottomRadius, double bottomThickness, double height, double topRadius, 
            double topThickness, double topWidth, double wallThickness)
        {
            IsInRange(bottomRadius, topRadius, 1.5 * bottomRadius, "Радиус горлышка");
            IsInRange(MinBottomThickness, bottomThickness, 0.3 * height, "Толщина дна");
            IsInRange(MinTopThickness, topThickness, 0.15 * height, "Толщина горлышка");
            IsInRange(MinWallThickness, wallThickness, 0.2 * bottomRadius, "Толщина стенок");
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
            IsInRange(bottomRadius, topRadius, 1.5 * bottomRadius, "Радиус горлышка");
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
        #endregion
        /// <summary>
        /// Проверка на нахождение зависимых параметров стакана в допустимых границах
        /// </summary>
        /// <param name="minValue">Минимальная граница</param>
        /// <param name="value">Текущее значение параметра</param>
        /// <param name="maxValue">Максимаьная граница</param>
        /// <param name="name">Имя текущего параметра</param>
        private void IsInRange(double minValue, double value, double maxValue, string name)
        {
            string hint;
            if (value < minValue || value > maxValue)
            {
                hint = "Нарушены параметры стакана. Область допустимых значений: " + name +
                    " от " + minValue + " до " + maxValue + ".\n";
                throw new ArgumentException(hint);
            }
        }
    }
}
