﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDestinationService : IGenericSevice<Destination>
    {
        public Destination TGetDestinationsWithGuide(int id);
        public List<Destination> TGetLast4Destinations();
    }
}
