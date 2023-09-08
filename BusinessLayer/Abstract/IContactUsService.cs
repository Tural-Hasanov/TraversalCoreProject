using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactUsService : IGenericSevice<ContactUs>
    {
        List<ContactUs> TGetListStatus();
        public void TChangeMessageStatusFalse(int id);
    }
}
