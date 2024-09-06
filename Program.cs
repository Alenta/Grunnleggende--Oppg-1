using System.Runtime.InteropServices;

namespace Oppgaver;

/*
namespace Oppgaver
{
    
}

using Oppgaver;

*/

class Program
{
    static void Main()
    {
        //Variables
        int helTall = 1;
        Console.WriteLine(helTall);
        string nyString = "Heeeeeey";
        Console.WriteLine(nyString);
        double nyDouble = 1.5;
        Console.WriteLine(nyDouble);
        char nyChar = 'A';
        Console.WriteLine(nyChar);
        int[] tallArray = [1,2,3];
        Console.WriteLine(tallArray.Count());
        Console.WriteLine(tallArray.Length);
        string[] strArray = ["No. ", "Yes.", "Maaaaaybe?"];

        //Set up new Dictionary
        Dictionary<int, string> myDictionary = new()
        {
            { 1, "OK" },
            { 2, "GOOD" }
        };

        //Set up new List
        List<String> strList = [];

        //For loop through array, Log results
        for (int i = 0; i < tallArray.Length; i++)
        {
            Console.WriteLine(tallArray[i]);
        }

        //Foreach loop through array, Log results
        foreach (var str in strArray)
        {
            Console.WriteLine(str);
        }

        //For loop running 5 times, adding values to the list.
        for (int i = 0; i < 5; i++)
        {
            strList.Add("Here is a value: " + (i+1));
        }

        //Foreach loop through array, Log results
        foreach (var str in strList)
        {
            Console.WriteLine(str);
        }

        //Foreach loop through dictionary, logging results
        foreach (var item in myDictionary)
        {
            Console.WriteLine(item);
        }
          
        //Testing the IntMaker function with random number
        Random rnd = new();
        IntMaker(rnd.Next(0,100),rnd.Next(0,100));
        int IntMaker(int value1, int value2)
        {
            int newValue = value1 + value2;
            Console.WriteLine("Intmaker: " + value1 + " + " + value2 + " = " + newValue);
            return newValue;
        }
        
        //Set up new string array and test the StringDoer
        string[] arg = ["Hey!", "Hello!", "Hi!", ":C"];
        StringDoer(arg);

        void StringDoer(string[] arg)
        {   //Foreach loop through array
            Console.WriteLine("Testing stringdoer: ");
            foreach (var str in arg)
            {   //If str matches accepted arguments write a reply
                if(str == "Hey!"){
                    Console.WriteLine("NO!");
                }
                else if(str == "Hello!"){
                    Console.WriteLine("GO AWAY!");
                }
                else if(str == "Hi!"){
                    Console.WriteLine("LEAVE ME ALONE!");
                } //Else do final action
                else {Console.WriteLine("...Fiiiiiine.");}
            }
        }
    } 
}
