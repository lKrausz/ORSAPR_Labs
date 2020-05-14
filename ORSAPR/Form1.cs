using System;
using System.Windows.Forms;
using SwConnector;
using SolidWorks.Interop.sldworks;
using Model;
using System.Text.RegularExpressions;
using System.Drawing;

namespace GUI
{
    public partial class glassBuilderForm : Form
    {
        public glassBuilderForm()
        {
            InitializeComponent();
            material_comboBox.SelectedItem = "Стекло";
            ShowHelper();
        }

        private SlwConnector _connector = new SlwConnector();

        private GlassBuilder _builder = new GlassBuilder();

        private void buildButton_Click(object sender, EventArgs e)
        {
            try
            {
                GlassParams glass;
                if (((string)material_comboBox.Text) == "Стекло")
                {
                    glass = new GlassParams(double.Parse(bottomRadius_textBox.Text),
                    double.Parse(bottomThickness_textBox.Text),
                    double.Parse(height_textBox.Text),
                    double.Parse(topRadius_textBox.Text),
                    double.Parse(topThickness_textBox.Text),
                    double.Parse(topWidth_textBox.Text),
                    double.Parse(wallThickness_textBox.Text));
                }

                else
                {
                    glass = new GlassParams(double.Parse(bottomRadius_textBox.Text),
                    double.Parse(height_textBox.Text),
                    double.Parse(topRadius_textBox.Text));
                }
                SldWorks swApp = _connector.StartProcess();
                IModelDoc2 swModel = _connector.CreateDocument();
                _builder.BuildGlass(swModel, glass);
            }
            catch (FormatException)
            {
                MessageBox.Show("Требуется заполнение всех полей или проверка на наличие лишних запятых.",
                   "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        /// <summary>
        /// Скрытие/Демонстрация дополнительных параметров стакана при смене материала
        /// </summary>
        private void material_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((string)material_comboBox.Text) == "Стекло")
            {
                additionalParams.Visible = true;
            }
            else
            {
                additionalParams.Visible = false;
            }
        }

        #region Значение max и min значений параметров стакана
        private const int MinBottomRadius = 15;
        private const int MaxBottomRadius = 80;

        private const int MinTopRadius = 15;
        private const int MaxTopRadius = 120;

        private const int MinHeight = 45;
        private const int MaxHeight = 480;

        private const int MinTopThickness = 0;
        private const int MaxTopThickness = 72;

        private const int MinTopWidth = 0;
        private const int MaxTopWidth = 20;

        private const int MinWallThickness = 3;
        private const int MaxWallThickness = 16;

        private const int MinBottomThickness = 3;
        private const int MaxbottomThickness = 24;
        #endregion

        /// <summary>
        /// Валидатор на ввод double.
        /// </summary>
        private void ValidateDoubleTextBoxs_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Regex.IsMatch(e.KeyChar.ToString(), @"[\d\b,]");
        }
        /// <summary>
        /// При изменении значения в textBox вызывается метод валидации для проверки введенного параметра на корректность.
        /// </summary>
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            string name = this.ActiveControl.Name;
            TextView type = (TextView)sender;
            double value;
            if (this.ActiveControl.Text != "")
            {
                value = Double.Parse(this.ActiveControl.Text);
                Validation(type.Type, value);
            }
            else ShowError("Требуется заполнение поля.");
        }

        /// <summary>
        /// Метод для проверки вводимых пользователем значений
        /// </summary>
        /// <param name="name"> Имя активного textBox </param>
        /// <param name="value"> Введенное в textBox значение </param>
        private void Validation(TextViewType type, double value)
        {
            this.ActiveControl.BackColor = Color.White;
            buildButton.Enabled = true;
            double minDependentParameter;
            double maxDependentParameter;
            switch (type)
            {
                case TextViewType.BottomRadius:
                    IsCorrect(MinBottomRadius,value, MaxBottomRadius);                  
                    return;

                case TextViewType.BottomThickness:
                    IsCorrect(MinBottomThickness, value, MaxbottomThickness);
                    minDependentParameter = 0;
                    maxDependentParameter = 0.3 * Double.Parse(height_textBox.Text);
                    IsCorrect(minDependentParameter, value, maxDependentParameter);
                    return;

                case TextViewType.Height:
                    IsCorrect(MinHeight, value, MaxHeight);                 
                    return;

                case TextViewType.TopRadius:
                    IsCorrect(MinTopRadius, value, MaxTopRadius);
                    minDependentParameter = Double.Parse(bottomRadius_textBox.Text);
                    maxDependentParameter = 1.5 * Double.Parse(bottomRadius_textBox.Text);
                    IsCorrect(minDependentParameter, value, maxDependentParameter);
                    return;

                case TextViewType.TopThickness:
                    IsCorrect(MinTopThickness, value, MaxTopThickness);
                    minDependentParameter = 0;
                    maxDependentParameter = 0.15 * Double.Parse(height_textBox.Text);
                    IsCorrect(minDependentParameter, value, maxDependentParameter);
                    return;

                case TextViewType.TopWidth:
                    IsCorrect(MinTopWidth, value, MaxTopWidth);
                    return;

                case TextViewType.WallThickness:
                    IsCorrect(MinWallThickness, value, MaxWallThickness);
                    minDependentParameter = 0;
                    maxDependentParameter = 0.2 * Double.Parse(bottomRadius_textBox.Text);
                    IsCorrect(minDependentParameter, value, maxDependentParameter);
                    return;

            }
        }
        /// <summary>
        /// Отображение ошибки при неправельно введенном пользователем значении
        /// </summary>
        /// <param name="hint">Текст подсказки, сообщающей об ошибке в вводе данных</param>
        private void ShowError(string hint)
        {
            this.ActiveControl.BackColor = Color.Plum;
            toolTip.Show(hint, this.ActiveControl);
            buildButton.Enabled = false;
        }
        /// <summary>
        /// Вызов окна с подсказкой по оформлению
        /// </summary>
        private void helpButton_Click(object sender, EventArgs e)
        {
            ShowHelper();
        }
        /// <summary>
        /// Вывод окна с подсказкой по оформлению
        /// </summary>
        private void ShowHelper()
        {
            MessageBox.Show("Обратите внимание на правила заполнения: \n " +
                "1. Радиус горлышка не может быть больше чем 1,5 радиуса дна стакана;\n" +
                "2. Толщина дна стакана не может быть больше чем 0,3 высоты стакана; \n" +
                "3. Толщина горлышка стакана не может быть больше чем 0,15 высоты стакана;\n" +
                "4. Толщина стенок стакана не может быть больше чем 0,2 радиуса дна стакана;\n\n" +
                "Данную справку вы можете вызвать в любое время при помощи кнопки '?' в нижнем правом углу.",
                   "Справка", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        /// <summary>
        /// Проверка на нахождение введенного значения в допустимых границах
        /// </summary>
        /// <param name="minValue">Минимальное значение</param>
        /// <param name="value">Введенное значение</param>
        /// <param name="maxValue">Максимальное значение</param>
        private void IsCorrect(double minValue, double value, double maxValue)
        {
            string hint;
            if (value < minValue || value > maxValue)
            {
                hint = "Область допустимых значений: " +
                    "от " + minValue + " до " + maxValue + ".\n";
                ShowError(hint);
            }
        }
    }
}
