namespace MediatorPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            var chatServer1 = new ChatMediators();

            var user1 = new BasicUser("Mia", chatServer1);
            var user2 = new BasicUser("Lana", chatServer1);
            var user3 = new PremiumUser("Sunny", chatServer1);

            user3.SendMessage("Hii @everyone");
            user1.SendMessage("Hello @Mia");
            user2.SendMessage("What u guys doing today");
        }
    }
}