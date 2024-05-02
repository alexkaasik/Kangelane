using System;
using System.Runtime.CompilerServices;



namespace Kangelane
{
    public class Kangelane
    {
        /*
        string nimi;
        string asukoht;

        Kangelane(string nimi, string asukoht) { 
            Nimi = nimi;
            Asukoht=asukoht;
        }
        
        private string Nimi { get; set; }
        private string Asukoht { get; set; }
        */
        public static string saved(int number) {

            return (Math.Round(number * 0.95).ToString() + " olevate inimeste arvust");

        }
    }
    public class SuperKangelane : Kangelane
    {
        public SuperKangelane() { }
    }
}

