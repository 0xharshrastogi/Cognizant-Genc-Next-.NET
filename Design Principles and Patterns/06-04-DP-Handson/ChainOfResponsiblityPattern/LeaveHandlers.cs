namespace ChainOfResponisiblityPattern
{
    public interface ILeaveRequestHandler
    {
        ILeaveRequestHandler nextHandler { get; set; }
        void HandleRequest(LeaveRequest leave);
    }

    public class HR : ILeaveRequestHandler
    {
        public ILeaveRequestHandler? nextHandler { get; set; }

        public HR(ILeaveRequestHandler? nextHandler)
        {
            this.nextHandler = nextHandler;
        }

        public void HandleRequest(LeaveRequest request)
        {
            if (request.LeaveDays > 5)
                Console.WriteLine("Leave request:- Employee: {0}, Leave days: {1} - approved by HR", request.Employee, request.LeaveDays);
            else
                nextHandler?.HandleRequest(request);
        }

    }

    public class Supervisior : ILeaveRequestHandler
    {
        public ILeaveRequestHandler nextHandler { get; set; }

        public Supervisior(ILeaveRequestHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }

        public void HandleRequest(LeaveRequest request)
        {
            if (request.LeaveDays >= 1 && request.LeaveDays <= 3)
                Console.WriteLine("Leave request:- Employee: {0}, Leave days: {1} - approved by Supervisior", request.Employee, request.LeaveDays);
            else
                nextHandler.HandleRequest(request);
        }
    }

    public class ProjectManager : ILeaveRequestHandler
    {
        public ILeaveRequestHandler nextHandler { get; set; }

        public ProjectManager(ILeaveRequestHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }

        public void HandleRequest(LeaveRequest request)
        {
            if (request.LeaveDays > 3 && request.LeaveDays <= 5)
                Console.WriteLine("Leave request:- Employee: {0}, Leave days: {1} - approved by Project Manager", request.Employee, request.LeaveDays);
            else
                nextHandler.HandleRequest(request);
        }
    }
}

