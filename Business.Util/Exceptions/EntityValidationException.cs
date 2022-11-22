using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Util.Exceptions
{
    public class EntityValidationException : Exception
    {
        public StringBuilder Errors { get; set; }

        public EntityValidationException(string message, StringBuilder errors) : base(message)
        {
            Errors = errors;
        }
    }
}
