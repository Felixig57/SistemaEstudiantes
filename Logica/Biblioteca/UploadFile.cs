    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Forms;

    namespace Logica.Biblioteca
    {
        public class UploadFile
        {
            public OpenFileDialog openFileDialog = new OpenFileDialog();
            public void CargarFoto(PictureBox pictureBox)
            {
                pictureBox.WaitOnLoad = true;
                openFileDialog.Filter = "Formato| *.jpg; *.gif; *.bmp";
                openFileDialog.ShowDialog();
                if (openFileDialog.FileName != string.Empty)
                {
                    pictureBox.ImageLocation = openFileDialog.FileName;
                }

            }

        }
    }
