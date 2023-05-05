using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Model;
using DomainModel.ViewModel.Origin;

namespace DataAccess.Services
{
    interface IOrigin
    {
        int RegisterOrigin(Origin NOrigin);
        bool Remove(int IdOrigin);
        bool Update(Origin NOrigin);
        Origin Get(int IdOrigin);
        List<Origin> GetAllOrigins();
        List<DomainModel.ViewModel.Origin.OriginListItem> GetAllForDrop();
        List<Origin> Search(OriginSearchModel sm);
    }
}
