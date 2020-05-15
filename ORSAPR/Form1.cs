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
            buildButton.Enabled = false;
        }
        private SlwConnector _connector = new SlwConnector();
        private GlassBuilder _builder = new GlassBuilder();

        /// <summary>
        /// При нажатии на кнопку создается экземпляр GlassParams, а затем, если валидация пройдена, происходит построение стакана.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            catch (ArgumentException hint)
            {
                MessageBox.Show(hint.Message);
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
            this.ActiveControl.BackColor = Color.White;
            buildButton.Enabled = true;
            double value;
            try
            {
                if (this.ActiveControl.Text != "")
                {
                    value = Double.Parse(this.ActiveControl.Text);
                    TextViewPresenter.Validation(type.Type, value);
                }
                else ShowError("Требуется заполнение поля.");
            }
            catch (FormatException)
            {
                ShowError("Требуется проверка на наличие лишних запятых.");
                return;
            }
            catch (ArgumentException hint)
            {
                ShowError(hint.Message);
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
       
    }
}
