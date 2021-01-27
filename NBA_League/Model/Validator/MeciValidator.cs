using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_League.Model.Validator
{
    class MeciValidator : IValidator<Meci>
    {
        public void Validate(Meci meci)
        {
            String message = "";
            bool valid = true;

            if (meci.IdEchipa1 == "")
            {
                message += "IdEchipa1 nu poate fi vid!\n";
                valid = false;
            }
            if (meci.IdEchipa2 == "")
            {
                message += "IdEchipa2 nu poate fi vid!\n";
                valid = false;
            }

            if (valid == false)
            {
                throw new ValidationException(message);
            }
        }
    }
}
