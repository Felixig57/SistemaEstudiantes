using LinqToDB;
using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion: DataConnection//herenccia desde Linq2db
    {
        //constructutor para inicializar la conexion que proviene desde la herencia 
        public Conexion():base("conexionSQL")//herencia del nombre de la BD
        {

        }
        //crear una interface para sirve como puente de comunicacion de los datos 
        //ala interface se la de permiso de get y set
        public ITable<Estudiante> estudiantes { get; set; }//metodo publico que se puede utilizar para la carga de los datos en la base de datos

    }
}
