using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NBA_League.Model.Validator;

namespace NBA_League.Model.Validator
{
    class ElevValidator : IValidator<Elev>
    {
        public void Validate(Elev elev)
        {
            String message = "";
            bool valid = true;

            if (valid == false)
            {
                message += "Elevul nu e valid!";
                throw new ValidationException(message);
            }
        }
    }
}
