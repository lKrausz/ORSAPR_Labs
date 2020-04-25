using System;
using System.Windows.Forms;
using SwConnector;
using SolidWorks.Interop.sldworks;
using Model;
using System.Text.RegularExpressions;



namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "Стекло";
           
        }
        SldWorks swApp;
        IModelDoc2 swModel;
        SlwConnector connector = new SlwConnector();
        GlassBuilder builder = new GlassBuilder();

        private void buildButton_Click(object sender, EventArgs e)
        {
            swApp = connector.StartProcess();
            swModel = connector.CreateDocument();

            try
            {
                if (((string)comboBox1.Text) == "Стекло")
                {
                    GlassParams glass = new GlassParams(double.Parse(bottomRadius_textBox.Text),
                    double.Parse(bottomThickness_textBox.Text),
                    double.Parse(height_textBox.Text),
                    double.Parse(topRadius_textBox.Text),
                    double.Parse(topThickness_textBox.Text),
                    double.Parse(topWidth_textBox.Text),
                    double.Parse(wallThickness_textBox.Text));
                    builder.BuildGlass(swModel, glass);
                }

                else
                {
                    GlassParams glass = new GlassParams(double.Parse(bottomRadius_textBox.Text),
                    double.Parse(height_textBox.Text),
                    double.Parse(topRadius_textBox.Text));
                    builder.BuildGlass(swModel, glass);
                }

            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch (FormatException)
            {
                MessageBox.Show("Требуется заполнение всех полей или проверка на наличие лишних запятых.",
                   "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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

    }
}
