using SuperTrader.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTrader.Business.Services
{
    public interface ISellService
    {
        List<Sell> GetAll();
        Sell GetById(int id);
        Sell Add(Sell sell);
        Sell Update(Sell sell);
        void Delete(Sell sell);
    }
}
