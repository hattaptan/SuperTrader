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
    public class BuyManager : IBuyService
    {
        private IBuyDal _buyDal;

        public BuyManager(IBuyDal buydal)
        {
            _buyDal = buydal;
        }
        public Buy Add(Buy buy)
        {
          return _buyDal.Add(buy);
        }

        public void Delete(Buy buy)
        {
            _buyDal.Delete(buy);
        }

        public List<Buy> GetAll()
        {
            return _buyDal.GetList();
        }

        public Buy GetById(int id)
        {
            return _buyDal.Get(p => p.Id == id);
        }

        public Buy Update(Buy buy)
        {
            return _buyDal.Update(buy);
        }
    }
}
