using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_League.Model
{
    class Meci : Entity<String>
    {
        public String IdEchipa1 { get; set; }

        public String IdEchipa2 { get; set; }

        public DateTime Data { get; set; }

        public override string ToString()
        {
            return $"{ID} {IdEchipa1} {IdEchipa2} {Data.ToString("d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture)}";
        }
    }
}
