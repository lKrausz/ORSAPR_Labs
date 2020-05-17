using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс, отвечающий за валидацию TextBox
    /// </summary>
    static public class Validator
    {

        /// <summary>
        /// Метод для проверки вводимых пользователем значений
        /// </summary>
        /// <param name="type"> Тип активного textBox </param>
        /// <param name="value"> Введенное в textBox значение </param>
        static public void Validation(Params type, double value)
        {
            switch (type)
            {
                case Params.BottomRadius:
                    IsCorrect(GlassParams.MinBottomRadius, value, GlassParams.MaxBottomRadius);
                    return;

                case Params.BottomThickness:
                    IsCorrect(GlassParams.MinBottomThickness, value, GlassParams.MaxbottomThickness);
                    return;

                case Params.Height:
                    IsCorrect(GlassParams.MinHeight, value, GlassParams.MaxHeight);
                    return;

                case Params.TopRadius:
                    IsCorrect(GlassParams.MinTopRadius, value, GlassParams.MaxTopRadius);
                    return;

                case Params.TopThickness:
                    IsCorrect(GlassParams.MinTopThickness, value, GlassParams.MaxTopThickness);
                    return;

                case Params.TopWidth:
                    IsCorrect(GlassParams.MinTopWidth, value, GlassParams.MaxTopWidth);
                    return;

                case Params.WallThickness:
                    IsCorrect(GlassParams.MinWallThickness, value, GlassParams.MaxWallThickness);
                    return;

            }
        }
        /// <summary>
        /// Проверка на нахождение введенного значения в допустимых границах
        /// </summary>
        /// <param name="minValue">Минимальное значение</param>
        /// <param name="value">Введенное значение</param>
        /// <param name="maxValue">Максимальное значение</param>
        static private void IsCorrect(double minValue, double value, double maxValue)
        {
            string hint;
            if (value < minValue || value > maxValue)
            {
                hint = "Область допустимых значений: " +
                    "от " + minValue + " до " + maxValue + ".\n";
                throw new ArgumentException(hint);
            }
        }


        
    }
}
