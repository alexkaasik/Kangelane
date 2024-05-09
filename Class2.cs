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
}

