using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repositories;
using DomainModel.Model;
using DomainModel.ViewModel;
using FrameWork;

namespace Taxi_cervice
{
    public partial class ReservationForm : Form
    {
        RegularExpression regularExpression = new RegularExpression();
        Reservation reservation = new Reservation();
        ReservationRepository repository = new ReservationRepository();
        #region UtilityFunctions
        private void BindGrid()
        {
           
            grdReservation.AutoGenerateColumns = false;
            grdReservation.DataSource = repository.GetAll();
        }

        private void ClearForm()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    TextBox t = (TextBox)ctr;
                    t.Text = "";
                }
            }

            BindGrid();
        }
        private void GoToEditeMode()
        {
            btnAddResevation.Visible = false;
            btnUpdate.Visible = true;
           btnCanselREsevation.Visible = true;
        }
        private void GoToAddMode()
        {
            btnAddResevation.Visible = true;
            btnUpdate.Visible = false;
            btnCanselREsevation.Visible = true;
        }
        #endregion
        public ReservationForm()
        {
            InitializeComponent();
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            BindGrid();
            GoToAddMode();
        }
        private void btnAddResevation_Click(object sender, EventArgs e)
        {
           

            reservation.ReservationFirstName = txtResevationName.Text;
            if (reservation.ReservationFirstName == "")
            {
                throw new Exception("لطفا نام رزویشن را وارد نمایید");
            }
            else
            {
                if (regularExpression.persionLetterRegex.IsMatch(reservation.ReservationFirstName))
                {
                    reservation.ReservationFirstName = txtResevationName.Text;
                }
                else
                {
                    throw new Exception("لطفا برای وارد کردن نام رزویشن از حروف فارسی استفاده نمایید");
                }
            }
            reservation.ReservationLastName = texResevationLastName.Text;
            if (reservation.ReservationLastName == "")
            {
                throw new Exception("لطفا نام خانوادگی رزویشن را وارد نمایید");
            }
            else
            {
                if (regularExpression.persionLetterRegex.IsMatch(reservation.ReservationLastName))
                {
                    reservation.ReservationLastName = texResevationLastName.Text;
                }
                else
                {
                    throw new Exception("لطفا برای وارد کردن نام خانوادگی رزویشن از حروف فارسی استفاده نمایید");
                }
            }
            reservation.ReservationUserName = txtRsevationUserName.Text;
            if (reservation.ReservationUserName == "")
            {
                throw new Exception("لطفا نام نام کاربری رزویشن را وارد نمایید");
            }
            else
            {
                if (regularExpression.englishLetterNumberRegex .IsMatch(reservation.ReservationUserName))
                {
                    reservation.ReservationUserName = txtRsevationUserName.Text;
                }
                else
                {
                    throw new Exception("نام کاربری یا کلمه عبور صحیح نمی باشد");
                }
            }
            reservation.ReservationPassword = txtResevationPassword.Text;
            if (reservation.ReservationPassword == "")
            {
                throw new Exception("لطفا کلمه عبور  را وارد نمایید");
            }
            else
            {
                if (regularExpression.englishLetterNumberRegex.IsMatch(reservation.ReservationPassword))
                {
                    reservation.ReservationPassword = txtResevationPassword.Text;
                }
                else
                {
                    throw new Exception("نام کاربری یا کلمه عبور صحیح نمی باشد");
                }
            }
            repository.RegisterReservationr(reservation);
            ClearForm();
            BindGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.ColumnIndex == 5)
            {
                if (MessageBox.Show("آیا از حذف این رزویشن مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int ReservationId = Convert.ToInt32(grdReservation.Rows[e.RowIndex].Cells[0].Value);
                    repository.Remove(ReservationId);
                    BindGrid();
                }
            }
            if (e.ColumnIndex == 6)
            {
                GoToEditeMode();
                {
                    int ReservationId = Convert.ToInt32(grdReservation.Rows[e.RowIndex].Cells[0].Value);
                    var reservation = repository.Get(ReservationId);
                    txtResevationID.Text = Convert.ToString(ReservationId);
                    txtResevationName.Text = reservation.ReservationFirstName;
                    texResevationLastName.Text = reservation.ReservationLastName;
                    txtRsevationUserName.Text = reservation.ReservationUserName;
                    txtResevationPassword.Text = reservation.ReservationPassword;
                    BindGrid();
                   
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {


            reservation.ReservationID = Convert.ToInt32(txtResevationID.Text);
            reservation.ReservationFirstName = txtResevationName.Text;
            reservation.ReservationLastName = texResevationLastName.Text;
            reservation.ReservationUserName = txtRsevationUserName.Text;
            reservation.ReservationPassword = txtResevationPassword.Text;
            repository.Update(reservation);
            ClearForm();
            BindGrid();
           
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            ClearForm();
            GoToAddMode();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
