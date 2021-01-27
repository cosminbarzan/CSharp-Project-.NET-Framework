using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NBA_League.Model;
using NBA_League.Repository;

namespace NBA_League.Service
{
    class ServiceMeci
    {
        private IRepository<String, Meci> repoMeci;

        public ServiceMeci(IRepository<String, Meci> repoMeci)
        {
            this.repoMeci = repoMeci;
        }

        public Meci FindOne(String id)
        {
            return repoMeci.FindOne(id);
        }
    
        public List<Meci> FindAll()
        {
            return repoMeci.FindAll().ToList();
        }

        public IEnumerable<Meci> MeciuriPerioada(DateTime dataInceput, DateTime dataSfarsit)
        {
            return FindAll().Where(x => DateTime.Compare(x.Data, dataInceput) >= 0
                                    && DateTime.Compare(x.Data, dataSfarsit) <= 0);
        }
    }
}
