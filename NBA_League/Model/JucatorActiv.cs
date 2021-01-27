using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_League.Model
{
    enum Status { Rezerva, Participant}
    class JucatorActiv : Entity<Tuple<String, String>>
    {
        public int NrPuncte { get; set; }

        public Status Tip { get; set; }

        public override string ToString()
        {
            return $"{ID.Item1} {ID.Item2} {NrPuncte} {Tip}";
        }
    }
}
