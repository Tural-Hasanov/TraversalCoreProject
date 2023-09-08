using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfContactUsDal : GenericRepository<ContactUs>, IContactUsDal
    {
        public void ChangeMessageStatusFalse(int id)
        {
            var c = new Context();
            var values = c.ContactUss.Where(x => x.ContactUsID == id).FirstOrDefault();
            values.MessageStatus = false;
            c.SaveChanges();

        }

        public List<ContactUs> GetListStatus()
        {
            var c = new Context();

            var values = c.ContactUss.Where(x => x.MessageStatus == true).ToList();
            return values;
        }
    }
}
        


    
