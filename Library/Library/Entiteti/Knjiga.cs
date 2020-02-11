using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
namespace Library.Entiteti
{
    public class Knjiga
    {
        public ObjectId Id { get; set; }
        public string naslov { get; set; }
        public string autor { get; set; }
        public string zanr { get; set; }
        public string izdavac { get; set; }
        public string povez { get; set; }
        public int brojStrana { get; set; }
        public int brojPrimeraka { get; set; }
        public List<string> oznake { get; set; }
        public MongoDBRef Sektor { get; set; }
        ///
        public List<ObjectId> IzdataClanovima { get; set; }

        public Knjiga()
        {
            IzdataClanovima = new List<ObjectId>();
        }
    }
}
