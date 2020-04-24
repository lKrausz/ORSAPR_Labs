

namespace Model
{
     /// <summary>
     /// Сущность, описывающая построоение стакана
     /// </summary>
    public interface IBuilder
    {
        /// <summary>
        /// Метод для построения стакана
        /// </summary>
        /// <param name="glass">Параметры стакана</param>
        void BuildGlass(GlassParams glass);
        
    }
}
