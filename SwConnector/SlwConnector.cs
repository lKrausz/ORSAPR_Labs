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

        public SldWorks swApp { get; private set; }
        public IModelDoc2 swModel { get; private set; }
        /// <summary>
        /// Завершение открытого процесса Solidworks
        /// </summary>
        public void KillProcess()
        {
            Process[] processes = Process.GetProcessesByName("SLDWORKS");
            foreach (Process process in processes)
            {
                process.CloseMainWindow();
                process.Kill();
            }
        }
        
        /// <summary>
        /// Открытие Solidworks
        /// </summary>
        public void StartProcess()
        {     
            Guid muGuid = new Guid("655fc8fc-6216-46e2-82b6-221a9a271624");
            object processSw = System.Activator.CreateInstance(System.Type.GetTypeFromCLSID(muGuid));
            swApp = (SldWorks)processSw;
            swApp.Visible = true;
        }

        public IModelDoc2 CreateDocument()
        {
            swApp.NewPart();
            swModel = swApp.ActiveDoc;
            return swModel;
        }

        public void CreatePoint(double height)
        {

        }
   
    }
}
