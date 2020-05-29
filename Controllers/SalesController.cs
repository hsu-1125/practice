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
        [HttpGet]
        public Response Sales()
        {
            var response = new Response();
            MongoClient client = new MongoClient("mongodb://localhost:27017");
            MongoDatabaseBase db = client.GetDatabase("ntut") as MongoDatabaseBase;
            var salesCollection = db.GetCollection<SalesCollection>("sales");
            var query = new BsonDocument();

            var result = salesCollection.Aggregate().Match(query)
                     .Group(e => e.item,
                         e => new sales
                         {
                             _id = null,
                      

                             count = e.Count()
                         }) 

                      .ToList();    
            response.items = result;
            return response;
        }    
      
    }
    
}
