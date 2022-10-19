using SuperTrader.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTrader.Business.Services
{
    public interface ITradersService
    {
        List<Traders> GetAll();
        Traders GetById(int id);
        Traders Add(Traders traders);
        Traders Update(Traders traders);
        void Delete(Traders traders);
    }
}
