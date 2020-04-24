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


namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SldWorks swApp;
        IModelDoc2 swModel;

        SlwConnector connector = new SlwConnector();
        private void buildButton_Click(object sender, EventArgs e)
        {
            connector.KillProcess();
            connector.StartProcess();
                        
        }
    }
}
