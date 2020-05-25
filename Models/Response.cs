using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aggregate.Models
{
    public class Response
    {
        public List<sales> items { get; set; }

        public  Response()
            {
            this.items = new List<sales> ();
            }

    }
    public class sales
    {
        public date _id { get; set; }

        public int totalSaleAmount { get; set; }

        public float averageQuantity { get; set; }

        public int count { get; set; }

    }

    public class date
    {
        public int year { get; set; }

        public int month { get; set; }

        public int day { get; set; }

    }
}