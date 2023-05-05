using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainModel.Model;
using FrameWork;
using DomainModel.ViewModel.Driver;

namespace Taxi_cervice
{
    public partial class CartexFor : Form
    {
       
        public CartexFor()
        {
            InitializeComponent();
        }

        //private void Fullname()
        //{
        //    Driver d = new Driver();
        //    using (DriverRepository de = new DriverRepository())

        //    {
        //        var driver = de.GetAll();

                

        //    }
        //}
        private void BindDriver()
        {
            using (DriverRepository repository = new DriverRepository())
            {
                var listdrivers = new List<DriverFulInformation>();
                var drivers = repository.GetAll().ToList();
                foreach (var driver in drivers)
                {
                    var driverViewModel = new DriverFulInformation();

                    driverViewModel.DriverFullName = driver.DriverFirstName + "  " + driver.DriverLastName;
                    driverViewModel.DriverID = driver.DriverID;

                    listdrivers.Add(driverViewModel);
                }
                cmdCart.DisplayMember = ("DriverFullName");
                cmdCart.ValueMember = ("DriverID");
                cmdCart.DataSource = listdrivers;
            }
        }



        private void CartexFor_Load(object sender, EventArgs e)
        {
            BindDriver();
            //Driver driver = new Driver();
            //var driverInformation = driver.DriverFirstName + driver.DriverLastName + driver.DriverMobile;
            //using (DriverRepository driverCMB = new DriverRepository())
            //{
            //    List<Driver> drivers = driverCMB.GetAll();
            //    cmdCart.DisplayMember = ("DriverMobile");
            //    cmdCart.ValueMember = ("DriverID");
            //    cmdCart.DataSource = drivers;
            //}
        }

        private void btnShowCartext_Click(object sender, EventArgs e)
        {
            TripRepository tripRepository = new TripRepository();
            Trip trip = new Trip();
            var trips = tripRepository.GetAllTrip();
            int driverID = (int)cmdCart.SelectedValue;
            bool clear = true;
            var Price = trips.Where(x => x.DriverID == driverID && x.Clearing == clear).ToList();
            int totalPrice = 0;
            foreach (var item in Price)
            {
                totalPrice += item.Price;
            };
            int TripCount = trips.Where(x => x.DriverID == driverID && x.Clearing == clear).Count();
            int Debt = totalPrice / 15;

            label2.Text = Convert.ToString(TripCount);
            label3.Text = Convert.ToString(totalPrice);
            label4.Text = Convert.ToString(Debt);
        }

        private void btnClearing_Click(object sender, EventArgs e)
        {

            var Answer = MessageBox.Show("در صورت تسویه تمام بدهی راننده پاک خواهد شد. آیا ادامه می دهید؟ ", "هشدار  ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            TripRepository tripRepository = new TripRepository();
            Trip trip = new Trip();
            var trips = tripRepository.GetAllTrip();
            int driverID = (int)cmdCart.SelectedValue;
            TripsForm tripform = new TripsForm();

            bool clear = true;
            var DebtTrip = trips.Where(x => x.DriverID == driverID && x.Clearing == clear).ToList();
            if (Answer == DialogResult.Yes)
            {
                foreach (var item in DebtTrip)
                {
                    tripRepository.Clear(item);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
