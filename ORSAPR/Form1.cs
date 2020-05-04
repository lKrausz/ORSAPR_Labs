using System;
using System.Windows.Forms;
using SwConnector;
using SolidWorks.Interop.sldworks;
using Model;
using System.Text.RegularExpressions;
using System.Drawing;



namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "Стекло";
            ShowHelper();
        }
        SldWorks swApp;
        IModelDoc2 swModel;
        SlwConnector connector = new SlwConnector();
        GlassBuilder builder = new GlassBuilder();

        private void buildButton_Click(object sender, EventArgs e)
        {
            try
            {
                GlassParams glass;
                if (((string)comboBox1.Text) == "Стекло")
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
                swApp = connector.StartProcess();
                swModel = connector.CreateDocument();
                builder.BuildGlass(swModel, glass);
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((string)comboBox1.Text) == "Стекло")
            {
                additionalParams.Visible = true;
            }
            else
            {
                additionalParams.Visible = false;
            }
        }

        #region Значение max и min значений параметров стакана
        int minBottomRadius = 15;
        int maxBottomRadius = 80;

        int minTopRadius = 15;
        int maxTopRadius = 120;

        int minHeight = 45;
        int maxHeight = 480;

        int maxTopThickness = 72;

        int maxTopWidth = 20;

        int minWallThickness = 3;
        int maxWallThickness = 16;

        int minBottomThickness = 3;
        int maxbottomThickness = 24;
        #endregion

        /// <summary>
        /// Валидатор на ввод double.
        /// </summary>
        private void ValidateDoubleTextBoxs_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Regex.IsMatch(e.KeyChar.ToString(), @"[\d\b,]");
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            string name = this.ActiveControl.Name;
            double value;
            if (this.ActiveControl.Text != "")
            {
                value = Double.Parse(this.ActiveControl.Text);
                Validation(name, value);
            }

            else ShowError("Требуется заполнение поля");
        }

        /// <summary>
        /// Метод для проверки вводимых пользователем значений
        /// </summary>
        /// <param name="name"> Имя активного textBox </param>
        /// <param name="value"> Введенное в textBox значение </param>
        private void Validation(string name, double value)
        {
            this.ActiveControl.BackColor = Color.White;
            buildButton.Enabled = true;
            string hint;
            switch (name)
            {
                case ("bottomRadius_textBox"):
                    if (value < minBottomRadius || value > maxBottomRadius)
                    {
                        hint = "Область допустимых значений дна стакана: " +
                            "от " + minBottomRadius + " до " + maxBottomRadius + ".\n";
                        ShowError(hint);
                    }
                    return;

                case "bottomThickness_textBox":
                    if (value < minBottomThickness || (value > maxbottomThickness))
                    {
                        hint = "Область допустимых значений толщины дна стакана: " +
                            "от " + minBottomThickness + " до " + maxbottomThickness + ".\n";
                        ShowError(hint);
                    }
                    else if (value > 0.3 * Double.Parse(height_textBox.Text))
                    {
                        hint = "Нарушены пропорции стакана. Область допустимых значений толщины дна стакана: " +
                            "от " + minBottomThickness + " до " + (0.3 * Double.Parse(height_textBox.Text) + ".\n");
                        ShowError(hint);

                    }
                    return;

                case "height_textBox":
                    if (value < minHeight || (value > maxHeight))
                    {
                        hint = "Область допустимых значений высоты стакана: " +
                            "от " + minHeight + " до " + maxHeight + ".\n";
                        ShowError(hint);
                    }
                    return;

                case "topRadius_textBox":
                    if (value < minTopRadius || value > maxTopRadius)
                    {
                        hint = "Область допустимых значений горлышка стакана: " +
                            "от " + minTopRadius + " до " + maxTopRadius + ".\n";
                        ShowError(hint);
                    }
                    else if (value < Double.Parse(bottomRadius_textBox.Text) || value > (1.5 * Double.Parse(bottomRadius_textBox.Text)))
                    {
                        hint = "Нарушены пропорции стакана. Область допустимых значений горлышка стакана: " +
                            "от " + Double.Parse(bottomRadius_textBox.Text) + " до " + (1.5 * Double.Parse(bottomRadius_textBox.Text)) + ".\n";
                        ShowError(hint);
                    }
                    return;

                case "topThickness_textBox":
                    if (value > maxTopThickness)
                    {
                        hint = "Область допустимых значений толщины горлышка стакана: " +
                            "от 0 до " + maxTopThickness + ".\n";
                        ShowError(hint);
                    }
                    else if ((0.15 * Double.Parse(height_textBox.Text)) < value)
                    {
                        hint = "Нарушены пропорции стакана. Область допустимых значений толщины горлышка стакана: " +
                            "от 0 до " + (0.15 * Double.Parse(height_textBox.Text)) + ".\n";
                        ShowError(hint);
                    }
                    return;

                case "topWidth_textBox":
                    if (value > maxTopWidth)
                    {
                        hint = "Область допустимых значений ширины горлышка стакана: " +
                            "от 0 до " + maxTopWidth + ".\n";
                        ShowError(hint);
                    }
                    return;

                case "wallThickness_textBox":
                    if (value < minWallThickness || (value > maxWallThickness))
                    {
                        hint = "Область допустимых значений толщины стенок стакана: " +
                            "от " + minBottomThickness + " до " + maxbottomThickness + ".\n";
                        ShowError(hint);
                    }
                    else if (value > 0.2 * Double.Parse(bottomRadius_textBox.Text))
                    {
                        hint = "Нарушены пропорции стакана. Область допустимых значений толщины стенок стакана: " +
                            "от " + minWallThickness + " до " + (0.2 * Double.Parse(bottomRadius_textBox.Text) + ".\n");
                        ShowError(hint);
                    }
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

        private void helpButton_Click(object sender, EventArgs e)
        {
            ShowHelper();
        }
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
    }
}
