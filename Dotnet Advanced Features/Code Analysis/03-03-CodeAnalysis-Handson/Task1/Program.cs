namespace Task1
{
    internal class Program
    {
        public string? Name { get; set; }

        public static void Main()
        {
            string[] names = new string[] { "James", "Bodgy", "Chirag", "Denis", "Alfee", "Bond" };
            IEnumerable<string> namesWithB = names.Where((name) => name.StartsWith('B'));
        }
    }
}