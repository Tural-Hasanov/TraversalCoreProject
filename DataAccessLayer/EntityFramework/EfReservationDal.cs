﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        public List<Reservation> GetListWithReservationByAccepted(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Include(x => x.AppUser).Where(x => x.Status == "Təsdiqləndi" && x.AppUSerID == id).ToList();
            }
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Keçmiş Rezervasiya" && x.AppUSerID == id).ToList();
            }
        }

        public List<Reservation> GetListWithReservationByWaitApproval(int id)
        {

            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x=>x.Status== "Təsdiq Gözləyir" && x.AppUSerID==id).ToList();
            }
        }
    }
}
