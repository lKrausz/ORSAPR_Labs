using System;
using SolidWorks.Interop.sldworks;

namespace SwConnector
{
    /// <summary>
    /// Класс, отвечающий за подключение к SOLIDWORKS
    /// </summary>
    public class SlwConnector
    {
        /// <summary>
        /// Текущая сессия SOLIDWORKS
        /// </summary>
        private SldWorks _swApp;
        /// <summary>
        /// Текущий документ SOLIDWORKS
        /// </summary>
        private IModelDoc2 _swModel;

        /// <summary>
        /// Открытие SOLIDWORKS
        /// </summary>
        public SldWorks StartProcess()
        {   //x64
            //Guid muGuid = new Guid("655fc8fc-6216-46e2-82b6-221a9a271624");
            //object processSw = System.Activator.CreateInstance(System.Type.GetTypeFromCLSID(muGuid));
            object processSw = System.Activator.CreateInstance(System.Type.GetTypeFromProgID("SldWorks.Application"));
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
