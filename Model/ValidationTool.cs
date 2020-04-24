using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class ValidationTool
    {
        /// <summary>
        /// Статистический класс, проверяющий корректность значений, введенных пользователем
        /// </summary>
        public static class ValidationTools
        {
            /// <summary>
            /// Проверка на корректность ввода вещественных чисел
            /// </summary>
            public static void IsDouble(double value)
            {
                if (double.IsNaN(value) || double.IsInfinity(value))
                    throw new ArgumentException("Данные не являются вещественным числом.");
            }

            /// <summary>
            /// Проверка на корректность ввода данных, которые должны быть строго больше нуля
            /// </summary>
            public static void IsLessThenNull(double value)
            {
                if (value <= 0)
                    throw new ArgumentException("Значение данного параметра не может быть меньше 0");
            }

            public static void IsCorrect(double value, double minValue, double maxValue)
            {
                if ((minValue >= value)||(value >= maxValue))
                        throw new ArgumentException("Значение данного параметра выходит за допустимые значения: от" + minValue + "до" + maxValue + ".");
            }
        }
    }
}
