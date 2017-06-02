namespace CSharp7Demo
{
    using System;

    public class SomeRequest
    {
        public int CaseID { get; set; }

        public int CustomerID { get; set; }

        public string SomeOtherParameter { get; set; }
    }

    public class LocalFunctions
    {
        public void Handle(int caseID, int customerID, string someOtherParameter)
        {
            string ConstructSomething(string key)
            {
                return $"{key}-{caseID}-{customerID}-{someOtherParameter}";
            }

            var something1 = ConstructSomething("Key 1");
            var something2 = ConstructSomething("Key 2");
        }
    }
}