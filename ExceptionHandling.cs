using System;

// Q: What will be the output here, will the Stacktrace show the error in Method1()?
class MainClass 
{
    public static void Main (string[] args) 
    {
        try 
        {
            Method2();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.StackTrace);
        }
    }

    public static void Method2()
    {
        try
        {
            Method1();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static void Method1()
    {
        try 
        {
            throw new Exception("Message");
        }
        catch
        {
            throw;
        }
    }
}


// ANSWER: No, method1() will fail silently and the stacktrace will show the error as occuring in Method2()
// Something like this is more appropriate

class MainClass 
{
    public static void Main (string[] args) 
    {
        try 
        {
            Method2();
        }
        catch (Exception ex)
        {
            // write the stacktrace
            Console.WriteLine(ex.StackTrace);
        }
    }

    public static void Method2()
    {
        try
        {
            Method1();
        }
        catch (Exception ex)
        {
            // allow error to bubble up
            throw;
        }
    }

    public static void Method1()
    {
        try 
        {
            throw new Exception();
        }
        catch
        {
            // throw a full error here
            throw new Exception("Message");
        }
    }
}