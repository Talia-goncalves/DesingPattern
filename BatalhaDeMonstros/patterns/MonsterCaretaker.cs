using System;

public class MonsterCaretaker
{
    // Declara o memento como nullable para evitar o erro CS8618
    private Memento? memento;

    // Método para armazenar o memento
    public void SaveMemento(Memento memento)
    {
        this.memento = memento;
    }

    // Método para recuperar o memento
    public Memento? GetMemento()
    {
        return memento;
    }
}
