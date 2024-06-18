using System;

namespace ListaEstudiantes.Excep

{
    public class WrongTypeException : Exception
    {
        public WrongTypeException(string message) : base(message)
        { 
            // LOGICA PARA DAR LA EXCEPCION
        }
    }
}
