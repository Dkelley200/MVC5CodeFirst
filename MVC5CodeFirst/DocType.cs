using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC5CodeFirst
{
    public class DocType
    {
        public int Id { get; set; }
        public String DocName { get; set; }
        public String Location { get; set; }
        public List<TradingPartner> TradingPartner { get; set; }
    }
}