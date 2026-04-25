using Datos;
using LinqToDB;
using Logic.Biblioteca;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

        Conexion conexion = new Conexion();

        //crear un constructor para inicializar la clase
        private List<TextBox> listaAlumnos;
        private List<Label> listaLabels;
        //instanciar al dgv
        DataGridView dataGridView;

        PictureBox pictureBox1;
        //variables que nos van asistir en esta clase, bandera y recoger el valor de id
        private String accion = "Insert";
        public int IdEstudiante = 0;


        public LogicaEstudiante(List<TextBox> listaAlumnos, List<Label> listaLabels, Object[] objects)//, list<Label> ListaLabels
        {
            this.listaAlumnos = listaAlumnos;//argymento asignado
            this.listaLabels = listaLabels;
            this.pictureBox1 = (PictureBox)objects[0];

            this.dataGridView = (DataGridView)objects[1];

        }
        //metodo publico que permite visualizar la lista de estudiantes
        public void ListarEstudiantes()
        {
            accion = "Listar";
            //instaciar ala conexino
            Conexion conexion = new Conexion();
            //declarar una variable padre
            var listaEstudiantes = conexion.GetTable<Estudiante>()
                .Select(e => new
                {
                    e.Id,
                    e.Nombre,
                    e.ApellidoPaterno,
                    e.ApellidoMaterno,
                    e.Direccion,
                    e.Telefono,
                    e.Correo,
                    //
                    Image = ArrayToImage(e.Imagen)

                }).ToList();
            //asignar la lista al dgv
            this.dataGridView.DataSource = listaEstudiantes;

        }
        //metodo con retorono  de imagen
        public Image ArrayToImage(byte[] bytes)
        {
            MemoryStream stream = new MemoryStream( bytes);

            return Image.FromStream( stream );
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
                                        ///llamar al metodo con todo el flujo de la operacionn de CRUD
                                        guardarEditar();

                                    }

                                }
                            }
                        }
                    }
                }
            }


        }//funcion de validar formulario
        public void LimpiarCampos()
        {
            accion = "Limpiar";
            for(int i =0; i <= 6; i++)
            {
                listaAlumnos[i].Clear();
            }
        }

        //crear un metodo para la seleccion del estudiante
        public void getSeleccionEstudiante()
        {
            //cambiar el estatus de la bander
            accion = "Update";
            //aignar valores que se recogen del Id que vienen del DGV
            IdEstudiante = Convert.ToInt32( dataGridView.CurrentRow.Cells[0].Value);
            //aignar el contneido desde el dgv hacia las cajas de texto
            listaAlumnos[0].Text = Convert.ToString(dataGridView.CurrentRow.Cells[0].Value );
            listaAlumnos[1].Text = Convert.ToString(dataGridView.CurrentRow.Cells[1].Value);
            listaAlumnos[2].Text = Convert.ToString(dataGridView.CurrentRow.Cells[2].Value);
            listaAlumnos[3].Text = Convert.ToString(dataGridView.CurrentRow.Cells[3].Value);
            listaAlumnos[4].Text = Convert.ToString(dataGridView.CurrentRow.Cells[4].Value);
            listaAlumnos[5].Text = Convert.ToString(dataGridView.CurrentRow.Cells[5].Value);
            listaAlumnos[6].Text = Convert.ToString(dataGridView.CurrentRow.Cells[6].Value);
            //solicitaremos el arrat de imagen 
            try
            {
              //  byte[] imagenComoArray = (byte[])dataGridView.CurrentRow.Cells[7].Value;
                pictureBox1.Image = (Image)dataGridView.CurrentRow.Cells[7].Value;
                //asignar como propiedad
                //pictureBox1.Image = array

            }
            catch(Exception e) {
                MessageBox.Show("No encontre imagen para mostrar  "+ e);
                
            }//
        }
        //metodo para guardar y editar la informacion 
        public void guardarEditar()
        {
            var img = uploadFile.ConvertirImg_Byte(pictureBox1.Image);

            //controlar el flujo usando el switch Case
            switch (accion)
            {

                case "Insert":
                 
                    //cargar un objeto lleno con los datos necesarios
                    //llamar al objeto que contiene la  conexion
                   //ocupa referencia de la capa datos 
                    conexion.Insert(new Estudiante
                    {
                        Id = int.Parse(listaAlumnos[0].Text),
                        Nombre = listaAlumnos[1].Text,
                        ApellidoPaterno = listaAlumnos[2].Text,
                        ApellidoMaterno = listaAlumnos[3].Text,
                        Direccion = listaAlumnos[4].Text,
                        Telefono = listaAlumnos[5].Text,
                        Correo = listaAlumnos[6].Text,
                        Imagen = img
                    }
                        );
                    //limpar los campos despues de la inserccion
                    //   LimpiarCampos();
                    //volver a llamar a los focos
                    listaAlumnos[0].Focus();
                    MessageBox.Show("Registro exitoso ");
                    break;

                case "Update":
                    
                    var EstudianteEncontrado = conexion.GetTable<Estudiante>()
                        .FirstOrDefault(e => e.Id == IdEstudiante);
                    if( EstudianteEncontrado != null)
                    {
                        Estudiante estudianteEditado = new Estudiante { 
                        Id = int.Parse(listaAlumnos[0].Text),
                        Nombre = listaAlumnos[1].Text,
                        ApellidoPaterno = listaAlumnos[2].Text,
                        ApellidoMaterno = listaAlumnos[3].Text,
                        Direccion = listaAlumnos[4].Text,
                        Telefono = listaAlumnos[5].Text,
                        Correo = listaAlumnos[6].Text,
                        Imagen = img

                        };
                        conexion.Update(estudianteEditado);
                        MessageBox.Show("Alumno Editado");

                    }
                     //cambiar el estatus de la variable accion, accion = "insert";
                    break;

                case "Limpiar":
                    LimpiarCampos();
                    break;
                case "Listar":
                    ListarEstudiantes();
                    break;

            }

        }

      
    }
}
