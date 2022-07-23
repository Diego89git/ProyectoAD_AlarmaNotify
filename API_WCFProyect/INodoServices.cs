using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace API_WCFProyect
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "INodoServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface INodoServices
    {
        [OperationContract]
        void DoWork();
    }
}
