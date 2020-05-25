using MongoDB.Bson;
using MongoDB.Driver;
using aggregate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace aggregate.Controllers
{
    public class SalesController : ApiController

    {
       


        [Route("api/sales")]
        [HttpPost]
        public Response Sales(Request request)
        {
            var response = new Response();
            MongoClient client = new MongoClient("mongodb://localhost:27017");
            MongoDatabaseBase db = client.GetDatabase("ntut") as MongoDatabaseBase;
            var salesCollection = db.GetCollection<SalesCollection>("sales");
            var query = Builders<SalesCollection>.Filter.
            var result = salesCollection.Aggregate().Match(query)
                     .Group(e=>e.items,
                     g => new sales
                            {
                                _id = g.Key,
                                totalSaleAmount = g.Sum(x => x.price * x.quantity),
                                averageQuantity = g.Avg(x => x.quantity),
                                count = g.Count()

                            }).Tolist();



            
            return response;
        } 
        
        
    }
    
}
