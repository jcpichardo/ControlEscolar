using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ControlEscolar.Utilities;

namespace ControlEscolar.Bussines
{
    internal class EstudiantesNegocio
    {
        internal static bool EsCorreoValido(string correo)
        {
            return Validaciones.EsCorreoValido(correo);
        }
        internal static bool EsCURPValido(string curp)
        {
            return Validaciones.EsCURPValido(curp);
        }
        /// <summary>
        /// Valida si el número de control es válido
        /// Ejemplos validos: T-2021-1234, M-2021-1234
        /// Ejemplos no validos: X-2025-123, T-25-123, M-2023-12
        /// </summary>
        /// <param name="nocontrol">No de control a validar</param>
        /// <returns>Retorna un verdadero o falso</returns>
        internal static bool EsNoControlValido(string nocontrol)
        {
            string patron = @"^(T|M)-\d{4}-\d{3,5}$";
            return Regex.IsMatch(nocontrol, patron);
        }
    }
}
