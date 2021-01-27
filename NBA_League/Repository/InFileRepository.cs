using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NBA_League.Model;
using NBA_League.Model.Validator;

namespace NBA_League.Repository
{
    public delegate E CreateEntity<E>(String record);
    abstract class InFileRepository<ID, E> : InMemoryRepository<ID, E> where E : Entity<ID>
    {
        protected String FileName;
        protected CreateEntity<E> CreateEntity;

        protected InFileRepository(IValidator<E> validator, String fileName, CreateEntity<E> createEntity) : base(validator)
        {
            FileName = fileName;
            CreateEntity = createEntity;

            if (CreateEntity != null)
                LoadFromFile();
        }

        protected virtual void LoadFromFile()
        {
            List<E> list = DataReader.ReadData(FileName, CreateEntity);
            list.ForEach(x => entities[x.ID] = x);
        }
    }
}
