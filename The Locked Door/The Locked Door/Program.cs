

public class Door
{
    private int _startingCode;
    public DoorState State { get; private set; }
    
    public Door(int startingCode)
    {
        _startingCode = startingCode;
        State = DoorState.Closed;
    }
    
    public void Lock()
    {
        if (State == DoorState.Closed)
            State = DoorState.Locked;
    }

    public void Open()
    {
        if (State == DoorState.Closed)
            State = DoorState.Open;
    }

    public void Close()
    {
        if (State == DoorState.Open)
            State = DoorState.Closed;
    }

    public void Unlock(int passcode)
    {
        if (State == DoorState.Locked && _startingCode == passcode)
            State = DoorState.Closed;
    }
}

public enum DoorState { Open, Closed, Locked }