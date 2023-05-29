using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorVariablesPostmanADUWS.EntidadActaLocal
{
    class CustomExceptionActaLocal : Exception
    {
        public string CodigoError { get; set; }
        public string MensajeError { get; set; }

        public CustomExceptionActaLocal(string codigoError, string mensajeError)
        {
            this.CodigoError = codigoError;
            this.MensajeError = mensajeError;
        }
    }
}
