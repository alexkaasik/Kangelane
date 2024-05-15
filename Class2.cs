using System;
using System.Runtime.CompilerServices;

namespace Kangelane
{
    public class Kangelane
    {   
        private string nimi;
        private string asukoht;

        public Kangelane(string nimi, string asukoht) { 
            this.nimi = nimi;
            this.asukoht = asukoht;
        }
        
        public string Nimi { 
            get { return nimi; }
            set { nimi = value; }
        }
        public string Asukoht { 
            get { return asukoht; }
            set { asukoht = value; }
        }
        
        public override string ToString()
        {
            return $"Hero: {nimi}, Location: {asukoht}";
        }

        public int Save(int paastetudInimesteArvu)
        {
            double savedPercentage = 0.95;
            int InimesteArvu = (int)Math.Round(paastetudInimesteArvu * savedPercentage);
            return InimesteArvu;
        }
    }

    public class SuperKangelane : Kangelane
    {
        private string nimi;
        private string asukoht;
        private double osavuse;


        public SuperKangelane(string nimi, string asukoht, double osavuse) : base(nimi, asukoht)
        {

        }

        public double Osavuse
        {
            get { return osavuse; }
            set {
                double test = value;
                if (!(value >= 1.0 && value <= 5.0))
                {
                    //throw new ArgumentException("Skill must be in the range [1, 5].");
                    Console.WriteLine("Skill must be in the range [1, 5].");
                    test = 0;
                }
                osavuse = test;
            }
        }
        public int Save(int paastetudInimesteArvu)
        {
            //double savedPercentage = 0.95;
            //int InimesteArvu = (int)Math.Round(paastetudInimesteArvu * (savedPercentage + (osavuse/100) ));
            int InimesteArvu = (int)Math.Round( base.Save(paastetudInimesteArvu) * ( 1.0 + ( osavuse/100.0 )  ) );
            return InimesteArvu;
        }
        public override string ToString()
        {
            return base.ToString()+$" Skill: {osavuse}";
        }
        /*
        public override void StatesFile(string HeroFile)
        {
            string[] readText = File.ReadAllText(HeroFile).Split("\n");  // Read the contents of the file
            Console.WriteLine(readText);
            foreach (string line in readText){

                string name = line.Split(",")[0].Trim();
                string location = line.Split(",")[1].Trim();
                
                Nimi = name;
                Asukoht = location;

                if (name.Contains("*")){
                    string Spe = line.Split(",")[2].Trim();
                    Osavuse = Spe;
                }
            }
        }
        */
    }
}