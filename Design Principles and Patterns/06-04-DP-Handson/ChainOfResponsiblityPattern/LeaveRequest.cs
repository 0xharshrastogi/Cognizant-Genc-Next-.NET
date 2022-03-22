namespace ChainOfResponisiblityPattern
{
    public class LeaveRequest
    {
        public string Employee { get; set; }
        public int LeaveDays { get; set; }

        public LeaveRequest(string employee, int leaveDays)
        {
            Employee = employee;
            LeaveDays = leaveDays;
        }

    }


}