using DomainModel.Model;
using DomainModel.ViewModel.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    interface ICar
    {
        int RegisterCar(Car NCar);
        bool Remove(int CarId);
        bool Update(Car NCar);
        Car Get(int CarId);
        List<Car> GetAll();
        List<Car> Search(CarSearchModel sm);
    }
}
