using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Library.Entiteti
{
    public class Sektor
    {
        public ObjectId Id {get;set;}
        public string oznakaSektora { get; set; }
        public List<MongoDBRef> knjigeUSektoru {get;set;}

        public Sektor()
        {
            knjigeUSektoru = new List<MongoDBRef>();
        }
    }
}
