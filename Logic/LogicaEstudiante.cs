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
        //objeto que contiene validaciones
        

        //crear un constructor para inicializar la clase
        private List<TextBox> listaAlumnos;
        private List<Label> listaLabels;
        PictureBox pictureBox1;


        public LogicaEstudiante(List<TextBox> listaAlumnos, List<Label> listaLabels, Object[] objects)//, list<Label> ListaLabels
        {
            this.listaAlumnos = listaAlumnos;//argymento asignado
            this.listaLabels = listaLabels;
            this.pictureBox1 = (PictureBox)objects[0];
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
            //validacin campo id
            /*
            if (listaAlumnos[0].Text == string.Empty)
            {
                MessageBox.Show("el formulario no puede quedar vacio");
                listaAlumnos[0].Text = "Ingrese ID !!";
                listaAlumnos[0].Focus();
                return;
            }
            if (listaAlumnos[1].Text == string.Empty)
            {
                MessageBox.Show("el formulario no puede quedar vacio");
                listaAlumnos[1].Text = "Ingrese Nombre !!";
                listaAlumnos[1].Focus();
                return;
            }
            if (listaAlumnos[2].Text == string.Empty)
            {
                MessageBox.Show("el formulario no puede quedar vacio");
                listaAlumnos[2].Text = "Ingrese Apellido Paterno !!";
                listaAlumnos[2].Focus();
                return;
            }
            if (listaAlumnos[3].Text == string.Empty)
            {
                MessageBox.Show("el formulario no puede quedar vacio");
                listaAlumnos[3].Text = "Ingrese Apellido Materno !!";
                listaAlumnos[3].Focus();
                return;
            }
            if (listaAlumnos[4].Text == string.Empty)
            {
                MessageBox.Show("el formulario no puede quedar vacio");
                listaAlumnos[4].Text = "Ingrese Direccion !!";
                listaAlumnos[4].Focus();
                return;
            }
           
            if (listaAlumnos[5].Text == string.Empty)
            {
                MessageBox.Show("el formulario no puede quedar vacio");
                listaAlumnos[5].Text = "Ingrese Telefono !!";
                listaAlumnos[5].Focus();
                return;

            }
            if (listaAlumnos[6].Text == string.Empty)
            {
                MessageBox.Show("el formulario no puede quedar vacio");
                listaAlumnos[6].Text = "Ingrese Correo !!";
                listaAlumnos[6].Focus();
                return;
            }
            MessageBox.Show("Formulario Completo");
            LimpiarFormulario();
            */
            //validacion con campos de texto
            /*
            if (listaAlumnos[0].Text == string.Empty) {
                listaAlumnos[0].Text = "Ingrese ID !!";
                listaAlumnos[0].Focus();
            }
            else
            {
                if (listaAlumnos[1].Text == string.Empty)
                {   listaAlumnos[1].Text = "Ingrese Nombre ";
                    listaAlumnos[1].Focus();

                }
                else
                {
                    if (listaAlumnos[2].Text == string.Empty)
                    {
                        listaAlumnos[2].Text = "Ingrese Apellido Paterno";
                        listaAlumnos[2].Focus();
                    }
                    else
                    {
                        if (listaAlumnos[3].Text == string.Empty)
                        {
                            listaAlumnos[3].Text = "Ingresse Apellido Materno";
                            listaAlumnos[3].Focus();
                        }
                        else
                        {
                            if (listaAlumnos[4].Text == string.Empty)
                            {
                                listaAlumnos[4].Text = "Ingrese Direccion";
                                listaAlumnos[4].Focus();
                            }
                            else
                            {
                                if (listaAlumnos[5].Text == string.Empty)
                                {
                                    listaAlumnos[5].Text = "Ingrese Telefono";
                                    listaAlumnos[5].Focus();
                                }
                                else
                                {
                                    if (listaAlumnos[6].Text == string.Empty)
                                    {
                                        listaAlumnos[6].Text = "Ingrese Correo";
                                        listaAlumnos[6].Focus();
                                    }
                                   
                                }
                            }
                        }
                    }
                }
            }*/

            //validacion con labels
            if (listaAlumnos[0].Text == string.Empty)
            {
                MessageBox.Show("Caja de texto vacia");
                listaAlumnos[0].Text = "Ingrese ID !!";
                listaAlumnos[0].Focus();
            }
            else
            {
                if (listaAlumnos[1].Text == string.Empty)
                {
                    MessageBox.Show("nombre vacio");
                    listaAlumnos[1].Text = "Ingrese Nombre ";
                    listaAlumnos[1].Focus();

                }
                else
                {
                    if (listaAlumnos[2].Text == string.Empty)
                    {
                        MessageBox.Show("Apellido paterno vacio");
                        listaAlumnos[2].Text = "Ingrese Apellido Paterno";
                        listaAlumnos[2].Focus();
                    }
                    else
                    {
                        if (listaAlumnos[3].Text == string.Empty)
                        {
                            MessageBox.Show("apellido materno vacio");
                            listaAlumnos[3].Text = "Ingresse Apellido Materno";
                            listaAlumnos[3].Focus();
                        }
                        else
                        {
                            if (listaAlumnos[4].Text == string.Empty)
                            {
                                MessageBox.Show("direccion vacio");
                                listaAlumnos[4].Text = "Ingrese Direccion";
                                listaAlumnos[4].Focus();
                            }
                            else
                            {
                                if (listaAlumnos[5].Text == string.Empty)
                                {
                                    MessageBox.Show("telefono vacio");
                                    listaAlumnos[5].Text = "Ingrese Telefono";
                                    listaAlumnos[5].Focus();
                                }
                                else
                                {
                                    if (listaAlumnos[6].Text == string.Empty)
                                    {
                                        MessageBox.Show("Correo vacio");
                                        listaAlumnos[6].Text = "Ingrese Correo";
                                        listaAlumnos[6].Focus();
                                    }
                                    else
                                    {
                                        //llamar al metodo publico que tenemos
                                        //declarar variable para que reciba el metodo
                                        //var imgByte = UploadFile.ConvertirImg_Byte(pictureBox.Image);//modificar para usar el metodo de conversion
                                        var img = uploadFile.ConvertirImg_Byte(pictureBox1.Image);
                                    }

                                }
                            }
                        }
                    }
                }
            }


        }//funcion de validar formulario

      
    }
}
