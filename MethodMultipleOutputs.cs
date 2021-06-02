using System;

// Q: Can you return multiple values from a method?
class MainClass 
{
    public static void Main (string[] args) 
    {
        int outputA;
        string outputB;

        DoSomething();
    }

    public static void DoSomething()
    {
        
    }
}


// ANSWER : YES!
class MainClass 
{
    public static void Main (string[] args) 
    {
        int outputA;
        string outputB;

        DoSomething(out outputA, out outputB);
    }

    public static void DoSomething(out int a, out string b)
    {
        
    }
}