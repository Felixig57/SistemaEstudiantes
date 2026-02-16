using Logic;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace Sistema_de_Estudiantes
{
    public partial class frmRegistroEstudiantes : Form
   

    {
        //instanciar la clase de logica de negocio para validar los campos vacios  
        private LogicaEstudiante logicaEstudiante = new LogicaEstudiante();
        public frmRegistroEstudiantes()
        {
            InitializeComponent();
        }
        #region Codigo de eventos

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            //condicion para advertencia en los lbl
            if (txtId.Text.Equals("") || txtId.Text.Equals("Ingrese id") )
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

        }

        private void txtApellidoMaterno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //llamar ala funcion que recibe los valores de las cajas de texto
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
            LimpiarCampos();

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
            if (txtId.Text == "Ingrese id")
            {
                txtId.Text = "";
                txtId.ForeColor = Color.Black;
            }
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                txtId.Text = "Ingrese id";
                txtId.ForeColor = Color.Gray;
            }
        }

    

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Ingrese su nombre aqui")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Ingrese su nombre aqui";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtApellidoPaterno_Enter(object sender, EventArgs e)
        {
            if (txtApellidoPaterno.Text == "Ingrese apellido paterno")
            {
                txtApellidoPaterno.Text = "";
                txtApellidoPaterno.ForeColor = Color.Black;
            }
        }

        private void txtApellidoPaterno_Leave(object sender, EventArgs e)
        {
            if (txtApellidoPaterno.Text == "")
            {
                txtApellidoPaterno.Text = "Ingrese apellido paterno";
                txtApellidoPaterno.ForeColor = Color.Gray;
            }
        }

        private void txtApellidoMaterno_Enter(object sender, EventArgs e)
        {
            if(txtApellidoMaterno.Text == "Ingrese apellido materno")
            {
                txtApellidoMaterno.Text = "";
                txtApellidoMaterno.ForeColor = Color.Black;

            }
        }

        private void txtApellidoMaterno_Leave(object sender, EventArgs e)
        {
            if(txtApellidoMaterno.Text == "")
            {
                txtApellidoMaterno.Text = "Ingrese apellido materno";
                txtApellidoMaterno.ForeColor = Color.Gray;
            }
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if(txtDireccion.Text == "Ingrese direccion")
            {
                txtDireccion.Text = "";
                txtDireccion.ForeColor = Color.Black;
            }
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if(txtDireccion.Text == "")
            {
                txtDireccion.Text = "Ingrese direccion";
                txtDireccion.ForeColor = Color.Gray;
            }
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if(txtTelefono.Text == "Ingrese telefono")
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = Color.Black;
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if(txtTelefono.Text == "")
            {
                txtTelefono.Text = "Ingrese telefono";
                txtTelefono.ForeColor = Color.Gray;
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if(txtCorreo.Text == "Ingrese correo")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.Black;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Ingrese correo";
                txtCorreo.ForeColor = Color.Gray;
            }
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            logicaEstudiante.CargarImagen(pictureBox1);
        }
    }
}
