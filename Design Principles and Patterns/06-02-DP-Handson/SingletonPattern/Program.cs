namespace SingletonPattern
{
    public class DBConn
    {
        private static DBConn _instance = new DBConn();
        public static DBConn Instance { get => _instance; }

        public DBConn GetInstance() => Instance;
        public DBConn() { }

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var instance1 = new DBConn();
            var instance2 = new DBConn();

            Console.WriteLine(instance1.GetInstance() == instance2.GetInstance()); // true, thus only one instance created;
            Console.WriteLine(instance1.GetInstance() == DBConn.Instance); // true, once initiated Comman DB Instances propogated;
            Console.WriteLine(instance2.GetInstance() == DBConn.Instance); // true

        }
    }
}