using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_League.Model.Validator
{
    interface IValidator<E>
    {
        void Validate(E entity);
    }
}
