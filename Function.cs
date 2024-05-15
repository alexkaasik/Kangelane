using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Kangelane
{
    public class Function
    {
        public static void print(Kangelane[] KangelaneK, SuperKangelane[] SuperKangelaneS) {
            Console.WriteLine("State:");
            for (int i = 0; i < KangelaneK.Length && KangelaneK[i] != null; i++){
                Console.WriteLine(KangelaneK[i].ToString());
            }
            Console.WriteLine();
            for (int i = 0; i < SuperKangelaneS.Length && SuperKangelaneS[i] != null; i++){
                Console.WriteLine(SuperKangelaneS[i].ToString());
            }
            Console.WriteLine();

            Console.WriteLine("Save:");
            for (int i = 0; i < KangelaneK.Length && KangelaneK[i] != null; i++){
                Console.WriteLine(KangelaneK[i].Save(123));
            }

            for (int i = 0; i < SuperKangelaneS.Length && SuperKangelaneS[i] != null; i++){
                Console.WriteLine(SuperKangelaneS[i].Save(123));
            }
            Console.WriteLine();
        }

        // Static method to read hero data from file
        public static void StatesFile(string HeroFile, Kangelane[] KangelaneK, SuperKangelane[] SuperKangelaneS)
        {
            string[] readText = File.ReadAllText(HeroFile).Split("\n");  // Read the contents of the file
            int i = 0;
            foreach (string line in readText){

                string name = line.Split(",")[0].Trim();
                string location = line.Split(",")[1].Trim();
            
                //Nimi = name;
                //Asukoht = location;
                //if (name.Contains("*")){}
                Console.WriteLine(KangelaneK[0].Nimi);
                Console.WriteLine(SuperKangelaneS[0].Nimi);
                
                if (name.Contains("*")){
                    double spe = Convert.ToDouble(line.Split(",")[2].Trim());
                    //Console.Write(name.Replace("*","") + ":" + location + ":" + spe);
                    SuperKangelaneS[3+i].Nimi = name;
                    SuperKangelaneS[3+i].Asukoht = location;
                    SuperKangelaneS[3+i].Osavuse = spe;
                }
                /**/
                else{
                    //Console.Write(name.Replace("*","") + ":" + location);
                    KangelaneK[3+i].Nimi = name;
                    KangelaneK[3+i].Asukoht = location;
                }
                Console.WriteLine();
                Function.print(KangelaneK, SuperKangelaneS);
            }
        }
    }
}