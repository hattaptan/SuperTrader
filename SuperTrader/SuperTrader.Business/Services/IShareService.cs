using SuperTrader.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTrader.Business.Services
{
    public interface IShareService
    {
        List<Share> GetAll();
        Share GetById(int id);
        Share Add(Share share);
        Share Update(Share share);
        void Delete(Share share);
    }
}
