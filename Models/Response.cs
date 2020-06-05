using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace aggregate.Models
{
    public class Response
    {

        public List<sales> items { get; set; }
        public Response()
        {
            this.items = new List<sales>();
     
        }
    }
        public class sales
        {
            public string _id { get; set; }
            public float totalSaleAmount { get; set; }
            public double averageQuantity { get; set; }
            public int count { get; set; }
            public sales()
            {
                this._id = "";
                this.totalSaleAmount = 0;
                this.averageQuantity = 0.0;
                this.count = 0;
            }
        }

    
}