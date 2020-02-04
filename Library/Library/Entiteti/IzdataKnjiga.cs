using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Driver;
using MongoDB.Bson;

namespace Library.Entiteti
{
    public class IzdataKnjiga
    {
        public ObjectId Id { get; set; }
        public string knjiga { get; set; }
        public string datumIzdavanja { get; set; }
        public string datumVracanja { get; set; }
        public MongoDBRef Clan { get; set; }
    }
}
