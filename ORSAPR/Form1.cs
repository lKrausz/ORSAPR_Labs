using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwConnector;
using SolidWorks.Interop.sldworks;
using Model;


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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((string)comboBox1.Text) == "Стекло") additionalParams.Visible = true;
            else additionalParams.Visible = false;
        }
    }
}
