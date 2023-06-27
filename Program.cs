// Clase Program (cliente)
class Program
{
    static void Main(string[] args)
    {
        Originator originator = new Originator();
        Caretaker caretaker = new Caretaker();

        // Establecer y mostrar el estado inicial
        originator.SetState("Estado 1");
        Console.WriteLine("Estado actual: " + originator.GetState());

        // Guardar el estado en el caretaker
        caretaker.SetMemento(originator.SaveStateToMemento());

        // Cambiar el estado y mostrarlo
        originator.SetState("Estado 2");
        Console.WriteLine("Estado actual: " + originator.GetState());
        caretaker.SetMemento(originator.SaveStateToMemento());

        // Cambiar el estado y mostrarlo
        originator.SetState("Estado 3");
        Console.WriteLine("Estado actual: " + originator.GetState());
        
        // Simulamos que el estado 3 esta corruppto o Eliminado
        Console.WriteLine("Estado 3 corrupto o Eliminado");

        // Restaurar el estado anterior desde el caretaker
        originator.GetStateFromMemento(caretaker.GetMemento());
        Console.WriteLine("Estado restaurado: " + originator.GetState());
    }
}