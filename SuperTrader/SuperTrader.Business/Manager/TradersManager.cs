using SuperTrader.Business.Services;
using SuperTrader.DataAccess.Interfaces;
using SuperTrader.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTrader.Business.Manager
{
    public class TradersManager : ITradersService
    {
        private ITradersDal _tradersDal;
        public TradersManager(ITradersDal tradersDal)
        {
            _tradersDal=tradersDal;
        }

        public Traders Add(Traders traders)
        {
          return _tradersDal.Add(traders);
        }

        public void Delete(Traders traders)
        {
            _tradersDal.Delete(traders);
        }

        public List<Traders> GetAll()
        {
            return _tradersDal.GetList();
        }

        public Traders GetById(int id)
        {
            return _tradersDal.Get(p=>p.id==id);
        }

        public Traders Update(Traders traders)
        {
           return _tradersDal.Update(traders);
        }
    }
}
