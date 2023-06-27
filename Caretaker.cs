// Clase Caretaker: responsable de guardar y administrar el objeto Memento
class Caretaker
{
    private Memento memento;

    public Memento GetMemento()
    {
        return memento;
    }

    public void SetMemento(Memento memento)
    {
        this.memento = memento;
    }
}