using LinqToDB;
using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion: DataConnection
    {
        //constructutor para inicializar la conexion
        public Conexion():base("conexionSQL")//herencia del nombre de la BD
        {

        }
        //cargar las interfaces
        public ITable<Estudiante> estudiantes { get; set; }//metodo publico que se puede utilizar para la carga de los datos en la base de datos

    }
}
