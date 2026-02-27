using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic.Biblioteca
{
    //cambiar ambito de lectura
    public class UploadFile
    {
        //instanciar objeto de OpenFileDialog para abrir el explorador de archivos
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        public void CargarImagen(PictureBox pictureBox)
        {
            //haciendo uso del parametro de OpenFileDialog para abrir el explorador de archivos
            pictureBox.WaitOnLoad = true;
            //usar el objeto para indicar las propiedades del filtro
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            //abrir el explorador de archivos y verificar si se selecciono un archivo
            openFileDialog.ShowDialog();
            //condicion para establer si se selecciono un archivo
            if(openFileDialog.FileName != string.Empty)
            {
                //cargar la imagen seleccionada en el PictureBox
                pictureBox.ImageLocation = openFileDialog.FileName;
            }
        }
        //metoodo publico que trnasfoer de img a byte
        public byte[] ConvertirImg_Byte(Image imagen)
        {
            //instanciar un comopoente drawing
            var convertidor = new ImageConverter();//variable que espera un objeto de conversion
            //colocamos un retorno

            //aqui se retorna un array de bytes en su convertir los parametros
            return (byte[])convertidor.ConvertTo(imagen, typeof(byte[]));
        }

    }
}
