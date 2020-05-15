using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace GUI
{
    class TextView: TextBox
    {
        /// <summary>
        /// Тип textBox
        /// </summary>
        public TextViewValidation.TextViewType Type { get; set; }
    }
}
