namespace ObserverPattern
{
    public class MessagePublisher : Subject
    {
        public List<IObserver> observers = new List<IObserver>();

        public override void Attach(IObserver o)
        {
            this.observers.Add(o);
        }

        public override void Detach(IObserver o)
        {
            this.observers.Remove(o);
        }

        public override void Notify(Message m)
        {
            observers.ForEach((o) => o.Update(m));
        }

        public void UpdateState(string state)
        {
            this.state = state;
            this.Notify(new Message($"State:{state}"));
        }
    }
}