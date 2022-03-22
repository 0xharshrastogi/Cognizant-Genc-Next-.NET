namespace FacadePattern
{
    public class Demo
    {
        public static void Main(string[] args)
        {
            var shapemaker = new ShapeMaker();

            shapemaker.DrawCircle();
            shapemaker.DrawRectangle();
            shapemaker.DrawSquare();
        }
    }
}