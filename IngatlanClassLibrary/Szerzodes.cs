using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngatlanClassLibrary
{
    public class Szerzodes
    {
        public int SZERZODES_ID { get; set; }
        public Resztvevo ELADO_ID { get; set; }
        public Resztvevo VEVO_ID { get; set; }
        public IngatlanClass INGATLAN_ID { get; set; }
        public DateTime SZERZODES_DATUM { get; set; }
        public string SZERZODES_NEV { get; set; }
        public string DOKUMENTUM { get; set; }
    }
}
