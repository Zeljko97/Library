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
        public string brojClanskeKarte { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string zanimanje { get; set; }
        public string adresa { get; set; }
        public string brojTelefona { get; set; }
        public string brojLicneKarte { get; set; }
      //public List<MongoDBRef> iznajmljeneKnjige { get; set; }
        public List<ObjectId> iznajmljeneKnjige { get; set; }
        //dodato zbog logovanja
        public string username { get; set; }
        public string password { get; set; }

        public Clan()
        {
            iznajmljeneKnjige = new List<ObjectId>();
        }

    }
}
