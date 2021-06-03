/* How would you change the following code to use an anonymous variable and What would be the expected output here */

using System;

class MainClass 
{
    public static void Main (string[] args) 
    {
        dynamic x = 1;

        Console.WriteLine("Value: {" + x + "}, Type: {" + x.GetType() + "}");

        x = "Hello World!";

        Console.WriteLine("Value: {" + x + "}, Type: {" + x.GetType() + "}");
    }
}



/*
    ANSWER:
    change dynamic to var
    Type error, cannot implicitly convert type string to type int
*/