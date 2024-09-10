using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

//Namespace for the project. What is namespace "Name"; compared to namespace "Name" { Class }?
namespace Oppgaver;

class Oppg1
{
    static void Main()
    {
        Console.WriteLine("===================OPPGAVE 1=======================");
        Console.WriteLine("Program compiles and runs");
        // Oppgave 2
        Console.WriteLine("===================OPPGAVE 2=======================");
        //Setting uo & Writing variables
        int helTall = 1;
        Console.WriteLine(helTall);
        string nyString = "Heeeeeey";
        Console.WriteLine(nyString);
        double nyDouble = 1.5;
        Console.WriteLine(nyDouble);
        char nyChar = 'A';
        Console.WriteLine(nyChar);
        //Set up int array
        int[] tallArray = [1,2,3];
        //set up string array
        string[] strArray = ["No. ", "Yes.", "Maaaaaybe?"];
        //Set up new empty List
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

        //Foreach loop through array, Log results. Could also be done when adding to list to save a foreach loop.
        foreach (var str in strList)
        {
            Console.WriteLine(str);
        }

        // Oppgave 3
        Console.WriteLine("===================OPPGAVE 3=======================");
        //Set up new Dictionary Int & String
        Dictionary<int, string> myDictionary = new()
        {
            { 1, "OK" },
            { 2, "GOOD" }
        };

        //Foreach loop through dictionary, logging results
        foreach (var item in myDictionary)
        {
            Console.WriteLine(item);
        }

        //Testing the IntMaker(Local scope) function with random number
        Random rnd = new();
        IntMaker(rnd.Next(0,100),rnd.Next(0,100));
        int IntMaker(int value1, int value2)
        {
            int newValue = value1 + value2;
            Console.WriteLine("Intmaker: " + value1 + " + " + value2 + " = " + newValue);
            //Return is kind of useless here, but we could have Console.WriteLined the returned value to... Pretend it does something.
            return newValue;
        }
        
        //Set up new string array and test the StringDoer
        string[] arg = ["Ole", "Petter", "Carl"];
        StringDoer(arg);

        void StringDoer(string[] arg)
        {   
            Console.WriteLine("Testing stringdoer: ");
            //Foreach loop through array
            foreach (var str in arg)
            {   //Append message to name and write to console
                Console.WriteLine("Hello, " + str + "!");
            }
        }
        
        //Ekstraoppgave
        Console.WriteLine("=================EKSTRA OPPGAVE====================");

        Dictionary<string, int> nameDictionary = [];
        
        nameDictionary.Add("Lars",25);
        nameDictionary.Add("Ole",15);
        nameDictionary.Add("Lasse",62);

        foreach (var item in nameDictionary)
        {
            Console.WriteLine("Key: " + item.Key + ", Value: "+ item.Value);
        }

        MyMath.AddNumbers(20,10);
        int[] array = [1,1,1,1,1,1,1,3];
        MyMath.AddArray(array);
    } 
}


//Class outside of main scope. Could be moved to a separate .cs project in the same namespace, or another connected namespace
class MyMath()
{
    //Public int functions in the MyMath class, static so they are accessible outside of scope.
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
        //We could use a for loop (Or add an index/counter to the foreach loop) 
        //if we wanted to print out the stages and not only the result
        Console.WriteLine("Summed array: "+sum);
        //We return sum because this is an int function. We could change it to void if we dont need to return a value.
        return sum;

    }
}


