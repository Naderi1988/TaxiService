using DataAccess.Services;
using DomainModel.Model;
using DomainModel.ViewModel.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class CarRepository : ICar, IDisposable
    {
        Model4 db = new Model4();
        public void Dispose()
        {
            this.db.Dispose();
        }

        public int RegisterCar(Car NCar)
        {
            db.Cars.Add(NCar);
            db.SaveChanges();
            return NCar.CarID;
        }

        public bool Remove(int CarId)
        {
            try
            {
                var car = db.Cars.FirstOrDefault(x => x.CarID == CarId);
                db.Cars.Remove(car);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(Car NCar)
        {
            try
            {
                var old = db.Cars.FirstOrDefault(x => x.CarID == NCar.CarID);
                old.CarID = NCar.CarID;
                old.CarMake = NCar.CarMake;
                old.CarModel = NCar.CarModel;
                old.CarModelYear = NCar.CarModelYear;
                old.CarNumberPlate = NCar.CarNumberPlate;
                old.CarColor = NCar.CarColor;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Car Get(int CarId)
        {
            var car = db.Cars .FirstOrDefault(x => x.CarID == CarId);
            return car;
        }

        public List<Car> GetAll()
        {
            return db.Cars.ToList();
        }

        public List<Car> Search(CarSearchModel sm)
        {
            var q = from Item in db.Cars select Item;
            if (!string.IsNullOrEmpty(sm.CarColor))
            {
                q = q.Where(x => x.CarColor.StartsWith(sm.CarColor));
            }
            if (!string.IsNullOrEmpty(sm.CarModel))
            {
                q = q.Where(x => x.CarModel.StartsWith(sm.CarModel));
            }

            return q.ToList();
        }
    }
}
