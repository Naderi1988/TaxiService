using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Model;
using DomainModel.ViewModel.Customer;



namespace DataAccess.Services
{
    interface ICustomer
    {
        int RegisterCustomer(Customer NCustomer);
        bool Update(Customer newCustomer);
        bool Remove(int IdCustomer);
        Customer Get(int Id);
        List<Customer> GetAll();
        List<Customer> Search(CustomerSearchModel sm);
        List<CustomerFulInformation> GetCustomerList();




    }
}
