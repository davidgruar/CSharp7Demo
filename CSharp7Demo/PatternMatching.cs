namespace CSharp7Demo
{
    public abstract class CheckItem
    {
        public int ID { get; set; }
    }

    public class BasicCrcCheck : CheckItem
    {
        public string SubmissionNumber { get; set; }
    }

    public class EmploymentReference : CheckItem
    {
        public string RefereeName { get; set; }

        public string RefereeOrganisation { get; set; }
    }

    public class PatternMatching
    {
        public string HandleCheckItem(CheckItem checkItem)
        {
            switch (checkItem)
            {
                case BasicCrcCheck basicCrcCheck when basicCrcCheck.SubmissionNumber == null:
                    return "Basic CRC check with no submission number";
                case BasicCrcCheck basicCrcCheck:
                    return $"Basic CRC Check, submission number {basicCrcCheck.SubmissionNumber}";
                case EmploymentReference employmentRef:
                    return $"Employment reference from {employmentRef.RefereeName} at {employmentRef.RefereeOrganisation}";
                case null:
                    return "Check item is null";
                default:
                    return "Unknown check type";

            }
        }
    }
}