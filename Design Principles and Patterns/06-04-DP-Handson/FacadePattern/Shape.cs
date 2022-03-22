namespace FacadePattern
{
    public interface IShape
    {
        public void Draw();
    }

    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }

    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }

    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Square");
        }
    }
}