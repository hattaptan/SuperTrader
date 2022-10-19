using SuperTrader.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTrader.Business.Services
{
    public interface IPortfolioService
    {
        List<Portfolio> GetAll();
        Portfolio GetById(int id);
        Portfolio Add(Portfolio portfolio);
        Portfolio Update(Portfolio portfolio);
        void Delete(Portfolio portfolio);
    }
}
