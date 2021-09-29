using System;
public class Program1
{
    public static void main()
    {
        Foo();
        Console.WriteLine("Main nth Statement");
    }
    static void Foo()
    {
        Bar();
        Console.WriteLine("Foo nth Statement");
    }

    static void Bar()
    {

        try
        {
            Compute(10, 0);
        }
        catch (System.InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);

        }
        Console.WriteLine("Bar nth Statement");
    }

    static void ReadFile()
    {
        try
        {

            //open
            //read

        }
        catch (System.IO.FileNotFoundException ex)
        {

        }
        catch (System.IO.FileLoadException ex) { }
        finally
        {
            //Close File Hanlde
        }
    }
    static void Compute(int x, int y)
    {
        try
        {
            if (y == 0) { return; }
            int result = x / y;
            Console.WriteLine("Result {1}", result);
        }

        catch (System.DivideByZeroException ex)
        {
            //Handle
            Console.WriteLine("Divide By Zero Excpetion Handled:");
            System.InvalidOperationException _exObj = new System.InvalidOperationException("Compute Internal Error - Check Function Arguments");
            //throw mannually
            throw _exObj;
        }
        catch (System.FormatException ex)
        {
            Console.WriteLine("Format Excpetion Handled");
        }
        catch (System.Exception ex)
        {
            Console.WriteLine("All Excpetion Types are  Handled");
        }
        finally
        {
            //Clean Up Code
            Console.WriteLine("Compute After Catch Block");
        }

    }
}