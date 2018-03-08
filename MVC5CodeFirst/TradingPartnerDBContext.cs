using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MVC5CodeFirst
{
    public class TradingPartnerDBContext:DbContext
    {
        public DbSet<DocType> DocTypes { get; set; }
        public DbSet<TradingPartner>   TradingPartners   { get; set; }
    }
}