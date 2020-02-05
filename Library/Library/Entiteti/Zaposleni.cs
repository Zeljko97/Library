using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Library.Entiteti
{
    public class Zaposleni
    {
        public ObjectId Id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string JMBG { get; set; }
        public string datum_rodjenja { get; set; }
        public int radni_staz { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
