using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    //cambiar ambito de lectura clase
    [Table(Name = "alumnos")]
    public class Estudiante
    {
        //atributos con sus metodos 
      //  [Column(Name = "Id")]
        public int Id { get; set; }

       // [Column(Name = "Nombre")]
        public string Nombre { get; set; }

     //   [Column(Name = "ApellidoPaterno")]
        public string ApellidoPaterno { get; set; }

     //   [Column(Name = "ApellidoMaterno")]
        public string ApellidoMaterno { get; set; }

      //  [Column(Name = "Direccion")]
        public string Direccion { get; set; }

       // [Column(Name = "Telefono")]
        public string Telefono { get; set; }

       // [Column(Name = "Correo")]
        public string Correo { get; set; }


    }
}
