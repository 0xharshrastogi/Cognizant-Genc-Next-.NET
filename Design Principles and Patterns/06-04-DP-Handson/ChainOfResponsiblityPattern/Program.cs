namespace ChainOfResponisiblityPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var leaveReq1 = new LeaveRequest("AP Dhillon", 2);
            var leaveReq2 = new LeaveRequest("Arijit Singh", 4);
            var leaveReq3 = new LeaveRequest("Supriya", 11);



            var hr = new HR(null);
            var manager = new ProjectManager(hr);
            var supervisor = new Supervisior(manager);

            supervisor.HandleRequest(leaveReq1);
            supervisor.HandleRequest(leaveReq2);
            supervisor.HandleRequest(leaveReq3);

        }
    }
}