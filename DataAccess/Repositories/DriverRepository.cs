using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Services;
using DomainModel.Model;
using DomainModel.ViewModel;
using DomainModel.ViewModel.Driver;

namespace DataAccess.Repositories
{

    public class DriverRepository : IDriver, IDisposable

    {
        Model4 db = new Model4();

        public void AssignPictuteToDriver(int DriverID, string PictuteAddress)
        {
            var old = db.Drivers.FirstOrDefault(x => x.DriverID == DriverID);
            old.picture = PictuteAddress;
            db.SaveChanges();

        }

        public void Dispose()
        {
            this.db.Dispose();
        }

        public void FullNAme(string Name, string famili)
        {
            throw new NotImplementedException();
        }

        //public void FullNAme(string Name, string famili)
        //{
        //   var fullName= Driver.
        //}

        public Driver Get(int IdDriver)
        {
            var driver = db.Drivers.FirstOrDefault(x => x.DriverID == IdDriver);
            return driver;
        }

        public List<Driver> GetAll()
        {
          
            return db.Drivers.ToList();
           
        }

        public List<DriverFulInformation> GetDriverList()
        {
            throw new NotImplementedException();
            //var q = from item in db.Drivers
            //        orderby item.DriverFirstName
            //        select new DriverFulInformation
            //        {
            //            CustomerID = item.CustomerID
            //            ,
            //            dr = item.CustomerName + "   " + item.Mobile

            //        };
            //return q.ToList();

        }

        public int RegisterDriver(Driver NDriver)
        {
            db.Drivers.Add(NDriver);
            db.SaveChanges();
            return NDriver.DriverID;
        }

        public bool Remove(int IdDriver)
        {
            try
            {
                var driver = db.Drivers.FirstOrDefault(x => x.DriverID == IdDriver);
                db.Drivers.Remove(driver);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        

        public void RemoveDriverPictute(int DriverID, string PictuteAddress)
        {
            var old = db.Drivers.FirstOrDefault(x => x.DriverID == DriverID);
            old.picture = null;
            db.SaveChanges();
        }

        public List<Driver> Search(DriverSearchModel sm)
        {
            var q = from Item in db.Drivers select Item;
            if (!string.IsNullOrEmpty(sm.DriverFirstName))
            {
                q = q.Where(x => x.DriverFirstName.StartsWith(sm.DriverFirstName));
            }
            if (!string.IsNullOrEmpty(sm.DriverLastName))
            {
                q = q.Where(x => x.DriverLastName.StartsWith(sm.DriverLastName));
            }

            
            return q.ToList();
        }

        public bool Update(Driver NDriver)
        {
            try
            {
                var old = db.Drivers.FirstOrDefault(x => x.DriverID == NDriver.DriverID);
                old.DriverFirstName = NDriver.DriverFirstName;
                old.DriverLastName = NDriver.DriverLastName;
                old.DriverNationalCode = NDriver.DriverNationalCode;
                old.DriverTell = NDriver.DriverTell;
                old.DriverMobile = NDriver.DriverMobile;
               
                old.DraiverAdress = NDriver.DraiverAdress;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        List<DriverFullName> IDriver.GetAll()
        {
            throw new NotImplementedException();
        }

       
    }
}
