using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swcommands;
using SolidWorks.Interop.swconst;
using System.Diagnostics;

namespace SwConnector
{
    public class SlwConnector
    {

        private SldWorks _swApp;

        private IModelDoc2 _swModel;

        
        /// <summary>
        /// Открытие Solidworks
        /// </summary>
        public SldWorks StartProcess()
        {     
            Guid muGuid = new Guid("655fc8fc-6216-46e2-82b6-221a9a271624");
            object processSw = System.Activator.CreateInstance(System.Type.GetTypeFromCLSID(muGuid));
            _swApp = (SldWorks)processSw;
            _swApp.Visible = true;
            return _swApp;
        }

        /// <summary>
        /// Создание нового документа (детали)
        /// </summary>
        public IModelDoc2 CreateDocument()
        {
            _swApp.NewPart();
            _swModel = _swApp.ActiveDoc;
            return _swModel;
        }
   
    }
}
