using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxi_cervice
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo("fa-IR");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new CustomersForm());
            //Application.Run(new CarForm());
            //Application.Run(new DestinationForm());
            Application.Run(new DriverForm());
            //Application.Run(new OriginForm());
            //Application.Run(new MainForm());
            //Application.Run(new ReservationForm());
            //Application.Run(new frmLogin());


            //Application.Run(new CartexFor());
            //Application.Run(new TripsForm());
        }
    }
}
