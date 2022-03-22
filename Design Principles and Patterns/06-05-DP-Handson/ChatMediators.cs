namespace MediatorPattern
{
    class ChatMediators : IChatMediator
    {
        private List<IUser> users = new List<IUser>();

        public void AddUser(IUser user)
        {
            users.Add(user);
        }

        public void SendMessage(string from, string message)
        {
            foreach (var user in users)
                if (user.Name != from) user.RecieveMessage(from, message);
        }
    }
}

