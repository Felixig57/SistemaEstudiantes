using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    //cambiar ambito de lectura clase
   
    public class Estudiante
    {
        //atributos con sus metodos 
        //actividades que corresponden al cierre del 2do elemento de competencia Read, Insert

        //avanze viernes 20 examen 27 de marzo, todos los conceptos que forman parte del CRUD
        //para el 3 de abril completar Avanze numero 2 diseño validacion, controles dgv, Read Create Insert y tambien para las imagenes
        //entrega etapa 2 inserccion y lectura de base de datos y mostrarlo en el dgv, e
       //data annnotation
        [PrimaryKey]
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

        public byte [] Imagen {  get; set; }//carga de la imagen

    }
}
