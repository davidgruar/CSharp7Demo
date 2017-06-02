namespace CSharp7Demo
{
    public class OutVariables
    {
        public void IntegerParsing(string someString)
        {
            if (int.TryParse(someString, out var i))
            {
                var someNumber = i * 2;
            }
        }
    }
}