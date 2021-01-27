using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_League.Model
{
    class EntityToFileMapping
    {
        public static Echipa CreateEchipa(String line)
        {
            String[] fields;
            fields = line.Split(',');

            Echipa echipa = new Echipa
            {
                ID = fields[0],
                Nume = fields[1]
            };

            return echipa;
        }

        public static Elev CreateElev(String line)
        {
            String[] fields;
            fields = line.Split(',');

            Elev elev = new Elev
            {
                ID = fields[0],
                Nume = fields[1],
                Scoala = fields[2]
            };

            return elev;
        }

        public static Jucator CreateJucator(String line)
        {
            String[] fields;
            fields = line.Split(',');

            Jucator jucator = new Jucator
            {
                ID = fields[0],
                Nume = fields[1],
                Scoala = fields[2],
                IdEchipa = fields[3]
            };

            return jucator;
        }

        public static Meci CreateMeci(String line)
        {
            String[] fields;
            fields = line.Split(',');

            Meci meci = new Meci
            {
                ID = fields[0],
                IdEchipa1 = fields[1],
                IdEchipa2 = fields[2],
                Data = DateTime.ParseExact(fields[3], "d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture)
            };

            return meci;
        }

        public static JucatorActiv CreateJucatorActiv(String line)
        {
            String[] fields;
            fields = line.Split(',');

            JucatorActiv jucatorActiv = new JucatorActiv
            {
                ID = new Tuple<string, string>(fields[0], fields[1]),
                NrPuncte = Int32.Parse(fields[2]),
                Tip = (Status)Enum.Parse(typeof(Status), fields[3])
            };

            return jucatorActiv;
        }
    }
}
