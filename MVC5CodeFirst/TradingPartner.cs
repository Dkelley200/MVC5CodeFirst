using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MVC5CodeFirst
{
    public class TradingPartner
    {
        public int Id { get; set; }
        public string  TPName { get; set; }
        public String BuyerFirstName { get; set; }
        public String BuyerLastName { get; set; }
        public DocType DocType { get; set; }

    }
}