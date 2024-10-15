public abstract class Monster
{
    private readonly List<IObserver> observers = new List<IObserver>();

    // Tornamos Name 'protected set' para que as subclasses possam definir o nome no construtor
    public string Name { get; protected set; }
    public int Health { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }

    // Construtor base que obriga a definição de 'Name'
    protected Monster(string name)
    {
        Name = name;
    }

    // Método abstrato para movimentos especiais, será implementado pelas subclasses
    public abstract void SpecialMove();

    // Métodos para o padrão Observer
    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    // Notifica os observadores sobre mudanças
    protected void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(this);
        }
    }

    // Método que aplica dano ao monstro e notifica os observadores
    public void TakeDamage(int damage)
    {
        Health -= damage;
        NotifyObservers();  // Notifica que a saúde mudou
    }

    // Métodos para o padrão Memento, para salvar e restaurar o estado
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
