using System;

//  untuk state
public interface State
{
    void Open();
    void Lock();
}

//  state terkunci
public class LockedState : State
{
    public void Open()
    {
        Console.WriteLine("Pintu terkunci. Tidak bisa dibuka.");
    }

    public void Lock()
    {
        Console.WriteLine("Pintu sudah terkunci.");
    }
}

//  state terbuka
public class UnlockedState : State
{
    public void Open()
    {
        Console.WriteLine("Pintu sudah terbuka.");
    }

    public void Lock()
    {
        Console.WriteLine("Pintu dikunci.");
    }
}

public class DoorMachine
{
    private State currentState;

    public DoorMachine()
    {
        currentState = new LockedState();
    }

    public void ChangeState(State newState)
    {
        currentState = newState;
    }

    public void Open()
    {
        currentState.Open();
    }

    public void Lock()
    {
        currentState.Lock();
    }
}

class Program
{
    static void Main(string[] args)
    {
        DoorMachine doorMachine = new DoorMachine();
        doorMachine.Open();
        doorMachine.ChangeState(new UnlockedState());
        doorMachine.Open();
        doorMachine.Lock();
        doorMachine.Open(); 
    }
}