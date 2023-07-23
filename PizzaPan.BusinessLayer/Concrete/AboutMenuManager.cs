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
    public class AboutMenuManager : IAboutMenuService
    {
        private readonly IAboutMenuDal _aboutMenuDal;

        public AboutMenuManager(IAboutMenuDal aboutMenuDal)
        {
            _aboutMenuDal = aboutMenuDal;
        }

        public void TDelete(AboutMenu t)
        {
            _aboutMenuDal.Delete(t);
        }

        public AboutMenu TGetByID(int id)
        {
            return _aboutMenuDal.GetByID(id);
        }

        public List<AboutMenu> TGetList()
        {
            return _aboutMenuDal.GetList();
        }

        public void TInsert(AboutMenu t)
        {
            _aboutMenuDal.Insert(t);
        }

        public void TUpdate(AboutMenu t)
        {
            _aboutMenuDal.Update(t);
        }
    }
}
