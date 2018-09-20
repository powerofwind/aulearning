using System;
using MongoDB.Bson.Serialization.Attributes;

namespace demoapi.Controllers 
{
    public class booklist 
    {
        [BsonId]
        public string id {get; set;}
        public string name { get; set; }
        public string slot {get; set;}
        public int total {get; set;}

    }
}