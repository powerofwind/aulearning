using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace demoapi.Controllers {

    [Route ("api/[controller]/[action]")]
    public class DataController : Controller {
        

        // public DataController()
        // {
        //      // ต่อฐานข้อมูล
        //     var client = new MongoDB.Driver.MongoClient("mongodb://ametisz:pui19625@ds255282.mlab.com:55282/demodb");
        //     var db = client.GetDatabase("demodb");
        //     bookCollection = db.GetCollection<BookList>("BookList");
        //     sexToyCollection = db.GetCollection<BookList>("SexYoys");
        // }


        
    }
}