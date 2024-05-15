using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Kangelane
{
    public class Program
    {
        public static void Main()
        {
            //Console.WriteLine(Kangelane.saved());
            Kangelane[] KangelaneK = new Kangelane[64];
            KangelaneK[0] = new Kangelane("Superman","London");
            KangelaneK[1] = new Kangelane("Batman","Tokyo");
            KangelaneK[2] = new  Kangelane("Spiderman","Los Angeles");

            SuperKangelane[] SuperKangelaneS = new SuperKangelane[64];
            SuperKangelaneS[0] = new SuperKangelane("Superman", "London", 1.2);
            SuperKangelaneS[1] = new SuperKangelane("Batman", "Tokyo", 3.2);
            SuperKangelaneS[2] = new SuperKangelane("Spiderman", "Los Angeles", 4.2);
            
            bool loop = true;

            while (loop){
                Console.Write("Pick a mode:");
                string mode = Console.ReadLine();
                
                switch (mode.ToLower()) {
                    case "print":
                        Function.print(KangelaneK, SuperKangelaneS);
                        break;
                    case "edit":
                        Function.edit(KangelaneK, SuperKangelaneS);
                        break;
                    case "file":
                        Function.StatesFile("C:\\Users\\opilane\\Source\\Repos\\Aleksander_Kaasik\\C# test\\Kangelane\\Hero.txt", KangelaneK, SuperKangelaneS);   
                        break;
                    case "quit":
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
        }
    }
}