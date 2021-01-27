using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_League.Model.Validator
{
    class JucatorActivValidator : IValidator<JucatorActiv>
    {
        public void Validate(JucatorActiv jucatorActiv)
        {
            string message = "";
            bool valid = true;
            //TODO
            if (valid == false)
            {
                message += "Jucatorul Activ nu este valid!";
                throw new ValidationException(message);
            }
        }
    }
}
