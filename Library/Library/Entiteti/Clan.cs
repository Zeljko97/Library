using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Driver;
using MongoDB.Bson;

namespace Library.Entiteti
{
    public class Clan
    {
        public ObjectId Id { get; set; }
        public int brojClanskeKarte { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string zanimanje { get; set; }
        public string adresa { get; set; }
        public string brojTelefona { get; set; }
        public string brojLicneKarte { get; set; }
        public List<MongoDBRef> iznajmljeneKnjige { get; set; }

    }
}
