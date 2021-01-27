using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NBA_League.Model.Validator;
using NBA_League.Model;

namespace NBA_League.Repository
{
    class MeciInFileRepository : InFileRepository<String, Meci>
    {
        public MeciInFileRepository(IValidator<Meci> validator, String fileName)
            : base(validator, fileName, EntityToFileMapping.CreateMeci) { }
    }
}
