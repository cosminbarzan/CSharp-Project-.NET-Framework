using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NBA_League.Model;
using NBA_League.Model.Validator;

namespace NBA_League.Repository
{
    class JucatorInFileRepository : InFileRepository<String, Jucator>
    {
        public JucatorInFileRepository(IValidator<Jucator> validator, String fileName)
            : base(validator, fileName, EntityToFileMapping.CreateJucator) { }
    }
}
