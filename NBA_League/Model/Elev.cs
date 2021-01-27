using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_League.Model
{
    class Elev : Entity<String>
    {
        public String Nume { get; set; }

        public String Scoala { get; set; }

        public override string ToString()
        {
            return ID + " " + Nume + " " + Scoala;
        }
    }
}
