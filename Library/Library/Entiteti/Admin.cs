using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Driver;
using MongoDB.Bson;
namespace Library.Entiteti
{
    public class Admin
    {
        public ObjectId Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
