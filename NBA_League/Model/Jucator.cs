using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_League.Model
{
    class Jucator : Elev
    {
        public String IdEchipa { get; set; }

        public override string ToString()
        {
            return ID + " | " + Nume + " | " + Scoala + " | " + IdEchipa;
        }
    }
}
