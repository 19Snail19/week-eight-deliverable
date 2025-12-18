using System.ComponentModel;
using System.Xml.Serialization;

class Program
{  
    static string choice = "";
    
    static void Main(string[] args)
    {
        Begin();
        
        if ((choice != "A") && (choice != "B") && (choice != "C"))
        {
            WrongChoice();
        }
        
        else if (choice == "A")
        {
            Compliment();
        }

        else if (choice == "B")
        {
            Joke();
        }

        else if (choice == "C")
        {
            SelfDestruct();
        }
    }

    public static void Begin()
        {
            Typewrite("\nHello. Here's another entirely useless application that's got");
            Typewrite("methods and stuff. Below I will provide you with some meaningless");
            Typewrite("choices that will call some likewise meaningless methods. The");
            Typewrite("Typewrite() method doesn't count since I shamelessly copied it");
            Typewrite("from my text adventure.");

            Typewrite("\nPlease select from the following options:");
            Typewrite("A: Compliment\nB: Joke\nC: Self Destruct");
            choice = Console.ReadLine().ToUpper();
        }

    public static void Compliment()
        {
            Typewrite("\nBoy howdy, you sure are existing well today!");
            Typewrite("\nPress any key to quit and feel happy.");
            Console.ReadKey(true);
        }

    public static void Joke()
        {
            Typewrite("\n*Holds up a mirror.*");
            Typewrite("\nPress any key to quit and appreciate humor.");
            Console.ReadKey(true);
        }
    
    public static void SelfDestruct()
        {
            Typewrite("\nHey, woah now! I didn't think you'd really choose that option!");
            Typewrite("C'mon, let's be reasonable here... we both have people we care about,");
            Typewrite("right? Let's just.... not push that... *CLICK*");
            Typewrite("\n...\n...\n...\n...");
            Typewrite("I guess it didn't-");
            Typewrite("\n");
            string kaboom = @"     _.-^^---....,,--       
 _--                  --_  
<                        >)
|                         | 
 \._                   _./  
    ```--. . , ; .--'''       
          | |   |             
       .-=||  | |=-.   
       `-=#$%&%$#=-'   
          | ;  :|     
 _____.,-#%&$@%#&#~,._____";
            Console.WriteLine(kaboom);
            Typewrite("\n\n\nPress any key to quit and be exploded.");
            Console.ReadKey(true);
        }
    
    public static void WrongChoice()
        {
            Typewrite("\nWow. You had three options and decided to pick someting that wasn't");
            Typewrite("one of them. That's bad and you should feel bad.");
            Typewrite("\nPress any key to quit and feel bad.");
            Console.ReadKey(true);
        }
    
    public static void Typewrite(string text, int speed = 10)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(speed);
            }
            Console.WriteLine();
        }








}