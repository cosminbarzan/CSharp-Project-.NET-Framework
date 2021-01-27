using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NBA_League.Model;
using NBA_League.Repository;

namespace NBA_League.Service
{
    class ServiceJucatorActiv
    {
        private IRepository<Tuple<String, String>, JucatorActiv> repoJucatorActiv;
        public ServiceJucatorActiv(IRepository<Tuple<String, String>, JucatorActiv> repoJucatorActiv)
        {
            this.repoJucatorActiv = repoJucatorActiv;
        }

        public JucatorActiv FindOne(Tuple<String, String> id)
        {
            return repoJucatorActiv.FindOne(id);
        }

        public List<JucatorActiv> FindAll()
        {
            return repoJucatorActiv.FindAll().ToList();
        }

        public IEnumerable<JucatorActiv> JucatoriActivi(String idEchipa, String idMeci, ServiceJucator serviceJucator)
        {
            return FindAll().Where(x => serviceJucator.FindOne(x.ID.Item1).IdEchipa == idEchipa 
                                    && x.ID.Item2 == idMeci);
        }

        public Tuple<int, int> ScorMeci(Meci meci, ServiceJucator serviceJucator)
        {
            var scorGazde = FindAll().Where(x => serviceJucator.FindOne(x.ID.Item1).IdEchipa == meci.IdEchipa1
                                            && x.ID.Item2 == meci.ID).Sum(x => x.NrPuncte);

            var scorOaspeti = FindAll().Where(x => serviceJucator.FindOne(x.ID.Item1).IdEchipa == meci.IdEchipa2
                                            && x.ID.Item2 == meci.ID).Sum(x => x.NrPuncte);

            return new Tuple<int, int>(scorGazde, scorOaspeti);
        }
    }
}
