using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NBA_League.Model;
using NBA_League.Model.Validator;

namespace NBA_League.Repository
{
    class InMemoryRepository<ID, E> : IRepository<ID, E> where E : Entity<ID>
    {
        protected IValidator<E> validator;
        protected IDictionary<ID, E> entities = new Dictionary<ID, E>();

        public InMemoryRepository(IValidator<E> validator)
        {
            this.validator = validator;
        }

        public IEnumerable<E> FindAll()
        {
            return entities.Values.ToList<E>();
        }

        public E FindOne(ID id)
        {
            if (entities.ContainsKey(id))
                return entities[id];
            else
                return null;
        }

        public E Save(E entity)
        {
            if (entity == null)
                throw new ArgumentNullException("Entity must be not null!");
            if (entities.ContainsKey(entity.ID))
                return entity;
            else
                entities[entity.ID] = entity;
            //return "Everything is ok"
            //TODO Debug
            return default;
        }

        public E Delete(ID id)
        {
            throw new NotImplementedException();
        }

        public E Update(E entity)
        {
            throw new NotImplementedException();
        }
    }
}
