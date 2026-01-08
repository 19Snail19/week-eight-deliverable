using System.ComponentModel;
using System.Xml.Serialization;

class Program
{  
    public static string choice = "";
    
    static void Main(string[] args)
    {
        Selectables.Begin();
        
        if ((choice != "A") && (choice != "B") && (choice != "C"))
        {
            Selectables.WrongChoice();
        }
        
        else if (choice == "A")
        {
            Selectables.Compliment();
        }

        else if (choice == "B")
        {
            Selectables.Joke();
        }

        else if (choice == "C")
        {
            Selectables.SelfDestruct();
        }
    }
}