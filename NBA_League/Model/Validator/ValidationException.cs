using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_League.Model.Validator
{
    class ValidationException : ApplicationException
    {
        public ValidationException(string message) : base(message) { }
    }
}
