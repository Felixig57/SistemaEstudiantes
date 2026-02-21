using Logic.Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public class LogicaEstudiante : Library
    {
        //variable para almacenar la lista de alumnos


        //crear un constructor para inicializar la clase
        private List<TextBox> listaAlumnos;

        public LogicaEstudiante(List<TextBox> listaAlumnos)
        {
            this.listaAlumnos = listaAlumnos;
        }
        public void ValidarFormulario()
        {
            /*if (listaAlumnos[0].Text == string.Empty ||
                listaAlumnos[1].Text == string.Empty ||
                listaAlumnos[2].Text == string.Empty ||
                listaAlumnos[3].Text == string.Empty ||
                listaAlumnos[4].Text == string.Empty ||
                listaAlumnos[5].Text == string.Empty ||
                listaAlumnos[6].Text == string.Empty
                )
            {
                MessageBox.Show("el formulario no debe estar vacio");
                listaAlumnos[0].Text = "Ingrese ID !!";
                listaAlumnos[0].Focus();
                listaAlumnos[1].Text = "Ingrese Nombre !!";
                listaAlumnos[1].Focus();
                listaAlumnos[2].Text = "Ingrese Apellido Paterno !!";
                listaAlumnos[2].Focus();
                listaAlumnos[3].Text = "Ingrese Apellido Materno !!";
                listaAlumnos[3].Focus();
                listaAlumnos[4].Text = "Ingrese Direccion !!";
                listaAlumnos[4].Focus();
                listaAlumnos[5].Text = "Ingrese Telefono !!";
                listaAlumnos[5].Focus();
                listaAlumnos[6].Text = "Ingrese Correo !!";
                listaAlumnos[6].Focus();

            }
            else
            {
                MessageBox.Show("Formulario Validado Correctamente");

            }*/
            switch (listaAlumnos.Count())
            {
                case 0:
                    if (listaAlumnos[0].Text == string.Empty)
                    {
                        MessageBox.Show("El id no puede quedar vacio");
                        listaAlumnos[0].Text = "Ingrese id";
                        listaAlumnos[0].Focus();
                    }
                        break;
                case 1:
                    break;
            }

        }
    }
}
