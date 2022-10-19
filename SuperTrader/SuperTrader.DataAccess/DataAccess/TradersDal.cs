using SuperTrader.Base.Manager;
using SuperTrader.DataAccess.Context;
using SuperTrader.DataAccess.Interfaces;
using SuperTrader.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTrader.DataAccess.DataAccess
{
    public class TradersDal : EntityRepository<Traders, SuperTraderContext>, ITradersDal
    {
    }
}
