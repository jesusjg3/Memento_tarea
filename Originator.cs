// Clase Originator: el objeto que tiene un estado y puede guardar y restaurar ese estado a través de la clase Memento
class Originator
{
    private string state;

    public string GetState()
    {
        return state;
    }

    public void SetState(string state)
    {
        this.state = state;
    }

    // Guarda el estado actual en un objeto Memento y lo devuelve
    public Memento SaveStateToMemento()
    {
        return new Memento(state);
    }

    // Restaura el estado del objeto desde un objeto Memento
    public void GetStateFromMemento(Memento memento)
    {
        state = memento.GetState();
    }
}