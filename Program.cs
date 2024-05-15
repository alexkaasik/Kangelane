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
            SuperKangelaneS[0] = new SuperKangelane("Superman", "London", 1.3);
            SuperKangelaneS[1] = new SuperKangelane("Batman", "Tokyo", 3.3);
            SuperKangelaneS[2] = new SuperKangelane("Spiderman", "Los Angeles", 4.3);

            Console.WriteLine();

            Function.print(KangelaneK, SuperKangelaneS);
            Function.StatesFile("Hero.txt", KangelaneK, SuperKangelaneS);   
            //Function.print(KangelaneK, SuperKangelaneS);
        }
    }
}