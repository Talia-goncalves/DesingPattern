public abstract class Monster
{
    private readonly List<IObserver> observers = new List<IObserver>();
    public required string Name { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }

    public abstract void SpecialMove();

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    protected void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(this);
        }
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        NotifyObservers();  // Notifica que a saúde mudou
    }

    public Memento SaveState()
    {
        return new Memento(Health, Attack, Defense);
    }

    public void RestoreState(Memento memento)
    {
        Health = memento.Health;
        Attack = memento.Attack;
        Defense = memento.Defense;
    }
}
