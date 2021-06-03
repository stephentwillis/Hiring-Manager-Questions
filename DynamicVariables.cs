/* What would be the expected output here */

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

    Value: {1}, Type: {System.Int32}
    Value: {Hello World!}, Type: {System.String}
*/