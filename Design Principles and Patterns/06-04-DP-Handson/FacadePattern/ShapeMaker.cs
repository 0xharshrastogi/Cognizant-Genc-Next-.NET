namespace FacadePattern
{
    public class ShapeMaker
    {
        private readonly Circle circle = new Circle();
        private readonly Square square = new Square();
        private readonly Rectangle rectangle = new Rectangle();

        public ShapeMaker() { }

        public void DrawCircle() => circle.Draw();

        public void DrawSquare() => square.Draw();

        public void DrawRectangle() => rectangle.Draw();
    }
}