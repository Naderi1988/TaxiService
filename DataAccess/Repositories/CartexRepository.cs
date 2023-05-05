using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Services;

using DomainModel.Model;
using DomainModel.ViewModel.Cartex;

namespace DataAccess.Repositories
{
    public class CartexRepository : ICartex, IDisposable

    {
        Model4 db = new Model4();


        public void Dispose()
        {
            this.db.Dispose();
        }

        public Cartex Get(int IdCartex)
        {
            var cartex = db.Cartexes.FirstOrDefault(x => x.CartexID == IdCartex);
            return cartex;
        }

        public List<Cartex> GetAllCartex()
        {
            return db.Cartexes.ToList();
        }

        public List<CartexFulInformation> GetCartexList()
        {
            throw new NotImplementedException();
        }

        public int RegisterCartex(Cartex NCartex)
        {
            db.Cartexes.Add(NCartex);
            db.SaveChanges();
            return NCartex.CartexID;
        }

        public bool Remove(int IdCartex)
        {
            try
            {
                var cartex = db.Cartexes.FirstOrDefault(x => x.CartexID == IdCartex);
                db.Cartexes.Remove(cartex);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
        public bool Update(Cartex NewCartex)
        {
            try
            {
                var old = db.Cartexes.FirstOrDefault(x => x.CartexID == NewCartex.CartexID);
                old.DriverID = NewCartex.DriverID;
                old.DebiteTripCount = NewCartex.DebiteTripCount;
                old.TotalDebit = NewCartex.TotalDebit;
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
