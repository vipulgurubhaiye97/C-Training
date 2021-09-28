using System;

//Publisher
public class SmartDoor
{

    public void Open()
    {
        OnActionChanged("Open");
    }
    public void Close()
    {
        OnActionChanged("Close");
    }

    //Events (Distributor Object)
    public event Action<string> OnAction = null;

    private void OnActionChanged(string status)
    {

        if (OnAction != null)
        {
            //Publisher Notifying the Distributor
            OnAction.Invoke(status);
        }
    }

}

//Subscriber
public class EuroVigilanceSystem
{

    //Publisher Ref
    SmartDoor _smartDoor;

    public EuroVigilanceSystem(SmartDoor _doorRef)
    {
        _smartDoor = _doorRef;
        //Distributor Object
        Action<string> _eventHadnlerAddress = new Action<string>(Notify);
        //Set Distributor Object @Publisher
        _smartDoor.OnAction += _eventHadnlerAddress;
    }
    //Event Handler 
    public void Notify(string doorStatus)
    {

        Console.WriteLine("Door Status :{0}", doorStatus);
    }

}

public class Program
{

    public static void Main()
    {

        SmartDoor _publisher = new SmartDoor();
        EuroVigilanceSystem _subscriber = new EuroVigilanceSystem(_publisher);
        _publisher.Open();
        _publisher.Close();

    }

}