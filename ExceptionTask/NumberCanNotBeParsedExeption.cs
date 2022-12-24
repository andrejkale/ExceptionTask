using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTask
{
    public class NumberCanNotBeParsedExeption : FormatException
    {
        public NumberCanNotBeParsedExeption() { }

        public NumberCanNotBeParsedExeption(string number) 
            : base(String.Format("String: {0} doesn't contain a number", number))
        {

        }
    }
}
