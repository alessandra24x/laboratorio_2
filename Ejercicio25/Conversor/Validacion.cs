using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public static class Validacion
    {
        public static bool ValidarCampos(string a, string b, string c)
        {
            //if (Validacion.ValidarCampos(a) && Validacion.ValidarCampos(b) && Validacion.ValidarCampos(c))
            //{
            //    return true;
            //}
            //return false;
            return (Validacion.ValidarCampos(a) && Validacion.ValidarCampos(b) && Validacion.ValidarCampos(c));
        }

        public static bool ValidarCampos(string a)
        {
            //if (double.TryParse(a, out aux))
            //{
            //    return true;
            //}
            //return false;
            return (int.TryParse(a, out int aux));
        }

        public static bool ValidarCampos(TextBox a)
        {
            return Validacion.ValidarCampos(a.Text);
        }

        public static bool ValidarCampos(TextBox a, TextBox b, TextBox c)
        {
            return (Validacion.ValidarCampos(a) && Validacion.ValidarCampos(b) && Validacion.ValidarCampos(c));
        }

        public static bool isBinary(string number)
        {
            int copyOfInput = Convert.ToInt32(number);
            while (copyOfInput != 0)
            {
                if (copyOfInput % 10 > 1 || copyOfInput < 0)
                {
                    return false;
                }
                copyOfInput = copyOfInput / 10;
            }
            return true;
        }
    }
}
