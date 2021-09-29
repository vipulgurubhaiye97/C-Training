using System;

public interface ILogger
{

    //Template Methods (abstract and Public )
    void WriteLogContent(string content);
}
//ConsoleLogger  implements Contract(interface)
public class ConsoleLogger : ILogger
{
    public void WriteLogContent(string content)
    {
        Console.WriteLine(content);
    }
}
//FileLogger  implements Contract(interface)
public class FileLogger : ILogger
{

    public void WriteLogContent(string content) { Console.WriteLine("FileLogger " + content); }
}


public class NetWorkConnection
{

    //Depends on ILogger(Abstraction)
    ILogger _logger;

    //Dependency Injection
    public NetWorkConnection(ILogger logger)
    {
        this._logger = logger;
    }
    public void Open()
    {

        _logger.WriteLogContent(string.Format("NetworkConnection Opened at:{0}", System.DateTime.Now));
    }

    public void Connect()
    {
        _logger.WriteLogContent(string.Format("NetworkConnection Connected at:{0}", System.DateTime.Now));
    }

    public void DisConnnect()
    {

        _logger.WriteLogContent(string.Format("NetworkConnection Disconnected at:{0}", System.DateTime.Now));
    }
    public void Close()
    {

        _logger.WriteLogContent(string.Format("NetworkConnection Closed at:{0}", System.DateTime.Now));
    }

}
public class Program

{
    public static void main()
    {
        ILogger _logger = new ConsoleLogger();
        NetWorkConnection _connection = new NetWorkConnection(_logger);
        _connection.Connect();
        System.Threading.Tasks.Task.Delay(3000).Wait();
        _connection.Open();
        System.Threading.Tasks.Task.Delay(3000).Wait();

        _connection.Close();
        _connection.Open();
        System.Threading.Tasks.Task.Delay(3000).Wait();
        _connection.DisConnnect();


    }
}