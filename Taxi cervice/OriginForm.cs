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
using DomainModel.ViewModel.Origin;
using FrameWork;

namespace Taxi_cervice
{
    public partial class OriginForm : Form
    {
        RegularExpression regularExpression = new RegularExpression();
        OriginRepository repository = new OriginRepository();
        Origin origin = new Origin();
        #region UtilityFunctions

        public OriginForm()
        {
            InitializeComponent();
        }
        private void BindGrid()
        {
            
            grdOrigin.AutoGenerateColumns = false;
            grdOrigin.DataSource = repository.GetAllOrigins();
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
                if(ctr is ComboBox)
                {
                    ComboBox o = (ComboBox)ctr;
                    o.SelectedIndex = -1;
                }
            }

            BindGrid();
        }
        private void GoToEditeMode()
        {
            btnOriginAdd.Visible = false;
            btnOriginEdit.Visible = true;
            btnOriginExit.Visible = true;
        }
        private void GoToAddMode()
        {
            btnOriginAdd.Visible = true;
            btnOriginEdit.Visible = false;
            btnOriginExit.Visible = true;
        }
        private void OriginForm_Load(object sender, EventArgs e)
        {
            BindGrid();
            GoToAddMode();
        }
        private void btnOriginAdd_Click(object sender, EventArgs e)
        {
            try
            {
                origin.OriginName = txtOriginName.Text;
                if (origin.OriginName == "")
                {
                    throw new Exception("لطفا نام مبدا را وارد نمایید");
                }
                else
                {
                    if (regularExpression.persionLetterRegex.IsMatch(origin.OriginName))
                    {
                        origin.OriginName = txtOriginName.Text;
                    }
                    else
                    {
                        throw new Exception("لطفا برای وارد کردن نام مبدا از حروف فارسی استفاده نمایید");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
            repository.RegisterOrigin(origin);
            ClearForm();
            BindGrid();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OriginRepository rep = new OriginRepository();
            if (e.ColumnIndex == 2)
            {
                if (MessageBox.Show("آیا از حذف این محل مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int OriginId = Convert.ToInt32(grdOrigin.Rows[e.RowIndex].Cells[0].Value);
                    rep.Remove(OriginId);
                    BindGrid();
                }
                
            }
            if (e.ColumnIndex == 3)
            {
                GoToEditeMode();
                {
                    int OriginId = Convert.ToInt32(grdOrigin.Rows[e.RowIndex].Cells[0].Value);
                    var o = rep.Get(OriginId);
                    txtOriginID.Text = Convert.ToString(o.OriginID);
                    txtOriginName.Text = o.OriginName;
                    BindGrid();
                   
                }
            }
        }
        private void btnOriginEdit_Click(object sender, EventArgs e)
        {
            OriginRepository repository = new OriginRepository();
            Origin origin = new Origin();
            origin.OriginID = Convert.ToInt32(txtOriginID.Text);
            origin.OriginName = txtOriginName.Text;

            repository.Update(origin);
            ClearForm();
            BindGrid();
            GoToAddMode();
        }

        private void btnOriginExit_Click(object sender, EventArgs e)
        {
            ClearForm();
            GoToAddMode();
        }
        #endregion

        private void OriginFrm(object sender, EventArgs e)
        {
            BindGrid();
            GoToAddMode();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            OriginRepository repository = new OriginRepository();
            OriginSearchModel originSearchModel = new OriginSearchModel();
            if (!string.IsNullOrEmpty(txtSearchOrigin.Text))
            {
                originSearchModel.OriginName = txtSearchOrigin.Text;
            }
            grdOrigin.AutoGenerateColumns = false;
            grdOrigin.DataSource = repository.Search(originSearchModel);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
