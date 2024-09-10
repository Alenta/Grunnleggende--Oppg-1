using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Oppgaver;

/*
namespace Oppgaver
{
    
}

using Oppgaver;

*/

class Oppg1
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
        string[] arg = ["Ole", "Petter", "Carl"];
        StringDoer(arg);

        void StringDoer(string[] arg)
        {   //Foreach loop through array
            Console.WriteLine("Testing stringdoer: ");
            foreach (var str in arg)
            {   //Append message to name and write to console
                Console.WriteLine("Hello, " + str + "!");
            }
        }
        MyMath.AddNumbers(20,10);
        int[] array = [1,1,1,1,1,1,1,3];
        MyMath.AddArray(array);

        Dictionary<string, int> nameDictionary = [];
        nameDictionary.Add("Lars",25);
        nameDictionary.Add("Ole",15);
        nameDictionary.Add("Lasse",62);

        foreach (var item in nameDictionary)
        {
            Console.WriteLine("Key: " + item.Key + ", Value: "+ item.Value);
        }
    } 
}

class MyMath()
{
    public static int AddNumbers(int a, int b){
        Console.WriteLine("Added Numbers outside of scope: " + a + " + " + b + " = " + (a+b));
        return a+b;
    }
    public static int AddArray(int[] array){
        int sum = 0;
        foreach (var value in array)
        {
            sum += value;
        }
        Console.WriteLine("Summed array: "+sum);
        return sum;

    }
}


