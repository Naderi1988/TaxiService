using DomainModel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxi_cervice
{
    public partial class MainForm : Form
    {
        public Reservation LogdInReservation { get; set; }
        public MainForm(Reservation reservation)
        {
            InitializeComponent();
            this.LogdInReservation = reservation;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void رانندگانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsActive = false;

            foreach(Form driver in this.MdiChildren)
            {
                if (driver is DriverForm)  
                {
                    driver.Activate();
                    IsActive = true;
                }

            }
            if(! IsActive)
            {
                DriverForm driver = new DriverForm();
                driver.MdiParent = this;
                driver.Show();
            }

           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            SetDateTime();
            lblUserName.Text = LogdInReservation.ReservationFirstName + "  " + LogdInReservation.ReservationLastName;
        }

        private void SetDateTime()
        {
            lblDate.Text = FrameWork.PersianDate.Topersian(DateTime.Now);
            lblTime.Text = DateTime.Now.ToLongTimeString().ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetDateTime();
        }

        

        private void مدیریتمشتریانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsActive = false;

            foreach (Form customer in this.MdiChildren)
            {
                if (customer is CustomersForm)
                {
                    customer.Activate();
                    IsActive = true;
                }

            }
            if (!IsActive)
            {
                CustomersForm customer = new CustomersForm();
                customer.MdiParent = this;
                customer.Show();
            }
            
        }

       

        private void رزویشنهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsActive = false;

            foreach (Form reservation in this.MdiChildren)
            {
                if (reservation is ReservationForm)
                {
                    reservation.Activate();
                    IsActive = true;
                }

            }
            if (!IsActive)
            {
                ReservationForm reservation = new ReservationForm();
                reservation.MdiParent = this;
                reservation.Show();
            }
        }

        private void مدیریتسفرهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsActive = false;

            foreach (Form trip in this.MdiChildren)
            {
                if (trip is TripsForm)
                {
                    trip.Activate();
                    IsActive = true;
                }

            }
            if (!IsActive)
            {
                TripsForm trip = new TripsForm();
                trip.MdiParent = this;
                trip.Show();
            }
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void مدیریتخودروهاStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsActive = false;

            foreach (Form car in this.MdiChildren)
            {
                if (car is CarForm)
                {
                    car.Activate();
                    IsActive = true;
                }

            }
            if (!IsActive)
            {
                CarForm car = new CarForm();
                car.MdiParent = this;
                car.Show();
            }
        }
    }
}
