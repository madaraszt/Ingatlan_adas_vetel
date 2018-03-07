using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngatlanClassLibrary
{
    public class IngatlanClass
    {
        public int INGATLAN_ID { get; set; }
        public string HRSZ_SZAM { get; set; }
        public string TELEPULES { get; set; }
        public int IRANYITOSZAM { get; set; }
        public string KOZTERULET { get; set; }
        public string HAZSZAM { get; set; }
        public string EPULET { get; set; }
        public string EMELET { get; set; }
        public string AJTO { get; set; }
        public Resztvevo TULAJDONOS { get; set; }
    }
}
