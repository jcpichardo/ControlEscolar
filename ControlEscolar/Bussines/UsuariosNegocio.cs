using ControlEscolar.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolar.Bussines
{
    public class UsuariosNegocio
    {
        public static bool EsFormatoValido(string correo)
        {
            return Validaciones.EsCorreoValido(correo); // Llama a utilities
        }
    }
}
