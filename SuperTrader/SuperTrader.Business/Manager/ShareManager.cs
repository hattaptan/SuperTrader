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
    public class ShareManager : IShareService
    {
        private IShareDal _shareDal;

        public ShareManager(IShareDal shareDal)
        {
            _shareDal = shareDal;
        }
        public Share Add(Share share)
        {
           return _shareDal.Add(share);
        }

        public void Delete(Share share)
        {
            _shareDal.Delete(share);
        }

        public List<Share> GetAll()
        {
           return _shareDal.GetList();
        }

        public Share GetById(int id)
        {
            return _shareDal.Get(p=>p.Id == id);
        }

        public Share Update(Share share)
        {
           return _shareDal.Update(share);
        }
    }
}
