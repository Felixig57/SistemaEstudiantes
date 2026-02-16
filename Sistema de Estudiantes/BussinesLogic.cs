using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Estudiantes
{
    public class BussinesLogic
    {
        //funcion para validar campos vacios que se reciben del modelo de propiedades
        public bool ValidarCamposVacios(Estudiantes estudiantes)
        {
            if (string.IsNullOrEmpty(estudiantes.Id) ||
                   string.IsNullOrEmpty(estudiantes.Nombre) ||
                   string.IsNullOrEmpty(estudiantes.ApellidoPaterno) ||
                   string.IsNullOrEmpty(estudiantes.ApellidoMaterno) ||
                   string.IsNullOrEmpty(estudiantes.Direccion) ||
                   string.IsNullOrEmpty(estudiantes.Telefono) ||
                   string.IsNullOrEmpty(estudiantes.Correo))
            {
                return true; // Hay campos vacíos

            }
            else
            {
                return false; // No hay campos vacíos

            }
        }//cierra funcion
    }//
}//
