using OrderMe.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderMe
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Login());
            

        }
    }
}

//por hacer
/*
 * quantity q solo acepte numeros // listo
 * Delete buton q pregunte si estas seguro //
 * filtrar ordenes por fecha
 * email sender
 * boton create and submit
 * boton submit en listado de ordenes cuando clickeas en orden no enviada
 */
