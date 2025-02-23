//-------------------------------------------------
// StringProperties.cs (c) 2006 by Charles Petzold
//-------------------------------------------------
using System;

class StringProperties
{
    static string _str;

    static void Main()
    {
        if(_str is not null)
            Console.WriteLine(_str.GetType());


        Console.Write("Enter some text: ");
        string strEntered = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("The text you entered has " + strEntered.Length + 
                          " characters");
        Console.WriteLine("The first character is " + strEntered[0]);
        Console.WriteLine("The last character is " + 
                                    strEntered[strEntered.Length - 1]);
        Console.WriteLine();
    }
}
