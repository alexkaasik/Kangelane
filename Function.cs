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
            int i1 = 0;
            int i2 = 0;
            string name;
            string location;
            double spe;
            //Console.WriteLine(KangelaneK.Length);

            int b1 = KangelaneK.Count(x => x != null);
            int b2 = SuperKangelaneS.Count(x => x != null);

            foreach (string line in readText){

                Console.WriteLine(line);

                name = line.Split(",")[0].Trim();
                location = line.Split(",")[1].Trim();
                
                //Nimi = name;
                //Asukoht = location;
                //if (name.Contains("*")){}
            

                if (name.Contains("*")){
                    Console.WriteLine(line.Split(",")[2].Trim());
                    Console.WriteLine(line.Split(",")[2].Trim());
                    Console.WriteLine(line.Split(",")[2].Trim().Replace(".", ","));
                    spe = System.Convert.ToDouble( line.Split(",")[2].Trim().Replace(".",","));
                    Console.WriteLine(spe);
                    //Console.WriteLine(name.Replace("*","") + ":" + location + ":" + spe);
                    Console.WriteLine(spe.GetType());
                    SuperKangelaneS[b2+i1] = new SuperKangelane(name.Replace("*",""), location, spe);
                    i1++;
                }
                /**/
                else{
                    //Console.Write(name + ":" + location);
                    KangelaneK[b1+i2] = new Kangelane(name, location);
                    i2++;

                }
                Console.WriteLine();
                Function.print(KangelaneK, SuperKangelaneS);
                
            }
        }
        public static void edit(Kangelane[] KangelaneK, SuperKangelane[] SuperKangelaneS) {
            string who;
            Console.WriteLine("Sup = superhero");
            Console.WriteLine("* 'anything else' = hero");
            do {
                Console.Write("Who:");
                who = Console.ReadLine();
            } while (who.Length == 0);

            if (who == "sup"){
                for (int i = 0; i < SuperKangelaneS.Length && SuperKangelaneS[i] != null; i++){
                    Console.WriteLine( i+1 + " " + SuperKangelaneS[i].ToString());
                }
            }
            else {
                for (int i = 0; i < KangelaneK.Length && KangelaneK[i] != null; i++){
                    Console.WriteLine( i+1 + " " + KangelaneK[i].ToString());
                }
            }
            int liner;
            while (true) {
                try{
                    Console.Write("pick line:");
                    string line = Console.ReadLine();
                    liner=int.Parse(line)-1;
                    break;
                }
                catch {continue;}
            }

            Console.WriteLine("Name = Change Name");
            Console.WriteLine("loca = Change location");
            Console.WriteLine("poin = Change Osavuse");
            Console.Write("mode:");
            string mode = Console.ReadLine();
            string val;
            switch (mode)
            {
                case "name":
                    Console.Write("Edit name:");
                    val = Console.ReadLine();
                    if (who == "sup") {
                        SuperKangelaneS[liner].Nimi = val;
                    }
                    else {
                        KangelaneK[liner].Nimi = val;
                    }
                    break;
                case "loca":
                    Console.Write("Edit loca:");
                    val = Console.ReadLine();
                    if (who == "sup") {
                        SuperKangelaneS[liner].Asukoht = val;
                    }
                    else {
                        KangelaneK[liner].Asukoht = val;
                    }
                    break;
                case "poin":
                    if (who == "sup"){
                        while (true) {
                            try{
                                Console.Write("Edit poin:");
                                val = Console.ReadLine();
                                double val2 = Convert.ToDouble(val.Replace(".", ","));

                                SuperKangelaneS[2].Osavuse = val2;

                                break;
                            }
                            catch {continue;}}
                    }

                    break;
            }
        }
    }
}