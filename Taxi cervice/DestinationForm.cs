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
using DomainModel.ViewModel.Destinition;
using FrameWork;

namespace Taxi_cervice
{
    public partial class DestinationForm : Form
    {
        RegularExpression regularExpression = new RegularExpression();
        DestinationsRepository repository = new DestinationsRepository();
        Destination destination = new Destination();
        public DestinationForm()
        {
            InitializeComponent();
        }
        #region UtilityFunctions
        private void BindGrid()
        {
            
            grdDestination.AutoGenerateColumns = false;
            grdDestination.DataSource = repository.GetAllDestination();
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
        private void GoToEditeMode()
        {
            btnDestinationAdd.Visible = false;
            btnDestinationEdit.Visible = true;
            btnDestinationExit.Visible = true;
        }
        private void GoToAddMode()
        {
            btnDestinationAdd.Visible = true;
            btnDestinationEdit.Visible = false;
            btnDestinationExit.Visible = true;
        }
        private void DestinationForm_Load(object sender, EventArgs e)
        {
            BindGrid();
            GoToAddMode();
        }


        #endregion
        private void btnDestinationAdd_Click(object sender, EventArgs e)
        {
            try
            {
                destination.DestinationsName = txtDestinationName.Text;
                if (destination.DestinationsName == "")
                {
                    throw new Exception("لطفا نام مقصد را وارد نمایید");
                }
                else
                {
                    if (!regularExpression.persionLetterRegex.IsMatch(destination.DestinationsName))
                    {
                        destination.DestinationsName = txtDestinationName.Text;
                    }
                    else
                    {
                        throw new Exception("لطفا برای وارد کردن نام مقصد از حروف فارسی استفاده نمایید");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
            repository.RegisterDestination(destination);
            ClearForm();
            BindGrid();
        }
        private void grdDestination_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DestinationsRepository rep = new DestinationsRepository();
            if (e.ColumnIndex == 2)
            {
                if (MessageBox.Show("آیا از حذف این محل مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int DestinationId = Convert.ToInt32(grdDestination.Rows[e.RowIndex].Cells[0].Value);
                    rep.Remove(DestinationId);
                    BindGrid();
                }
            }
            if (e.ColumnIndex == 3)
            {
                GoToEditeMode();
                {
                    int DestinationId = Convert.ToInt32(grdDestination.Rows[e.RowIndex].Cells[0].Value);
                    var destination = rep.Get(DestinationId);
                    txtDestinationID.Text = Convert.ToString(destination.DestinationID);
                    txtDestinationName.Text = destination.DestinationsName;
                    BindGrid();
                    
                }
            }
        }
        private void btnDestinationEdit_Click(object sender, EventArgs e)
        {
            DestinationsRepository repository = new DestinationsRepository();
            Destination destination = new Destination();
            destination.DestinationID = Convert.ToInt32(txtDestinationID.Text);
            destination.DestinationsName = txtDestinationName.Text;
            repository.Update(destination);
            ClearForm();
            BindGrid();
            GoToAddMode();
        }
        private void btnDestinationExit_Click(object sender, EventArgs e)
        {
            ClearForm();
            GoToAddMode();
        }
        private void DestinationForm_Load_1(object sender, EventArgs e)
        {
            BindGrid();
            GoToAddMode();
        }
        private void btnSerch_Click(object sender, EventArgs e)
        {
            DestinitionSearchModel destinitionSearchModel = new DestinitionSearchModel();
            if (!string.IsNullOrEmpty(txtDestinationName.Text))
            {
                destinitionSearchModel.DestinationsName = txtDestinationSearch.Text;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDestinationName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
