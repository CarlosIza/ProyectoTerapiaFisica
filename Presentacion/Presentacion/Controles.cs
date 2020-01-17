using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public class Controles
    {
        public static bool validarEmail(string email_de)
        {
            String expresion; expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email_de, expresion))
            {
                if (Regex.Replace(email_de, expresion, String.Empty).Length == 0)
                {

                    return true;
                }
                else
                {

                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private Boolean VerificarCédula(String ced)
        {
            int sumaPares = 0, sumaImpares = 0, ds, st, verif, aux;
            int j = 0;
            if (ced.Length == 10)
            {
                do
                {
                    //convertir el caracter de la posición j en entero
                    int x = (Convert.ToInt16(Convert.ToString(ced[j])) * 2);
                    if (x > 9)
                    {
                        aux = x - 9;
                        x = aux;
                    }
                    sumaImpares = sumaImpares + x;
                    j = j + 2;
                } while (j < 9);

                j = 1;
                //Ciclo suma Posiciones Impares
                do
                {
                    //convertir el caracter de la posición j en entero
                    int x = Convert.ToInt16(Convert.ToString(ced[j]));
                    sumaPares = sumaPares + x;
                    j = j + 2;
                } while (j < 8);
                st = sumaPares + sumaImpares;
                //verifica si el número es divisible para 10 de ser el caso no 
                //asciende a la decena superior
                if (st % 10 == 0)
                {
                    ds = st;
                }
                else //calcula la decena superior
                {
                    ds = ((st / 10) + 1) * 10;
                }
                //calcula el numero verificador
                verif = ds - st;
                //compara el numero verificador para el último digito de la cédula
                //llamado dígito verificador
                //retorna verdadero en caso de ser iguales, caso contrario retorna falso
                if (verif == Convert.ToInt16(Convert.ToString(ced[9])))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public void solorLetras(KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        public void soloNumeros(KeyPressEventArgs e)
        {
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                    return;
                }
        }
        public void controlarNumeroCaracteres(KeyPressEventArgs e, TextBox texto)
        {
            if (texto.Text.Length >= 10)
            {
                e.Handled = true;
                return;
            }
        }
       
    }
}
