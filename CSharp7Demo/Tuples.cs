namespace CSharp7Demo
{
    public class Tuples
    {
        public void TuplesDemo()
        {
            var (message, number) = this.GetResultTuple();
            
        }

        private (string Message, int Number) GetResultTuple()
        {
            return ("Hello world", 42);
        }
    }
}