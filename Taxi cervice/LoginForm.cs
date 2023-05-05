using DataAccess.Repositories;
using System;
using System.Windows.Forms;

namespace Taxi_cervice
{
    public partial class frmLogin : Form
    {
        ReservationRepository repository = new ReservationRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (ReservationRepository Rep = new ReservationRepository())
            {
                var Reservation = Rep.Login(txtUserName.Text, txtPassword.Text);
                if (Reservation == null)
                {
                    MessageBox.Show("نام کاربری یا رمز عبور نامعتبر می باشد");
                }
                else
                {
                    MainForm MForm = new MainForm(Reservation);
                    this.Hide();
                    MForm.Show();
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
