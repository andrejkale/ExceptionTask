
namespace ExceptionTask
{
    public class NumberCanNotBeParsedException : FormatException
    {
        public NumberCanNotBeParsedException() { }

        public NumberCanNotBeParsedException(string number) 
            : base(String.Format("String: {0} doesn't contain a number", number))
        {

        }
    }
}
