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
    public class SellManager : ISellService
    {
        private ISellDal _sellDal;

        public SellManager(ISellDal sellDal)
        {
            _sellDal = sellDal;
        }
        public Sell Add(Sell sell)
        {
            return _sellDal.Add(sell);
        }

        public void Delete(Sell sell)
        {
            _sellDal.Delete(sell);
        }

        public List<Sell> GetAll()
        {
            return _sellDal.GetList();
        }

        public Sell GetById(int id)
        {
            return _sellDal.Get(p=>p.Id==id);
        }

        public Sell Update(Sell sell)
        {
            return _sellDal.Update(sell);
        }
    }
}
