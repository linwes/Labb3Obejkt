using System;

namespace Labb3
{
    class Program
    {
        static void Main(string[] args)
        {
            //en bool statment så länge den är san så kommer menyn visas
            bool main = true;
            while (main)
            {
                main = huvudMeny();
            }
        }
        //jag har valt att göra allt till olika metoder för att göra det mer stilrent samt att jag kan använda 
        //koden vid senare tillfelen
        public static bool huvudMeny()
        {
            //string tillbacka;
            string meny;
            int menySan;
            Console.WriteLine("1.Gångertabbel");
            Console.WriteLine("2.Ny array");
            Console.WriteLine("3.Datorns nummer");
            Console.WriteLine("4.Lägg in personer i programet");
            Console.WriteLine("5.avsluta programet");
            Console.WriteLine("Skriv in en siffra för att gå till programet");

            meny = (Console.ReadLine());
            while (!int.TryParse(meny, out menySan))
            {
                Console.WriteLine("värdet kan inte hanteras, försk igen");

                meny = Console.ReadLine();
            }
            //jag har valt att anända en switch meny
            switch (menySan)
            {
                case 1:
                    {
                        gångertabbel();
                        return true;
                    }

                case 2:
                    {
                        nyArray();
                        return true;
                    }
                case 3:
                    {
                        datorSiffror();
                        return true;
                    }
                case 4:
                    {
                        minaVänner();
                        return true;
                    }
                case 5:
                    {
                        return false;
                    }
                default:
                    {
                        return true;
                    }
            }
        }
        static void gångertabbel()
        {
            int l, v;
            for (v = 0; v < 10; v++)
            {
                for (l = 0; l < 10; l++)
                {
                    //\t gör så att det blir lite mellanrum mellan de olika talen för den specifika gångertabbelen
                    //kommer att gå igeonm alla tal från 1-9 och sedan så kommer den att hoppa
                    //ner till nästa rad samt att v ökar i värde från 1-9 och varje gång den ökar värde 
                    //så kommer l att gångra sig själv med värdet i v 9 gånger 
                    Console.Write("{0}\t", v*l);
                }
                //\n gör så att det blir en ny rad för varje gång den har gångart med <10
                Console.WriteLine("\n");
            }
        }
        static void nyArray()
        {
            int antal, i;
            string parseAntal;
            double min, max;
            Console.WriteLine("skriv in hur stor din array ska vara");
            //gör om stringen till en int via en TryParse som sedan läggs in i arrayen för att visa hor stor den ska vara

            parseAntal = (Console.ReadLine());
            while (!int.TryParse(parseAntal, out antal))
            {
                Console.WriteLine("värdet kan inte hanteras, försk igen");

                parseAntal = Console.ReadLine();
            }
            double[] tal = new double[antal];
            //göra metod om de olika momentetn 
            for (i = 0; i < antal; i++)
            {
                tal[i] = talen(antal);
            }
            //här kollar programet efter minsta värdet, det börjar på den första insata siffran i arrayen och går sedan
            //till den sista (antal), 0 står för att man börjar med det första som står i arrayen, sedan när den har 
            //jämnför alla tal så skriver den ut den största respektive minsta
            max = tal[0];
            min = tal[0];
            for (i = 1; i < antal; i++)
            {
                if (tal[i] > max)
                {
                    max = tal[i];
                }
                if (tal[i] < min)
                {
                    min = tal[i];
                }
            }
            Console.WriteLine("det minsta du skrev var {0} och det största var {1}", min, max);
            //här räknas summan ut och loopar dem till de kommer till antalet som var inskrivet i den första arrayen (antal)
            double sum = 0;
            for (i = 0; i < antal; i++)

                sum = sum + tal[i];
            Console.WriteLine("summan av alla tallen är {0}", sum);
            //delar summan med antal för att få fram medelvärdet
            double sum2 = sum / antal;
            Console.WriteLine("medelvärdet blir cirka {0}", sum2);
        }
        private static double talen(int antal)
        {
            //denna metod anropas när man klickar 2 i menyn, den tar in data från användaren, omvandlar stringen till en int
            //samt gör en ny array med storlekn av vad personen skriver in i metoden nyArray. sedan returnerar vi tal
            double tal;
            string talParse;
            Console.WriteLine("skriv in ett tal och klicka på enter");
            talParse = Console.ReadLine();
            while (!double.TryParse(talParse, out tal))
            {
                Console.WriteLine("värdet kan inte hanteras, försök igen");

                talParse = Console.ReadLine();
            }
            double[] inlästa = new double[antal];
            return tal;
        }
        static void datorSiffror()
        {
            int sanMin, sanMax, sanSlump;
            string antalSlump, slumpMin, slumpMax;
            // ber användaren skriva ut hur många som de vill ha i arrayen samt mellan vilka tal de ska vara mellan

            Console.WriteLine("Hur många siffror vill du att programet ska skriva ut?");
            antalSlump = (Console.ReadLine());
            while (!int.TryParse(antalSlump, out sanSlump))
            {
                Console.WriteLine("värdet kan inte hanteras, försk igen");

                antalSlump = Console.ReadLine();
            }

            Console.WriteLine("vad vill du att max värdet ska vara i det slumpmässiga programet?");
            slumpMax = (Console.ReadLine());
            while (!int.TryParse(slumpMax, out sanMax))
            {
                Console.WriteLine("värdet kan inte hanteras, försk igen");
                slumpMax = Console.ReadLine();
            }

            Console.WriteLine("vad vill du att minsta värdet ska vara i programet?");
            slumpMin = (Console.ReadLine());
            while (!int.TryParse(slumpMin, out sanMin))
            {
                Console.WriteLine("värdet kan inte hanteras, försk igen");
                slumpMin = Console.ReadLine();
            }

            //En array som tar emot annatalet siffror som användaren skriver in
            int[] slump = new int[sanSlump];
            //random låter datorn välja nummer
            Random slumpNummer = new Random();
            for (int i = 0; i < slump.Length; i++)
            {
                //gör att programet börjar med min och slutar på max
                slump[i] = slumpNummer.Next(sanMin, sanMax);
            }
            //sorterar värderna som datorn ger
            Array.Sort(slump);
            foreach (int value in slump)
            {
                Console.Write(value + "\t");
            }
            Console.ReadLine();
        }
        static void minaVänner()
        {
            int antalPers;
            Console.WriteLine("hur många person vill du skriva in?");
            antalPers = Int32.Parse(Console.ReadLine());

            person[] personer = new person[antalPers];
            for (int i = 0; i < personer.Length; i++)
            {
                person pers = new person();
                pers.taNamn();
                pers.taKön();
                pers.taFödsel();
                pers.Ögon();
                pers.taLängd();
                pers.taFärg();
                personer[i] = pers;
            }
            foreach (person vän in personer)
            {
                Console.WriteLine(vän.ToString());
            }

        }
    }
}
