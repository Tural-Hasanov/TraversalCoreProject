using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRApiForSql.DAL
{

    public enum Ecity
    {
        Baki = 1,
        Sumqayit = 2,
        Salyan = 3,
        Neftcala = 4,
        Qebele = 5

    }
    public class Visitor
    {
        public int VisitorID { get; set; }
        public Ecity City { get; set; }
        public int CityVisitCount { get; set; }
        public DateTime VisitDate { get; set; }
    }

}
