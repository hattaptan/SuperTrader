using SuperTrader.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTrader.Business.Services
{
    public interface IBuyService
    {
        List<Buy> GetAll();
        Buy GetById(int id);
        Buy Add(Buy buy);
        Buy Update(Buy buy);
        void Delete(Buy buy);
    }
}
