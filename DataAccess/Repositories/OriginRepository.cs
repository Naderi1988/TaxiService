using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Services;
using DomainModel.Model;
using DomainModel.ViewModel;
using DomainModel.ViewModel.Origin;

namespace DataAccess.Repositories
{
    public class OriginRepository : IOrigin, IDisposable
    {
        Model4 db = new Model4();
       
        public List<Origin> GetAllOrigins()
        {
            return db.Origins.ToList();
        }

        public bool Remove(int IdOrigin)
        {
            try
            {
                var origin = db.Origins.FirstOrDefault(x => x.OriginID == IdOrigin);
                db.Origins.Remove(origin);
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Update(Origin NOrigin)
        {
            try
            {
                var old = db.Origins.FirstOrDefault(x => x.OriginID == NOrigin.OriginID);
                old.OriginName = NOrigin.OriginName;
                 db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void Dispose()
        {
            this.db.Dispose();
        }
       
        public List<Origin> Search(OriginSearchModel sm)
        {
            var q = from Item in db.Origins select Item;
            if (!string.IsNullOrEmpty(sm.OriginName))
            {
                q = q.Where(x => x.OriginName.StartsWith(sm.OriginName));
            }
            return q.ToList();
        }

        public int RegisterOrigin(Origin NOrigin)
        {
            db.Origins.Add(NOrigin);
            db.SaveChanges();
            return NOrigin.OriginID;
        }

        public Origin Get(int IdOrigin)
        {
            var origin = db.Origins.FirstOrDefault(x => x.OriginID == IdOrigin);
            return origin;
        }

        public List<OriginListItem> GetAllForDrop()
        {
            var q = from item in db.Origins
                    select new OriginListItem
                    {
                        OriginID = item.OriginID
                        ,
                        OriginName = item.OriginName
                    };
            return q.ToList();
        }

        
    }



}
