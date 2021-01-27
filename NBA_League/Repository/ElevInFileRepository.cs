using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NBA_League.Model;
using NBA_League.Model.Validator;

namespace NBA_League.Repository
{
    class ElevInFileRepository : InFileRepository<String, Elev>
    {
        public ElevInFileRepository(IValidator<Elev> validator, String fileName)
            : base(validator, fileName, EntityToFileMapping.CreateElev) { }
    }
}
