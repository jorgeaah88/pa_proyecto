using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public static class Funciones
    {
        public static int EsNumValido(String numero) {// Revisa si el formato del numero es valido

            int seleccion;
            try {
                seleccion = Int32.Parse(numero);
            }
            catch (FormatException) {
                seleccion = -1;
                // Se establece la seleccion en -1 ignorando el valor que se introdujo
            }

            return seleccion;

        }


    }
}
