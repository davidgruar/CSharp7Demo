namespace CSharp7Demo
{
    using System;

    public class ExpressionBodiedMembers
    {
        private string myField;

        public ExpressionBodiedMembers(string myField) => this.myField = myField ?? throw new ArgumentNullException(nameof(myField));

        public string MyProperty
        {
            get => this.myField?.ToUpper();
            set => this.myField = value;
        }
    }
}