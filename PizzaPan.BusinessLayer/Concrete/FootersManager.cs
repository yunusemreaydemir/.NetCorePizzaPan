using Pizzapan.DataAccessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;
using PizzaPan.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPan.BusinessLayer.Concrete
{
    public class FootersManager : IFootersService
    {
        private readonly IFootersDal _footersDal;

        public FootersManager(IFootersDal footersDal)
        {
            _footersDal = footersDal;
        }

        public void TDelete(Footers t)
        {
            _footersDal.Delete(t);
        }

        public Footers TGetByID(int id)
        {
            return _footersDal.GetByID(id);
        }

        public List<Footers> TGetList()
        {
           return _footersDal.GetList();
        }

        public void TInsert(Footers t)
        {
            _footersDal.Insert(t);
        }

        public void TUpdate(Footers t)
        {
            _footersDal.Update(t);
        }
    }
}
