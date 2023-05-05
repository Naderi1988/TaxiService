using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
using DataAccess.Services;
using DomainModel.Model;
using DomainModel.ViewModel;
using DomainModel.ViewModel.Customer;

namespace DataAccess.Repositories
{
    public class CustomerRepository : ICustomer, IDisposable

    {
        Model4 db = new Model4();

        public void Dispose()
        {
            this.db.Dispose();
        }
        public Customer Get(int Id)
        {
            var customer = db.Customers.FirstOrDefault(x => x.CustomerID == Id);
            return customer;
        }

        public List<Customer> GetAll()

        {
            return db.Customers.ToList();
        }

        public List<CustomerFulInformation> GetCustomerList()
        {
            throw new NotImplementedException();
        }

        public int RegisterCustomer(Customer NCustomer)
        {
            db.Customers.Add(NCustomer);
            db.SaveChanges();
            return NCustomer.CustomerID;
        }

        public bool Remove(int IdCustomer)
        {
            try
            {
                var c = db.Customers.FirstOrDefault(x => x.CustomerID == IdCustomer);
                db.Customers.Remove(c);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Customer> Search(CustomerSearchModel sm)
        {
            var q = from Item in db.Customers select Item;
            if (!string.IsNullOrEmpty(sm.CustomerFirstName))
            {
                q = q.Where(x => x.CustomerFirstName.StartsWith(sm.CustomerFirstName));
            }
            if (!string.IsNullOrEmpty(sm.CustomerLastName))
            {
                q = q.Where(x => x.CustomerLastName.StartsWith(sm.CustomerLastName));
            }
            if (!string.IsNullOrEmpty(sm.CustomerSubscriberNumber))
            {
                q = q.Where(x => x.CustomerSubscriberNumber.StartsWith(sm.CustomerSubscriberNumber));
            }
            return q.ToList();
        }

        public bool Update(Customer newCustomer)
        {
            try
            {
                var old = db.Customers.FirstOrDefault(x => x.CustomerID == newCustomer.CustomerID);
                old.CustomerFirstName = newCustomer.CustomerFirstName;
                old.CustomerLastName = newCustomer.CustomerLastName;
                old.CustomerSubscriberNumber = newCustomer.CustomerSubscriberNumber;
                old.CustomerTel = newCustomer.CustomerTel;
                old.CustomerMobilel = newCustomer.CustomerMobilel;
                old.CustomerAddress = newCustomer.CustomerAddress;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
