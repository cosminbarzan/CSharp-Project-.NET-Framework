using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NBA_League.Model;
using NBA_League.Repository;

namespace NBA_League.Service
{
    class ServiceElev
    {
        private IRepository<String, Elev> repoElev;

        public ServiceElev(IRepository<String, Elev> repoElev)
        {
            this.repoElev = repoElev;
        }

        public Elev FindOne(String id)
        {
            return repoElev.FindOne(id);
        }

        public List<Elev> FindAll()
        {
            return repoElev.FindAll().ToList();
        }
    }
}
