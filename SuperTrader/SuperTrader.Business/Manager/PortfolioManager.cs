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
    public class PortfolioManager : IPortfolioService
    {
        private IPortfolioDal _portfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }

        public Portfolio Add(Portfolio portfolio)
        {
            return _portfolioDal.Add(portfolio);
        }

        public void Delete(Portfolio portfolio)
        {
            _portfolioDal.Delete(portfolio);
        }

        public List<Portfolio> GetAll()
        {
            return _portfolioDal.GetList();
        }

        public Portfolio GetById(int id)
        {
            return _portfolioDal.Get(p => p.id == id);
        }

        public Portfolio Update(Portfolio portfolio)
        {
            return _portfolioDal.Update(portfolio);
        }
    }
}
