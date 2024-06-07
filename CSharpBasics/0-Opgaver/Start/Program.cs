using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Net.NetworkInformation;

namespace Start
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hej og Velkommen til starter opgaverne!");

            // Dette er vores Main() metode, den starter med programmet.
            // Det er vigtigt at kalde alle metoder som også skal køres ved opstart!

            VariablerOgOperatører();
            Conditionals();
            Arrays();
            LoopsMedArraysOgAndreDatatyper();
        }

        static void header(string opgavenavn) {
            Console.WriteLine("------------------------");

            Console.WriteLine($"Her starter opgave: {opgavenavn}");
            Console.WriteLine("");
        }

        static void VariablerOgOperatører()
        {
            header("VariablerOgOperatører");

            Console.WriteLine("1.Udskriv længden af strengen “C# Bogen Opgaver”");

            string streng = "C# Bogen Opgaver";

            Console.WriteLine(streng.Length);

            Console.WriteLine("2. Lav et program som skriver et tilfældigt tal ud i konsollen");

            Random random = new Random();
            int randomNumber = random.Next();

            Console.WriteLine(randomNumber);

            Console.WriteLine("3. Skriv en variable ind i en streng ved brug af $-tegnet");
 
            string input = "Indsæt mig i en anden streng";

            Console.WriteLine($"Indsæt input herefter:{input}");
        }


        static void Conditionals()
        {
            header("Conditionals - If / Else statements");

            Console.WriteLine("1. I skal skrive et stykke kode som fortæller om et tal (int) er lige eller ulige");

            int tal = 3;

            if (tal % 2 == 0)
            {
                Console.WriteLine("Den er lige");
            }
            else
            {
                Console.WriteLine("Den er ulige");
            }



            Console.WriteLine("2. 1. I skal skrive et stykke kode som fortæller om 5 går op i det tal som i vælger (int). \n Hvis den går op i det skal i skrive: 5 går op i (det tal i har valgt)");

            int tal2 = 25;

            if (tal2 % 5 == 0)
            {
                Console.WriteLine($"5 går op i {tal2}");
            }
            else
            {
                Console.WriteLine($"5 går ikke op i {tal2}");
            }

            Console.WriteLine("3. Lav opgave 2 igen, men i stedet for selv at vælge et tal skal i lave sådan at den selv vælger et tal mellem 0 og 100.");

            Random random2 = new Random();
            int randomNumber2 = random2.Next(1, 100);

            if (randomNumber2 % 5 == 0)
            {
                Console.WriteLine($"5 går op i {randomNumber2}");
            }
            else
            {
                Console.WriteLine($"5 går ikke op i {randomNumber2}");
            }

            Console.WriteLine("4. Lav et program som fortæller jer hvilke af de her 3 tal der er størst.\r\n a = 25; b = 33; c = 12;");

            double a = 25;
            double b = 33;
            double c = 12;


            double maxfirst = Math.Max(a, b);
            double maxsecond = Math.Max(maxfirst, c);
            Console.WriteLine(maxsecond);


            Console.WriteLine("5. Lav et program der fortæller hvor varmt det er ud fra en temperatur. Kategorierne er som følger:\r\n- Hvis det er 0° eller under, skal der skrives: Det er frostvejr\r\n- Hvis det er mellem 1° og 10°, skal der skrives: Det er meget koldt\r\n- Hvis det er mellem 11° og 20°, skal der skrives: Det er koldt\r\n- Hvis det er mellem 21° og 30°, skal der skrives: Det er normalt vejr\r\n- Hvis det er mellem 31° og 40°, skal der skrives: Det er varmt\r\n- Hvis det er 41° eller over, skal der skrives: Det er meget varmt");

            int temp = 32;
            if (temp <= 0)
            {
                Console.WriteLine("Det er frostvejr");
            }
            if (Enumerable.Range(1, 10).Contains(temp))
            {
                Console.WriteLine("Det er meget koldt");
            }
            if (Enumerable.Range(11, 10).Contains(temp))
            {
                Console.WriteLine("Det er koldt");
            }
            if (Enumerable.Range(21, 10).Contains(temp))
            {
                Console.WriteLine("det er normalt");
            }
            if (Enumerable.Range(31, 10).Contains(temp))
            {
                Console.WriteLine("det er varmt");
            }
            if (temp >= 41)
            {
                Console.WriteLine("Det er meget varmt");
            }


            Console.WriteLine("6. Lav et program som omformer tal til ugedage ved brug af Conditionals, som eksempel nedenunder:\r\n    \r\n    Den 1. dag i ugen er mandag\r\n    \r\n    Den 2. dag i ugen er tirsdag \r\n    \r\n    Den 4. dag i ugen er Torsdag osv.");
            int dag = 5345347;

            if (dag % 7 == 1)
            {
                Console.WriteLine("Det er mandag");
            }
            else if (dag % 7 == 2) {
                Console.WriteLine("Det er tirsdag");
            }
            else if (dag % 7 == 3)
            {
                Console.WriteLine("Det er onsdag");
            }
            else if (dag % 7 == 4)
            {
                Console.WriteLine("Det er torsdag");
            }
            else if (dag % 7 == 5)
            {
                Console.WriteLine("Det er fredag");
            }
            else if (dag % 7 == 6)
            {
                Console.WriteLine("Det er lørdag");
            }
            else if (dag % 7 == 0)
            {
                Console.WriteLine("Det er søndag");
            }


        }
        static void Arrays()
        {
            header("Arrays");

            Console.WriteLine("1. Skriv “Viborg” i konsollen ved at trække den ud fra følgende array");

            List<string> byer1 = new List<string> { "Randers", "Viborg", "Aarhus", "København" };

            string by1 = byer1[1];

            Console.WriteLine(by1);

            Console.WriteLine("2. Tilføj “Skive” til denne array");

            List<string> byer2 = new List<string> { "Randers", "Viborg", "Aarhus", "København" };

            byer2.Add("Skive");

            Console.WriteLine(string.Join(",", byer2));

            foreach (string by2 in byer2)
            {
                Console.WriteLine("By:" +  by2);
            }

            Console.WriteLine("3. Erstat den værdi, uden at ændre direkte i listen, som ikke passer ind, så listen stemmer");

            List<int> talrække1 = new List<int> { 0, 1, 0, 3, 4, 5, 6 };

            talrække1[2] = 2;

            Console.WriteLine(string.Join(",", talrække1));

            Console.WriteLine("4. Skriv, i konsollen, den største værdi fra følgende liste. Selvfølgelig ikke manuelt");

            List<int> talrække2 = new List<int> { 1, 2, 3, 4, 11, 55, 99, 100 };

            int største = talrække2.Max();

            Console.WriteLine(største);

            Console.WriteLine("5. Sorter den her liste:");

            List<int> talrække3 = new List<int> { 0, 12, 0, 22, 300, 4, 5 };

            talrække3.Sort();

            Console.WriteLine(string.Join(",", talrække3));

            Console.WriteLine("6. Sorter den her liste i omvendt rækkefølge:");

            List<int> talrække4 = new List<int> { 0, 12, 0, 22, 300, 4, 5 };

            talrække4.Sort();

            talrække4.Reverse();

            Console.WriteLine(string.Join(",", talrække4));

        }
        static void LoopsMedArraysOgAndreDatatyper()
        {
            header("Loops med arrays og andre datatyper");

            Console.WriteLine("1. Lav et program som summere følgende liste, uden brug af Aggregat Funktioner: ");

            List<int> talrække1 = new List<int> { 0, 12, 0, 22, 300, 4, 5 };

            int summen = 0;

            foreach (int tal1 in talrække1)
            {
                summen += tal1;
            }

            Console.WriteLine(summen);

            Console.WriteLine("2. Lav et program som skriver alle værdierne i denne liste, ved brug af foreach: ");

            List<int> talrække2 = new List<int> { 0, 12, 0, 22, 300, 4, 5 };

            foreach (int tal2 in talrække2)
            {
                Console.WriteLine("tal:" + tal2);
            }

            Console.WriteLine("3. Lav et program som returnere indexet af det højeste tal, altså giver dens placering i begge lister");

            List<int> talrække3 = new List<int> { 0, 12, 0, 22, 300, 4, 5, 12, 12, 212, 12 };
            List<int> talrække_4 = new List<int> { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 122 };

            int max3 = talrække3.Max();
            int max4 = talrække_4.Max();
            int index3 = talrække3.IndexOf(max3);
            int index4 = talrække_4.IndexOf(max4);
            Console.WriteLine($"talrække3 har {max3} på plads {index3}");
            Console.WriteLine($"talrække4 har {max4} på plads {index4}");

            Console.WriteLine("4. Lav et program som tæller hvor mange gange 12, står i den her liste:");

            List<int> talrække4 = new List<int> { 0, 12, 0, 22, 300, 4, 5, 12, 12, 212, 12 };

            int count4 = talrække4.Count(value => value == 12);

            Console.WriteLine(count4);

            Console.WriteLine("5. Lav et program som tæller, hvor mange værdier som er positive i denne liste: (0 er ikke positiv i denne opgave)");

            List<int> talrække5 = new List<int> { 0, -12, 0, -22, -300, 4, 5, -12, 12, -212, 12 };

            int count5 = talrække5.Count(value => value > 0);

            Console.WriteLine(count5);

            Console.WriteLine("6. Lav et program som finder gennemsnittet af følgende liste og alle andre lister bestående af tal uden brug af Aggregat Funktioner:");
            Console.WriteLine(" Forventet svar: 132.5");

            List<int> talrække6 = new List<int> { 0, 12, 0, 22, 300, 4, 5, 1000, -50, 32 };

            Console.WriteLine("7. Lav et program som finder variansen af følgende liste og alle andre lister bestående af tal uden brug af Aggregat Funktioner:");

            List<int> talrække7 = new List<int> { 0, 12, 0, 22, 300, 4, 5, 1000, -50, 32 };

            Console.WriteLine("8. Lav et program, som skriver følgende i konsollen. \r\nDen her gang skal det være med et loop, som skrive linjerne enkeltvis. \r\nMan skal hurtig og let kunne ændre hvor mange linjer den skriver. \r\nMan skal bruge 2 loops til opgaven. ");

            Console.WriteLine("*\r\n**\r\n***\r\n**\r\n*");



        }
    }
}
