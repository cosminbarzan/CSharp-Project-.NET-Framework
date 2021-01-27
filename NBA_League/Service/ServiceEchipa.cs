using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NBA_League.Model;
using NBA_League.Repository;

namespace NBA_League.Service
{
    class ServiceEchipa
    {
        private IRepository<String, Echipa> repoEchipa;
    
        public ServiceEchipa(IRepository<String, Echipa> repoEchipa)
        {
            this.repoEchipa = repoEchipa;
        }

        public Echipa FindOne(String id)
        {
            return repoEchipa.FindOne(id);
        }

        public List<Echipa> FindAll()
        {
            return repoEchipa.FindAll().ToList();
        }
    }
}
