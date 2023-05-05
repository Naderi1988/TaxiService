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
using DomainModel.ViewModel.Customer;
using FrameWork;

namespace Taxi_cervice
{
    public partial class CustomersForm : Form

    {
        CustomerRepository repository = new CustomerRepository();
        RegularExpression regularExpression = new RegularExpression();
        Customer customer = new Customer();
        #region UtilityFunctions
        private void BindGrid()
        {
           
            grdCustomer.AutoGenerateColumns = false;
            grdCustomer.DataSource = repository.GetAll();
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
                if (ctr is RichTextBox)
                {
                    RichTextBox tb = (RichTextBox)ctr;
                    tb.Text = "";
                }
                if (ctr is Panel)
                {
                    foreach (Control a in ctr.Controls)
                        if (a is TextBox)
                        {
                            TextBox d = (TextBox)a;
                            d.Text = "";
                        }
                }
            }

            BindGrid();
        }
        private void GoToEditeMode()
        {
            btnCustomerEdit.Visible = true;
            btnCustomerExit.Visible = true;
            btnCustomerAdd.Visible = false;
        }
        private void GoToAddMode()
        {
            btnCustomerEdit.Visible = false;
            btnCustomerExit.Visible = true;
            btnCustomerAdd.Visible = true;
        }
        #endregion 
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            BindGrid();
            GoToAddMode();
        }
        private void btnCustomerExit_Click(object sender, EventArgs e)
        {
            ClearForm();
            GoToAddMode();
        }
        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            customer.CustomerFirstName = txtCustomerFirstName.Text;
            try
            {
                if (customer.CustomerFirstName == "")
                {
                    throw new Exception("لطفا نام مشتری را وارد نمایید");
                }
                else
                {
                    if (regularExpression.persionLetterRegex.IsMatch(customer.CustomerFirstName))
                    {
                        customer.CustomerFirstName = txtCustomerFirstName.Text;
                    }
                    else
                    {
                        throw new Exception("لطفا برای وارد کردن نام مشتری از حروف فارسی استفاده نمایید");
                    }
                }

                customer.CustomerLastName = textCustomerLastName.Text;
                if (customer.CustomerLastName == "")
                {
                    throw new Exception("لطفا نام خانوادگی مشتری را وارد نمایید");
                }
                else
                {
                    if (regularExpression.persionLetterRegex.IsMatch(customer.CustomerFirstName))
                    {
                        customer.CustomerLastName = textCustomerLastName.Text;
                    }
                    else
                    {
                        throw new Exception("لطفا برای وارد کردن نام خانوادگی مشتری از حروف فارسی استفاده نمایید");
                    }
                }

                customer.CustomerMobilel = txtCustomerMobile.Text;
                if (customer.CustomerMobilel == "")
                {
                    throw new Exception("لطفا شماره موبایل مشتری را وارد نمایید");
                }
                else
                {
                    if (customer.CustomerMobilel.Length != 11)
                    {
                        throw new Exception("تعداد ارقام وارد شده برای شماره موبایل مشتری صحیح نمی باشد");
                    }
                    else
                    {
                        if (regularExpression.numberRegex.IsMatch(customer.CustomerMobilel))
                        {

                        }
                        else
                        {
                            throw new Exception("لطفا برای وارد کردن شماره موبایل مشتری از اعداد استفاده نمایید");
                        }
                    }
                }

                customer.CustomerTel = txtCustomerMobile.Text;
                if (customer.CustomerTel == "")
                {
                    throw new Exception("لطفا تلفن مشتری را وارد نمایید");
                }
                else
                {
                    if (customer.CustomerTel.Length != 8)
                    {
                        throw new Exception("تعداد ارقام وارد شده برای شماره تلفن مشتری صحیح نمی باشد");
                    }
                    else
                    {
                        if (regularExpression.numberRegex.IsMatch(customer.CustomerMobilel))
                        {
                            customer.CustomerTel = txtCustomerTel.Text;
                        }
                        else
                        {
                            throw new Exception("لطفا برای وارد کردن شماره تلفن مشتری از اعداد استفاده نمایید");
                        }
                    }
                }

                customer.CustomerAddress = txtCustomerAdress.Text;
                if (customer.CustomerAddress == "")
                {
                    throw new Exception("لطفا آدرس مشتری را وارد نمایید");
                }
                else
                {

                }
                customer.CustomerSubscriberNumber = txtCustomerSubscriberNumber.Text;
                if (customer.CustomerSubscriberNumber == "")
                {
                    throw new Exception("لطفا شماره اشتراک مشتری را وارد نمایید");
                }
                else
                {
                    if (!regularExpression.numberRegex.IsMatch(customer.CustomerMobilel))
                    {
                        throw new Exception("لطفا برای وارد کردن شماره اشتراک مشتری از اعداد استفاده نمایید");
                    }
                    else
                    {
                        var CustomerSubscriberNumber = repository.GetAll().Where(x => x.CustomerSubscriberNumber == customer.CustomerSubscriberNumber);
                        if (CustomerSubscriberNumber != null)
                        {
                            throw new Exception("این شماره اشتراک قبلا وارد شده است");
                        }
                        else
                        {
                            customer.CustomerSubscriberNumber = txtCustomerSubscriberNumber.Text;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            repository.RegisterCustomer(customer);
            ClearForm();
            BindGrid();
        }
        private void btnCustomerEdit_Click(object sender, EventArgs e)
        {

            customer.CustomerFirstName = txtCustomerFirstName.Text;
            customer.CustomerLastName = textCustomerLastName.Text;
            customer.CustomerTel = txtCustomerTel.Text;
            customer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            customer.CustomerAddress = txtCustomerAdress.Text;
            customer.CustomerMobilel = txtCustomerMobile.Text;
            try
            {
                if (!regularExpression.numberRegex.IsMatch(customer.CustomerMobilel))
                {
                    throw new Exception("لطفا برای وارد کردن شماره اشتراک مشتری از اعداد استفاده نمایید");
                }
                else
                {
                    var CustomerSubscriberNumber = repository.GetAll().Where(x => x.CustomerSubscriberNumber == txtCustomerSubscriberNumber.Text).FirstOrDefault();
                    if (CustomerSubscriberNumber != null)
                    {
                        throw new Exception("این شماره اشتراک قبلا وارد شده است");
                    }
                    else
                    {
                        customer.CustomerSubscriberNumber = txtCustomerSubscriberNumber.Text;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            repository.Update(customer);
            ClearForm();
            BindGrid();
            GoToAddMode();


        }
        private void grdCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 6)
            {
                if (MessageBox.Show("آیا از حذف این مشتری مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int CustomerId = Convert.ToInt32(grdCustomer.Rows[e.RowIndex].Cells[0].Value);
                    repository.Remove(CustomerId);
                    BindGrid();
                }
            }
            if (e.ColumnIndex == 7)
            {
                GoToEditeMode();
                {
                    int CustomerId = Convert.ToInt32(grdCustomer.Rows[e.RowIndex].Cells[0].Value);
                    var customer = repository.Get(CustomerId);
                    txtCustomerAdress.Text = customer.CustomerAddress;
                    txtCustomerFirstName.Text = customer.CustomerFirstName;
                    textCustomerLastName.Text = customer.CustomerLastName;
                    txtCustomerTel.Text = customer.CustomerTel;
                    txtCustomerMobile.Text = customer.CustomerMobilel;
                    txtCustomerID.Text = Convert.ToString(customer.CustomerID);
                    //try
                    //{
                    //    var CustomerSubscriberNumber = repository.GetAll().Where(x => x.CustomerSubscriberNumber == customer.CustomerSubscriberNumber);
                    //    if (CustomerSubscriberNumber != null)
                    //    {
                    //        throw new Exception("این شماره اشتراک قبلا وارد شده است");
                    //    }
                    //    else
                    //    {
                    txtCustomerSubscriberNumber.Text = customer.CustomerSubscriberNumber;
                    //    }
                    //}
                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show(ex.Message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}

                    BindGrid();

                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            CustomerSearchModel cs = new CustomerSearchModel();
            if (!string.IsNullOrEmpty(textSearchCustomerName.Text))
            {
                cs.CustomerFirstName = textSearchCustomerName.Text;
            }
            if (!string.IsNullOrEmpty(textSearchCustomerّfamily.Text))
            {
                cs.CustomerLastName = textSearchCustomerّfamily.Text;
            }
            if (!string.IsNullOrEmpty(txtSearchCustomerSubscriberNumber.Text))
            {
                cs.CustomerSubscriberNumber = txtSearchCustomerSubscriberNumber.Text;
            }
            grdCustomer.AutoGenerateColumns = false;
            grdCustomer.DataSource = repository.Search(cs);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
