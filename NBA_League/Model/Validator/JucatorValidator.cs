using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_League.Model.Validator
{
    class JucatorValidator : IValidator<Jucator>
    {
        public void Validate(Jucator jucator)
        {
            String message = "";
            bool valid = true;

            if (jucator.Nume == "")
            {
                message += "Numele nu poate fi vid!\n";
                valid = false;
            }
            if (jucator.Nume.Length <= 3)
            {
                message += "Numele trebuie sa contina cel putin 3 litere!";
                valid = false;
            }

            if (jucator.Scoala == "")
            {
                message += "Scoala nu poate fi vid!\n";
                valid = false;
            }
            if (jucator.Scoala.Length <= 3)
            {
                message += "Scoala trebuie sa contina cel putin 3 litere!";
                valid = false;
            }

            if (valid == false)
            {
                throw new ValidationException(message);
            }
        }
    }
}
