﻿using System;
using System.Windows.Forms;

namespace HolaMundo
{
    internal static class Program
    {
        /// <summary>  
        /// Punto de entrada principal para la aplicación.  
        /// </summary>  
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }
    }
}
