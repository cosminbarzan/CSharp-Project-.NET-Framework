using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NBA_League.Model;
using NBA_League.Repository;

namespace NBA_League.Service
{
    class ServiceJucator
    {
        private IRepository<String, Jucator> repoJucator;

        public ServiceJucator(IRepository<String, Jucator> repoJucator)
        {
            this.repoJucator = repoJucator;
        }

        public Jucator FindOne(String id)
        {
            return repoJucator.FindOne(id);
        }

        public List<Jucator> FindAll()
        {
            return repoJucator.FindAll().ToList();
        }

        public IEnumerable<Jucator> JucatoriEchipe(List<Jucator> jucatori, String id)
        {
            return jucatori.Where(x => x.IdEchipa == id);
        }
    }
}
