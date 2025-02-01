using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;
using Zaklad;


namespace ZakladWin
{
    internal static class Program
    {
        //public static List<Klient> ListaKlientow = new List<Klient>() { new Klient("Adam", "Kowal", "47658939"), new Klient("Jan", "Nowak", "678232438") };
        public static List<Samochod> ListaSamochodow = new List<Samochod>();
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataBase.Initialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
