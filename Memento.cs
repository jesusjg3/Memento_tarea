// Clase Memento: representa el estado guardado de un objeto
class Memento
{
    private string state;

    public Memento(string state)
    {
        this.state = state;
    }

    public string GetState()
    {
        return state;
    }
}