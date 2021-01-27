using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_League.Model.Validator
{
    class EchipaValidator : IValidator<Echipa>
    {
        public void Validate(Echipa echipa)
        {
            String message = "";
            bool valid = true;

            if (echipa.Nume == "")
            {
                message += "Numele nu poate fi vid!\n";
                valid = false;
            }
            if (echipa.Nume.Length <= 3)
            {
                message += "Numele trebuie sa contina cel putin 3 litere!";
                valid = false;
            }

            if (valid == false)
            {
                throw new ValidationException(message);
            }
        }
    }
}
