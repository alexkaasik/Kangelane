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
            Kangelane Kangelane1 = new Kangelane("Superman","London");
            Kangelane Kangelane2 = new Kangelane("Batman ","Tokyo");
            Kangelane Kangelane3 = new Kangelane("Spiderman ","Los Angeles");

            Console.WriteLine(Kangelane1.ToString());
            Console.WriteLine(Kangelane2.ToString());
            Console.WriteLine(Kangelane3.ToString());
            
            Console.WriteLine(Kangelane1.Save(123));
            Console.WriteLine(Kangelane2.Save(12));
            Console.WriteLine(Kangelane3.Save(13));
            
            Kangelane1.Asukoht = "asdasd";
            Kangelane2.Nimi = "asafw";
            Kangelane3.Asukoht = "a222";

            Console.WriteLine(Kangelane1.ToString());
            Console.WriteLine(Kangelane2.ToString());
            Console.WriteLine(Kangelane3.ToString());
        }
    }
}