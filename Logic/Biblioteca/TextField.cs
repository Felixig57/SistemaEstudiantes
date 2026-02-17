using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic.Biblioteca
{
    //cambiar ambito de lectura
    public class TextField
    {
        //metodo publico sin retorno para validar 
        public void Solo_Letras(KeyPressEventArgs e) {
            //validacion para permitir solo letras y el uso de la tecla de retroceso
            if (!char.IsLetter(e.KeyChar) && 
                e.KeyChar != '\b' &&
                e.KeyChar != ' ')
            {
                e.Handled = true;
            }

        }
        public void Solo_Numeros(KeyPressEventArgs e)
        {
            //validacion para permitir solo numeros y el uso de la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && 
                e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
