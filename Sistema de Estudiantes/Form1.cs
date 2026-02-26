using Logic;
using Logic.Biblioteca;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace Sistema_de_Estudiantes
{
    public partial class frmRegistroEstudiantes : Form
        

    {
        //instanciar la clase de logica de negocio para validar los campos vacios  
        LogicaEstudiante logicaEstudiante;

        public frmRegistroEstudiantes()
        {
            InitializeComponent();
            //inicializar los componentes del formulario

            //lista que va guardar a los estudiantes
            List<TextBox> listaAlumnos = new List<TextBox>();
            listaAlumnos.Add(txtId);// 0
            listaAlumnos.Add(txtNombre);//1
            listaAlumnos.Add(txtApellidoPaterno);//2
            listaAlumnos.Add(txtApellidoMaterno);//3
            listaAlumnos.Add(txtDireccion);//4
            listaAlumnos.Add(txtTelefono);//5
            listaAlumnos.Add(txtCorreo);//6

            logicaEstudiante = new LogicaEstudiante(listaAlumnos);

            
            
        }


        #region Codigo de eventos
        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        #region eventos changed
        private void txtId_TextChanged(object sender, EventArgs e)
        {
            //condicion para advertencia en los lbl
            if (txtId.Text.Equals("") || txtId.Text.Equals("Ingrese id"))
            {
                lblId.ForeColor = Color.Red;
            }
            else
            {
                lblId.ForeColor = Color.Green;
            }
        }


        private void txtApellidoPaterno_TextChanged(object sender, EventArgs e)
        {
            if (txtApellidoPaterno.Text.Equals("") || txtApellidoPaterno.Text.Equals("Ingrese apellido paterno"))
            {
                lblaPaterno.ForeColor = Color.Red;
            }
            else
            {
                lblaPaterno.ForeColor = Color.Green;
            }
        }

        private void txtApellidoMaterno_TextChanged(object sender, EventArgs e)
        {
            if (txtApellidoMaterno.Text.Equals("") || txtApellidoMaterno.Text.Equals("Ingrese apellido materno"))
            {
                lblaMaterno.ForeColor = Color.Red;
            }
            else
            {
                lblaMaterno.ForeColor = Color.Green;
            }

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Equals("") || txtTelefono.Text.Equals("Ingrese telefono"))
            {
                lblTelefono.ForeColor = Color.Red;
            }
            else
            {
                lblTelefono.ForeColor = Color.Green;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("") || txtNombre.Text.Equals("Ingrese su nombre aqui"))
            {
                lblNombre.ForeColor = Color.Red;
            }
            else
            {
                lblNombre.ForeColor = Color.Green;
            }

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            if (txtDireccion.Text.Equals("") || txtDireccion.Text.Equals("Ingrese direccion"))
            {
                lblDireccion.ForeColor = Color.Red;
            }
            else
            {
                lblDireccion.ForeColor = Color.Green;
            }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            if (txtCorreo.Text.Equals("") || txtCorreo.Text.Equals("Ingrese correo"))
            {
                lblCorreo.ForeColor = Color.Red;
            }
            else
            {
                lblCorreo.ForeColor = Color.Green;
            }
        }
        #endregion






        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*//llamar ala funcion que recibe los valores de las cajas de texto
            RecibirValoresCajas();
            //llamar a la funcion que valida los campos vacios
            ValidarCamposVacios(RecibirValoresCajas());
            if (!ValidarCamposVacios(RecibirValoresCajas()))
            {
                return;//si hay campos vacios, salir de la funcion
            }
            MessageBox.Show("Datos del Estudiante Guardados");
            //llamar a la funcion que guarda los datos del estudiante en la base de datos
            GuardarEstudianteBD(RecibirValoresCajas());
            //llamar a la funcion que limpia las cajas de texto
            LimpiarCampos();*/

            logicaEstudiante.ValidarFormulario();

        }
        #region Funciones privada
        //funcion para recibir los valores de las cajas de texto
        private Estudiantes RecibirValoresCajas()
        {
            Estudiantes estudiante = new Estudiantes();
            estudiante.Id = txtId.Text;
            estudiante.Nombre = txtNombre.Text;
            estudiante.ApellidoPaterno = txtApellidoPaterno.Text;
            estudiante.ApellidoMaterno = txtApellidoMaterno.Text;
            estudiante.Direccion = txtDireccion.Text;
            estudiante.Telefono = txtTelefono.Text;
            estudiante.Correo = txtCorreo.Text;

            return estudiante;
        }
        //funcion para validar las cajas de texto vacias
        private bool ValidarCamposVacios(Estudiantes estudiantes)
        {
            //llamar al objeto lleno
            RecibirValoresCajas();
            //llamar al objeto que contien la funcion de validacion
            BussinesLogic bussinesLogic = new BussinesLogic();
            if (bussinesLogic.ValidarCamposVacios(estudiantes))
            {
                MessageBox.Show("Todos los campos deben ser llenados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;//devolver true si todos los campos estan llenos
        }
        //funcion que manda los datos del estudiante a la base de datos
        private void GuardarEstudianteBD(Estudiantes estudiantes)
        {
            DataAcces dataAcces = new DataAcces();
            dataAcces.InserccionAlumnoBD(estudiantes);
        }
        //funcion para limpiar las cajas de texto
        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";

        }

        #endregion
        #region Eventos en cajas de texto

        private void txtId_Enter(object sender, EventArgs e)
        {
           /*if(txtId.Text.Equals("Ingrese ID !!"))
            {
                txtId.Text = "";
                txtId.ForeColor = Color.Black;
            }*/
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            /*if (txtId.Text.Equals(""))
            {
                txtId.Text = "Ingrese ID !!";
                txtId.ForeColor = Color.Gray;
            }*/

        }



        private void txtNombre_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtApellidoPaterno_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtApellidoPaterno_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtApellidoMaterno_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtApellidoMaterno_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
          
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
          
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            
        }
        #endregion


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            logicaEstudiante.uploadFile.CargarImagen(pictureBox1);
        }
        #region Eventso key press
        #endregion
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            logicaEstudiante.textField.Solo_Letras(e);
        }

        private void txtApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            logicaEstudiante.textField.Solo_Letras(e);
        }

        private void txtApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            logicaEstudiante.textField.Solo_Letras(e);
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            logicaEstudiante.textField.Solo_Numeros(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            logicaEstudiante.textField.ValidarNumerosTelefonicos(e);
        }
        public void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            logicaEstudiante.textField.ValidarCorreoElectronico(e);
        }
    }//cierres de la clase
}//cierres de la clase 
