using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexAssignment
{
    public class Custom : Exception
    {
        public readonly ExceptionType type;
        public enum ExceptionType
        {
            INVALID_FIRST_NAME, INVALID_LAST_NAME, INVALID_MOBILE_NUMBER, INVALID_PASSWORD, INVALID_EMAIL
        }
        public Custom(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
