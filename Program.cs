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
            Kangelane Kangelane3 = new  Kangelane("Spiderman ","Los Angeles");

            SuperKangelane Kangelane4 = new SuperKangelane("Superman", "London", 1.3);
            SuperKangelane Kangelane5 = new SuperKangelane("Batman ", "Tokyo", 3.3);
            SuperKangelane Kangelane6 = new SuperKangelane("Spiderman ", "Los Angeles", 4.3);

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

            Console.WriteLine(Kangelane1.Asukoht);
            Console.WriteLine(Kangelane2.Nimi);
            Console.WriteLine(Kangelane3.Asukoht);

            Kangelane4.Osavuse = 2.1;
            Kangelane5.Osavuse = 4.4;
            Kangelane6.Osavuse = 2.5 ;

            Console.WriteLine(Kangelane4.Osavuse);
            Console.WriteLine(Kangelane5.Osavuse);
            Console.WriteLine(Kangelane6.Osavuse);

            Console.WriteLine(Kangelane4.Save(123));
            Console.WriteLine(Kangelane5.Save(12));
            Console.WriteLine(Kangelane6.Save(13));

            Console.WriteLine(Kangelane4.ToString());
            Console.WriteLine(Kangelane5.ToString());
            Console.WriteLine(Kangelane6.ToString());
        }
    }
}