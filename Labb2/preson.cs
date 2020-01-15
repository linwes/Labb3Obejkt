using System;

namespace Labb3
{
    public struct hår
    {
        public string färg;
        public double längd;
    }
    class person
    {
        public string namn;
        public string kön;
        public DateTime födelsedag;
        private string ögon;
        public hår hår;

        public override string ToString()
        {
            string personen =("");
            Console.WriteLine("Namn: {0}", namn);
            Console.WriteLine("Kön: {0}", kön);
            Console.WriteLine("Födelsedatum: {0}", födelsedag.ToString("yyyy-MM-dd"));
            Console.WriteLine("Ögon: {0}", nyÖgon);
            Console.WriteLine("Hår längd: {0}cm \nHår färg: {1}",hår.längd, hår.färg);
            return personen;            
        }
        public string taNamn()
        {
            Console.WriteLine("skriv in din vänns namn");
            namn = Console.ReadLine();
            return namn;
        }
        public string taKön()
        {
            Console.WriteLine("vad har din vän för kön?");
            kön = Console.ReadLine();
            return kön;
        }
        public string Ögon()
        {
            Console.WriteLine("vilken ögonfärg har din vän?");
            ögon = Console.ReadLine();
            return ögon;
        }
        public string nyÖgon
        {
            get { return ögon; }
            set { ögon = value; }
        }
        public DateTime taFödsel()
        {
            //string parseFödsel;
            Console.WriteLine("när är din vän född? skriv yyyy/MM/dd");
            while (!DateTime.TryParse( Console.ReadLine(), out födelsedag))
            {
                Console.WriteLine("värdet kan inte hanteras, försk igen");             
            }
            //födelsedag.ToString("{yyyy/MM/dd}");
            return födelsedag;
        }
        public double taLängd()
        {
            double längd;
            Console.WriteLine("vad är längden på din vänns hår? skriv i cm");
            while (!double.TryParse(Console.ReadLine(), out längd))
            {
                Console.WriteLine("värdet kan inte hanteras, försk igen");
            }
            this.hår.längd = längd;
            return hår.längd;
        }
        public string taFärg()
        {
            string färg;
            Console.WriteLine("vad är färgen på din vänns hår?");
            färg = Console.ReadLine();
            this.hår.färg = färg;
            return hår.färg;
        }
        public string skrivHår(string färg, double längd)
        {
            string hår;
            Console.WriteLine("Hår längd: {0} \nHår färg {1}", längd, färg);
            hår = Console.ReadLine();
            return hår;
        }
    }
}
//for loop fråga användaren om hur många den vill lägga in
//if där man frågar användaren om den vill lägga till en ny person