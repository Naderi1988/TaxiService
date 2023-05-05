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
using DomainModel.ViewModel.Car;
using System.Text.RegularExpressions;
using FrameWork;

namespace Taxi_cervice
{

    public partial class CarForm : Form
    {
        RegularExpression regularExpression = new RegularExpression();
        CarRepository repository = new CarRepository();
        Car car = new Car();
        public CarForm()
        {
            InitializeComponent();
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            BindGrid();
            GoToAddMode();
        }

        private void GoToAddMode()
        {
            btnAdd.Visible = true;
            btnUpdate.Visible = false;
            btnCancel.Visible = true;
        }
        private void GoToEditeMode()
        {
            btnAdd.Visible = false;
            btnUpdate.Visible = true;
            btnCancel.Visible = true;
        }
        private void BindGrid()
        {
            grdCar.AutoGenerateColumns = false;
            grdCar.DataSource = repository.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                car.CarMake = txtCarMake.Text;
                if (car.CarMake == "")
                {
                    throw new Exception("لطفا نام شرکت سازنده خودرو را وارد نمایید");
                }
                else
                {
                    if (regularExpression.persionLetterRegex.IsMatch(car.CarMake))
                    {
                        car.CarMake = txtCarMake.Text;
                    }
                    else
                    {
                        throw new Exception("لطفا برای وارد کردن نام شرکت سازنده از حروف فارسی استفاده نمایید");
                    }
                }

                car.CarModel = txtCarModel.Text;
                if (car.CarModel == "")
                {
                    throw new Exception("لطفا نام مدل خودرو را وارد نمایید");
                }
                else
                {
                    if (regularExpression.persionLetterRegex.IsMatch(car.CarModel))
                    {
                        car.CarModel = txtCarModel.Text;
                    }
                    else
                    {
                        throw new Exception("لطفا برای وارد کردن مدل خودرو از حروف فارسی استفاده نمایید");
                    }
                }

                car.CarModelYear = txtCarModelYear.Text;
                if (car.CarModelYear == "")
                {
                    throw new Exception("لطفا سال ساخت خودرو را وارد نمایید");
                }
                else
                {
                    if (car.CarModelYear.Length > 4 || car.CarModelYear.Length < 4)
                    {
                        throw new Exception("لطفا برای وارد کردن سال ساخت خودرو مانند نمونه وارد نمایید: 1402");
                    }
                    {
                        if (regularExpression.numberRegex.IsMatch(car.CarModelYear))
                        {
                            car.CarModelYear = txtCarModelYear.Text;
                        }
                        else
                        {
                            throw new Exception("لطفا برای وارد کردن سال ساخت خودرو فقط از اعداد استفاد نمایید. مانند: 1402");
                        }
                    }
                }

                car.CarColor = txtCarColor.Text;
                if (car.CarColor == "")
                {
                    throw new Exception("لطفا رنگ خودرو را وارد نمایید");
                }
                else
                {
                    if (regularExpression.persionLetterRegex.IsMatch(car.CarColor))
                    {
                        car.CarColor = txtCarColor.Text;
                    }
                    else
                    {
                        throw new Exception("لطفا برای وارد کردن رنگ خودرو از حروف فارسی استفاده نمایید");
                    }
                }

                car.CarNumberPlate = txtCarNumberPlate.Text;
                if (car.CarNumberPlate == "")
                {
                    throw new Exception("لطفا شماره پلاک خودرو را وارد نمایید");
                }
                else
                {
                    if (car.CarNumberPlate.Length > 8 || car.CarNumberPlate.Length < 8)
                    {
                        throw new Exception("لطفا برای وارد کردن شماره پلاک خودرو مانند نمونه وارد نمایید: 32ب243");
                    }
                    else
                    {
                        var CarNumberPlate = repository.GetAll().Where(x => x.CarNumberPlate == car.CarNumberPlate);
                        if (CarNumberPlate != null)
                        {
                            throw new Exception("این شماره پلاک قبلا وارد شده است");
                        }
                        else
                        {
                            car.CarNumberPlate = txtCarNumberPlate.Text;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
            repository.RegisterCar(car);
            ClearForm();
            BindGrid();
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
            }
            BindGrid();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            GoToAddMode();
        }

        private void grdCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (MessageBox.Show("آیا از حذف این خودرو مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int CarId = Convert.ToInt32(grdCar.Rows[e.RowIndex].Cells[0].Value);
                    repository.Remove(CarId);
                    BindGrid();
                }
            }
            if (e.ColumnIndex == 7)
            {
                GoToEditeMode();
                {
                    int CarId = Convert.ToInt32(grdCar.Rows[e.RowIndex].Cells[0].Value);
                    var car = repository.Get(CarId);
                    txtCarID.Text = Convert.ToString(car.CarID);
                    txtCarMake.Text = car.CarMake;
                    txtCarModel.Text = car.CarModel;
                    txtCarModelYear.Text = car.CarModelYear;
                    txtCarNumberPlate.Text = car.CarNumberPlate;

                    txtCarColor.Text = car.CarColor;
                    BindGrid();

                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            car.CarID = Convert.ToInt32(txtCarID.Text);
            car.CarMake = txtCarMake.Text;
            car.CarModel = txtCarModel.Text;
            car.CarModelYear = txtCarModelYear.Text;
            car.CarColor = txtCarColor.Text;
            
            try
            {
                var CarNumberPlate = repository.GetAll().Where(x => x.CarNumberPlate == txtCarNumberPlate.Text).FirstOrDefault();
                if (CarNumberPlate != null)
                {
                    throw new Exception("این شماره پلاک قبلا وارد شده است");
                }
                else
                {
                    car.CarNumberPlate = txtCarNumberPlate.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;

            }
            repository.Update(car);
            ClearForm();
            BindGrid();
            GoToAddMode();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            CarSearchModel carSearchModel = new CarSearchModel();
            if (!string.IsNullOrEmpty(txtSeachCarModel.Text))
            {
                carSearchModel.CarModel = txtSeachCarModel.Text;
            }
            if (!string.IsNullOrEmpty(txtSearchCarColor.Text))
            {
                carSearchModel.CarColor = txtSearchCarColor.Text;
            }

            grdCar.AutoGenerateColumns = false;
            grdCar.DataSource = repository.Search(carSearchModel); ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
