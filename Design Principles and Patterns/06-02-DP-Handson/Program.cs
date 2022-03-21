namespace HandsOn2
{
    public interface Moveable { double getSpeed(); double getPrice(); }
    public interface MoveableAdapter { double getSpeed(); double getPrice(); }
    public class FormulaCar : Moveable
    {
        public FormulaCar() { }

        public override double getSpeed() => 1;
    }

    public class MoveableAdapterImp : MoveableAdapter
    {
        private Moveable car;
        public MoveableAdapterImp(Moveable car) => this.car = car;

        public double Speed { get => convertMPHtoKMPH(car.getSpeed()); }
        public double Price { get => 0.91 * car.getPrice(); }
        public double convertMPHtoKMPH(double speed) => speed * 1.60934;
        public double getSpeed() => convertMPHtoKMPH(car.getSpeed());
    }
}