using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using MongoDB.Driver.Builders;

namespace Library.Entiteti
{
    public class Zahtev
    {
        public ObjectId Id { get; set;}
        public int  brojClanskeKarte { get; set; }
        public string knjiga { get; set; }
    }
}
