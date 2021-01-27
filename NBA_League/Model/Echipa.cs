using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_League.Model
{
    class Echipa : Entity<String>
    {
        public String Nume { get; set; }

        public override string ToString()
        {
            return ID + " " + Nume; 
        }
    }
}
