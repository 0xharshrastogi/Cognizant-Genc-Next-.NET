namespace ObserverPattern
{
    public abstract class Subject
    {
        protected string state = "Active";
        public abstract void Attach(IObserver o);
        public abstract void Detach(IObserver o);
        public abstract void Notify(Message m);
    }
}