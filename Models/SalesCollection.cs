using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aggregate.Models
{
    public class SalesCollection
    {
        public object _id { get; set; }

        public string items { get; set; }

        public decimal price { get; set; }

        public int quantity { get; set; }

        public DateTime date { get; set; }






    }
}