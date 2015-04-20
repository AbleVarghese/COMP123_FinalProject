/*
 * Name: Able Varghese
 * Student No: 300 806 936
 * Application Name: Movie Bonanza
 * Applicatio Creation Date: 04-15-2015
 * Application Description:
 * This is a movie streamming aplication. The user will be presented with movies of different
 * categories and once the user makes the selection, he/she will be directed to a mage where they could order the movie for 
 * streaming. Cost of the movie, tax and other charges will be shown to the user after they choose the movie they wish to       * stream. The user has the option to choose to ship the DVD if needed to. By the end the user is directed movie streaming.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
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
            //calling splash screen form
            Application.Run(new SplashScreen());

        }
    }
}
