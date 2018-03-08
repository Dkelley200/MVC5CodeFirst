using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MVC5CodeFirst
{
    public class TradingPartnerRespository
    {
       public List<DocType> GetDocType()
        {
            TradingPartnerDBContext tradingPartnerDBContext = new TradingPartnerDBContext();
            return tradingPartnerDBContext.DocTypes.Include("TradingPartner").ToList();
                    

        }
    }
}