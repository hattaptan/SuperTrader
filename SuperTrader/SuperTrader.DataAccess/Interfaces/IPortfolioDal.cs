using SuperTrader.Base.Interfaces;
using SuperTrader.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTrader.DataAccess.Interfaces
{
    public interface IPortfolioDal : IEntityRepository<Portfolio>
    {
    }
}
