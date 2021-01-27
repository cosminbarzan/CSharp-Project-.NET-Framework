using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NBA_League.Model;

namespace NBA_League.Repository
{
    interface IRepository<ID, E> where E : Entity<ID>
    {
        E FindOne(ID id);

        IEnumerable<E> FindAll();

        E Save(E entity);

        E Delete(ID id);

        E Update(E entity);
    }
}
