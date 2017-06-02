namespace CSharp7Demo
{
    public class CustomDeconstruction
    {
        public void DeconstructionDemo()
        {
            var (message1, number) = GetValues();
            var (message2, _) = GetValues();
            var (m, n, n2) = GetValues();

        }

        private static MyValues GetValues()
        {
            return new MyValues() {Message = "Hello world", Number = 42};
        }
    }

    public class MyValues
    {
        public string Message { get; set; }

        public int Number { get; set; }

        public void Deconstruct(out string message, out int number)
        {
            message = this.Message;
            number = this.Number;
        }

        public void Deconstruct(out string message, out int number, out int foo)
        {
            message = this.Message;
            number = this.Number;
            foo = 321;
        }
    }
}