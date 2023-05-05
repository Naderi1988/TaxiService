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
using DataAccess.Repositories;
using DomainModel.ViewModel.Destinition;
using DomainModel.ViewModel.Origin;
using Route = DomainModel.Model.Route;
using System.Text.RegularExpressions;
using FrameWork;

namespace Taxi_cervice
{

    public partial class TripsForm : Form
    {
        RegularExpression regularExpression = new RegularExpression();
        TripRepository repository = new TripRepository();
        Trip trip = new Trip();
        Route route = new Route();
        Destination destination = new Destination();
        Origin origin = new Origin();
        RouteRepository routeRepository = new RouteRepository();
        OriginRepository originRepository = new OriginRepository();
        DestinationsRepository destinationsRepository = new DestinationsRepository();

        PersianDate date = new PersianDate();

        #region UtilityFunctions
        public TripsForm()
        {
            InitializeComponent();
        }
        private void BindGrid()
        {

            grdTrips.AutoGenerateColumns = false;
            grdTrips.DataSource = repository.GetAllTrip();

        }
        private void GoToEditeMode()
        {
            btnAdd.Visible = false;
            btnUpdate.Visible = true;
            btnCancel.Visible = true;
        }
        private void GoToAddMode()
        {
            btnAdd.Visible = true;
            btnUpdate.Visible = false;
            btnCancel.Visible = true;
        }
        private void ClearForm()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is Panel)
                {
                    foreach (Control a in ctr.Controls)
                        if (a is TextBox)
                        {
                            TextBox t = (TextBox)a;
                            t.Text = "";
                        }
                }
                if (ctr is TextBox)
                {
                    TextBox t = (TextBox)ctr;
                    t.Text = "";
                }
                if (ctr is ComboBox)
                {
                    ComboBox d = (ComboBox)ctr;
                    d.SelectedIndex = -1;
                }
            }

            BindGrid();
        }
        #endregion
        private void TripsForm_Load(object sender, EventArgs e)
        {
            BindOriginCMB();
            BindDestinationCMB();
            BindGrid();
            GoToAddMode();
        }

        private void BindDestinationCMB()
        {
            using (DestinationsRepository DestinationCMB = new DestinationsRepository())
            {
                List<DomainModel.ViewModel.Destinition.DestinitionListItem> destinations = DestinationCMB.GetAllForDrop();
                DestinitionListItem d = new DestinitionListItem {DestinationID = -1, DestinationsName = "مقصد را انتخاب کنید" };
                destinations.Insert(0, d);
                cmbDestination.DisplayMember = ("DestinationsName");
                cmbDestination.ValueMember = ("DestinationID");
                cmbDestination.DataSource = destinations;
            }
        }
        private void BindOriginCMB()
        {
            using (OriginRepository OriginCMB = new OriginRepository())
            {
                List<DomainModel.ViewModel.Origin.OriginListItem > Origins = OriginCMB.GetAllForDrop();
                OriginListItem o = new OriginListItem { OriginID = -1, OriginName = "مبدا را انتخاب کنید" };
               Origins.Insert(0, o);
                cmbOrigin.DisplayMember = ("OriginName");
                cmbOrigin.ValueMember = ("OriginID");
                cmbOrigin.DataSource = Origins;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            trip.ReservationID = Convert.ToInt32(txtREsevationID.Text);
            try
            {
                if (trip.ReservationID < 0)
                {
                    throw new Exception("لطفا شناسه رزویشن را وارد نمایید");
                }
                else
                {
                    if (regularExpression.numberRegex.IsMatch(Convert.ToString(trip.ReservationID)))
                    {
                        trip.ReservationID = Convert.ToInt32(txtREsevationID.Text);
                    }
                    else
                    {
                        throw new Exception("لطفا برای وارد کردن شناسه رزویشن از اعداد استفاده نمایید");
                    }
                }

                trip.CustomerID = Convert.ToInt32(txtCustomerID.Text);
                if (trip.CustomerID < 0)
                {
                    throw new Exception("لطفا شناسه مشتری را وارد نمایید");
                }
                else
                {
                    if (regularExpression.numberRegex.IsMatch(Convert.ToString(trip.CustomerID)))
                    {
                        trip.CustomerID = Convert.ToInt32(txtCustomerID.Text);
                    }
                    else
                    {
                        throw new Exception("لطفا برای وارد کردن شناسه مشتری از اعداد استفاده نمایید");
                    }
                }

                trip.DriverID = Convert.ToInt32(txtDriverID.Text);
                if (trip.DriverID < 0)
                {
                    throw new Exception("لطفا شناسه راننده را وارد نمایید");
                }
                else
                {
                    if (regularExpression.numberRegex.IsMatch(Convert.ToString(trip.DriverID)))
                    {
                        trip.DriverID = Convert.ToInt32(txtDriverID.Text);
                    }
                    else
                    {
                        throw new Exception("لطفا برای وارد کردن شناسه راننده از اعداد استفاده نمایید");
                    }
                }
                trip.CarID = Convert.ToInt32(txtCarID.Text);
                if (trip.CarID < 0)
                {
                    throw new Exception("لطفا شناسه خودرو را وارد نمایید");
                }
                else
                {
                    if (regularExpression.numberRegex.IsMatch(Convert.ToString(trip.CarID)))
                    {
                        trip.CarID = Convert.ToInt32(txtCarID.Text);
                    }
                    else
                    {
                        throw new Exception("لطفا برای وارد کردن شناسه خودرو از اعداد استفاده نمایید");
                    }
                }

                trip.StartTripData = CalenderTime.SelectedDateTime;
                

                trip.OriginID = Convert.ToInt32(cmbOrigin.SelectedValue);
                if (trip.OriginID < 0)
                {
                    throw new Exception("لطفا شناسه مبدا را وارد نمایید");
                }
                else
                {
                    if (regularExpression.numberRegex.IsMatch(Convert.ToString(trip.OriginID)))
                    {
                        trip.OriginID = Convert.ToInt32(cmbOrigin.SelectedValue);
                    }
                    else
                    {
                        throw new Exception("لطفا برای وارد کردن شناسه مبدا از اعداد استفاده نمایید");
                    }
                }

                trip.DestinationID = Convert.ToInt32(cmbDestination.SelectedValue);
                if (trip.DestinationID < 0)
                {
                    throw new Exception("لطفا شناسه مقصد را وارد نمایید");
                }
                else
                {
                    if (regularExpression.numberRegex.IsMatch(Convert.ToString(trip.DestinationID)))
                    {
                        trip.DestinationID = Convert.ToInt32(cmbDestination.SelectedValue);
                    }
                    else
                    {
                        throw new Exception("لطفا برای وارد کردن شناسه مقصد از اعداد استفاده نمایید");
                    }
                }

                trip.Price = Convert.ToInt32(txtPrice.Text);
                if (trip.Price < 0)
                {
                    throw new Exception("لطفا lfgy را وارد نمایید");
                }
                else
                {
                    if (regularExpression.numberRegex.IsMatch(Convert.ToString(trip.Price)))
                    {
                        trip.Price = Convert.ToInt32(txtPrice.Text);
                    }
                    else
                    {
                        throw new Exception("لطفا برای وارد کردن lfgy از اعداد استفاده نمایید");
                    }
                }

                trip.Clearing = Convert.ToBoolean(txtClear.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
            repository.RegisterTrip(trip);
            ClearForm();
            BindGrid();
        }
        private void grdTrips_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 5)
            {
                if (MessageBox.Show("آیا از حذف این سفر مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int TripId = Convert.ToInt32(grdTrips.Rows[e.RowIndex].Cells[0].Value);
                    repository.Remove(TripId);
                    BindGrid();
                }
            }
            if (e.ColumnIndex == 6)
            {
                GoToEditeMode();
                {
                    int TripId = Convert.ToInt32(grdTrips.Rows[e.RowIndex].Cells[0].Value);
                    var trip = repository.Get(TripId);
                    var origin = originRepository.Get(trip.OriginID);
                    var destination = destinationsRepository.Get(trip.DestinationID);

                    txtCustomerID.Text = Convert.ToString(trip.CustomerID);
                    cmbDestination.Text = destination.DestinationsName;
                    cmbOrigin.Text = origin.OriginName;
                    CalenderTime.Text = Convert.ToString(trip.StartTripData);
                    txtClear.Text = Convert.ToString(trip.Clearing);
                    txtREsevationID.Text = Convert.ToString(trip.ReservationID);
                    txtTripID.Text = Convert.ToString(trip.TripID);
                    txtPrice.Text = Convert.ToString(trip.Price);
                    txtDriverID.Text = Convert.ToString(trip.DriverID);
                    txtCarID.Text = Convert.ToString(trip.CarID);
                    BindGrid();
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            trip.TripID = Convert.ToInt32(txtTripID.Text);
            trip.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            trip.DestinationID = Convert.ToInt32(cmbDestination.SelectedValue);
            trip.OriginID = Convert.ToInt32(cmbOrigin.SelectedValue);
            trip.Price = Convert.ToInt32(txtPrice.Text);
            trip.StartTripData = Convert.ToDateTime(CalenderTime.Text);
            trip.Price = Convert.ToInt32(txtPrice.Text);
            trip.ReservationID = Convert.ToInt32(txtREsevationID.Text);
            trip.Clearing = Convert.ToBoolean(txtClear.Text);
            repository.Update(trip);
            routeRepository.Update(route);

            ClearForm();
            BindGrid();
            GoToAddMode();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            GoToAddMode();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var originId = (int)cmbOrigin.SelectedValue;
            var destinationId = (int)cmbDestination.SelectedValue;
            var d = routeRepository.GetAllRoute();
            var c = d.Where(x => x.OriginID == originId && x.DestinationID == destinationId).FirstOrDefault();
            txtPrice.Text = Convert.ToString(c.Price);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbOrigin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

