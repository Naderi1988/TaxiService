using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repositories;
using DomainModel.Model;
using DomainModel.ViewModel;
using DomainModel.ViewModel.Driver;
using FrameWork;

namespace Taxi_cervice
{
    public partial class DriverForm : Form
    {
        RegularExpression regularExpression = new RegularExpression();
        DriverRepository repository = new DriverRepository();
        Driver driver = new Driver();
        #region UtilityFunctions
        private void BindGrid()
        {

            grdDriver.AutoGenerateColumns = false;
            grdDriver.DataSource = repository.GetAll();
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
                            TextBox textBox = (TextBox)a;
                            textBox.Text = "";
                        }
                }
                if (ctr is TextBox)
                {
                    TextBox textBox = (TextBox)ctr;
                    textBox.Text = "";
                }
                if (ctr is RichTextBox)
                {
                    RichTextBox richTextBox = (RichTextBox)ctr;
                    richTextBox.Text = "";
                }
                if (ctr is PictureBox)
                {
                    PictureBox pictureBox = (PictureBox)ctr;
                    pictureBox.Image = null;
                }
            }

            BindGrid();
        }
        private void GoToEditeMode()
        {
            btnDriverEdit.Visible = true;
            btnDriverCancel.Visible = true;
            btnDriverAdd.Visible = false;
        }
        private void GoToAddMode()
        {
            btnDriverEdit.Visible = false;
            btnDriverCancel.Visible = true;
            btnDriverAdd.Visible = true;
        }
        #endregion 
        public DriverForm()
        {
            InitializeComponent();
        }

        private void DriverForm_Load(object sender, EventArgs e)
        {
            GoToAddMode();
            BindGrid();
        }

        private void txtDriverAdd_Click(object sender, EventArgs e)
        {
            driver.DriverFirstName = txtDriverFirstName.Text;
            if (driver.DriverFirstName == "")
            {
                throw new Exception("لطفا نام راننده را وارد نمایید");
            }
            else
            {
                if (regularExpression.persionLetterRegex.IsMatch(driver.DriverFirstName))
                {
                    driver.DriverFirstName = txtDriverFirstName.Text;
                }
                else
                {
                    throw new Exception("لطفا برای وارد کردن نام راننده از حروف فارسی استفاده نمایید");
                }
            }

            driver.DriverLastName = txtDriverLastName.Text;
            if (driver.DriverLastName == "")
            {
                throw new Exception("لطفا نام خانوادگی راننده را وارد نمایید");
            }
            else
            {
                if (regularExpression.persionLetterRegex.IsMatch(driver.DriverLastName))
                {
                    driver.DriverLastName = txtDriverLastName.Text;
                }
                else
                {
                    throw new Exception("لطفا برای وارد کردن نام خانوادگی راننده از حروف فارسی استفاده نمایید");
                }
            }

            driver.DriverNationalCode = txtNationalCode.Text;
            if (driver.DriverNationalCode == "")
            {
                throw new Exception("لطفا کد ملی راننده را وارد نمایید");
            }
            else
            {
                if (!regularExpression.numberRegex.IsMatch(driver.DriverNationalCode))
                {
                    driver.DriverNationalCode = txtNationalCode.Text;
                }
                else
                {
                    throw new Exception("لطفا برای وارد کردن کد ملی راننده از اعداد استفاده نمایید");
                }
            }

            driver.DriverMobile = txtDriverMobile.Text;
            if (driver.DriverMobile == "")
            {
                throw new Exception("لطفا شماره موبایل راننده را وارد نمایید");
            }
            else
            {
                if (regularExpression.numberRegex.IsMatch(driver.DriverMobile))
                {
                    driver.DriverMobile = txtDriverMobile.Text;
                }
                else
                {
                    throw new Exception("لطفا برای وارد کردن شماره موبایل راننده از اعداد استفاده نمایید");
                }
            }

            driver.DriverTell = txtDriverTel.Text;
            if (driver.DriverTell == "")
            {
                throw new Exception("لطفا شماره تلفن راننده را وارد نمایید");
            }
            else
            {
                if (regularExpression.numberRegex.IsMatch(driver.DriverTell))
                {
                    driver.DriverTell = txtDriverTel.Text;
                }
                else
                {
                    throw new Exception("لطفا برای وارد کردن شماره تلفن راننده از اعداد استفاده نمایید");
                }
            }

            driver.DraiverAdress = txtDriverAdress.Text;
            if (driver.DraiverAdress == "")
            {
                throw new Exception("لطفا آدرس راننده را وارد نمایید");
            }
            else
            {
                if (regularExpression.persionLetterRegex.IsMatch(driver.DraiverAdress))
                {
                    driver.DraiverAdress = txtDriverAdress.Text;
                }
                else
                {
                    throw new Exception("لطفا برای وارد کردن آدرس راننده از حروف فارسی استفاده نمایید");
                }
            }

            repository.RegisterDriver(driver);
            ClearForm();
            BindGrid();
        }
        private void btnDriverCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            GoToAddMode();
        }
        private void btnDriverEdit_Click(object sender, EventArgs e)
        {
            driver.DriverID = Convert.ToInt32(txtDriverID.Text);
            driver.DriverFirstName = txtDriverFirstName.Text;
            driver.DriverLastName = txtDriverLastName.Text;
           
            try
            {
                var DriverNationalCode = repository.GetAll().Where(x => x.DriverNationalCode == txtNationalCode.Text).FirstOrDefault();
               
                   
                    if (DriverNationalCode != null)
                    {
                        throw new Exception("این کد ملی قبلا وارد شده است");
                    }
                    else
                    {
                        driver.DriverNationalCode = txtNationalCode.Text;
                    }
                
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            driver.DriverTell = txtDriverTel.Text;
            driver.DriverMobile = txtDriverMobile.Text;
            driver.DraiverAdress = txtDriverAdress.Text;
            repository.Update(driver);
            ClearForm();
            BindGrid();
            GoToAddMode();
        }
        private void GrdDriver_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int DriverId = Convert.ToInt32(grdDriver.Rows[e.RowIndex].Cells[0].Value);
            if (e.ColumnIndex == 4)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = @"All Images Files (*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif)|*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif" +
                             @"|PNG Portable Network Graphics (*.png)|*.png" +
                             @"|JPEG File Interchange Format (*.jpg *.jpeg *jfif)|*.jpg;*.jpeg;*.jfif" +
                             @"|BMP Windows Bitmap (*.bmp)|*.bmp" +
                             @"|TIF Tagged Imaged File Format (*.tif *.tiff)|*.tif;*.tiff" +
                             @"|GIF Graphics Interchange Format (*.gif)|*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var savingFileNameForDB = @"/Images/" + System.IO.Path.GetFileName(openFileDialog.FileName);
                    var SavingUrl = Environment.CurrentDirectory + savingFileNameForDB;
                    File.Copy(openFileDialog.FileName, SavingUrl);
                    repository.AssignPictuteToDriver(DriverId, savingFileNameForDB);
                    driverPicture.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
            if (e.ColumnIndex == 5)
            {
                if (MessageBox.Show("آیا از حذف این راننده مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    repository.Remove(DriverId);
                    BindGrid();
                }
            }
            if (e.ColumnIndex == 6)
            {

                if (MessageBox.Show("آیا از حذف این تصویر مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    var driver=  repository.Get(DriverId);
                    var removeFileNameForDB = @"/Images/" + Path.GetFileName(driver.picture);
                    //var DeleteUrl = Directory.GetDirectories . removeFileNameForDB;
                    File.Delete(Environment.CurrentDirectory + removeFileNameForDB);
                    repository.RemoveDriverPictute(DriverId, removeFileNameForDB);

                   
                    
                   
                    //File.Delete( DeleteUrl);
                    BindGrid();
                }





                //var removeFileNameForDB = @"/Images/" + System.IO.Path.GetFileName(openFileDialog.FileName);
                //if (Directory.Exists(Path.GetDirectoryName(removeFileNameForDB)))
                //{
                //    try
                //    {
                //        File.Delete(removeFileNameForDB);
                //    }
                //    catch
                //    {
                         
                        
                //            throw new Exception("لطفا برای وارد کردن آدرس راننده از حروف فارسی استفاده نمایید");
                        
                //    }
                    
                //}
            }
                if (e.ColumnIndex == 7)
            {
                GoToEditeMode();
                {

                    var driver = repository.Get(DriverId);
                    txtDriverFirstName.Text = driver.DriverFirstName;
                    txtDriverLastName.Text = driver.DriverLastName;
                    txtNationalCode.Text = driver.DriverNationalCode;
                    txtDriverTel.Text = driver.DriverTell;
                    txtDriverMobile.Text = driver.DriverMobile;
                    txtDriverID.Text = Convert.ToString(driver.DriverID);
                    var img = driver.picture;
                    img = Environment.CurrentDirectory + img;
                    if (System.IO.File.Exists(img))
                    {
                        driverPicture.Image = Image.FromFile(img);
                    }
                    BindGrid();

                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DriverRepository repository = new DriverRepository();
            DriverSearchModel DdriverSearchModel = new DriverSearchModel();

            if (!string.IsNullOrEmpty(txtSearchDriverFirstName.Text))
            {
                DdriverSearchModel.DriverFirstName = txtSearchDriverFirstName.Text;
            }
            if (!string.IsNullOrEmpty(txtSearchDriverLastName.Text))
            {
                DdriverSearchModel.DriverLastName = txtSearchDriverLastName.Text;
            }
            grdDriver.AutoGenerateColumns = false;
            grdDriver.DataSource = repository.Search(DdriverSearchModel);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
