using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorVariablesPostmanADUWS.EntidadActaLocal
{
    class BaseClassActaLocal
    {
        string _nombre = "";
        string _valor = "";
        string _tipo = "string";
        public string key
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string value
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public string type
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
    }

    class Representante
    {
        public BaseClassActaLocal CUIT { get; set; }
        public BaseClassActaLocal Matricula { get; set; }
        public BaseClassActaLocal Categoria { get; set; }
        public BaseClassActaLocal Condicion { get; set; }
    }

    class Persona
    {
        public BaseClassActaLocal DNI { get; set; }
        public BaseClassActaLocal NombreApellido { get; set; }
        public BaseClassActaLocal Email { get; set; }
    }


}
