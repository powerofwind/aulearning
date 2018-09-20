using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demoapi.Controllers;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace DataController.Controllers {
     

    [Route ("api/[controller]/[action]")]
    public class DataController : Controller {
       
       IMongoCollection<booklist> bookCollection;
        public DataController()
        {
             // ต่อฐานข้อมูล
            var client = new MongoDB.Driver.MongoClient("mongodb://tatae:ta1234@ds131721.mlab.com:31721/tatae");
            var db = client.GetDatabase("tatae");
           
           bookCollection = db.GetCollection<booklist>("book");
        }
          [HttpGet("{keyword}")]
        public IEnumerable<booklist> GetBookByName(string keyword)
        {
            // Retrive all data -> qry
            //var qry = collection.Find(it=> it.name == keyword  ).ToList();
            var qry = bookCollection.Find(it => it.name.Contains(keyword)).ToList();

            // Return qry back to caller
            return qry;
        }
         [HttpPost]
        public booklist CreateNewBook([FromBody] booklist data)
        {
            data.id = Guid.NewGuid().ToString();

            // Save new book -> db
            bookCollection.InsertOne(data);

            return data;
        }
         


        
    }
}