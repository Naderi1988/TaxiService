using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Model;
using DomainModel.ViewModel.Driver;




namespace DataAccess.Services
{
    public interface IDriver
    {
        int RegisterDriver(Driver NDriver);
        bool Remove(int IdDriver);
        bool Update(Driver NDriver);
        Driver Get(int IdDriver);
        List<DriverFullName> GetAll();
        List<Driver> Search(DriverSearchModel sm);
        void AssignPictuteToDriver(int DriverID, string PictuteAddress);
        void RemoveDriverPictute(int DriverID, string PictuteAddress);
        List<DriverFulInformation> GetDriverList();
        void FullNAme(string Name, string famili);
    }
}
