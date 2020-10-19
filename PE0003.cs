using System;

namespace PE0003
{
    class Program
    {
        static void Main(string[] args)
        {
            //The prime factors of 13195 are 5, 7, 13 and 29.
            //What is the largest prime factor of the number 600851475143 ?

            /*
            1. Bepaal of de deler een priemgetal is
                1a. Kleinste priemgetal is 3.
            2. Bepaal of max door dat priemgetal gedeeld kan worden
            3. Wijs de uitkomst aan max toe en herhaal
            */

            /*
            //Testcode om te zien of isPriem de juiste output geeft.
            for (double deler = 1; deler < 30; deler++)
            {
                if (isPriem(deler))
                {
                    Console.WriteLine(deler);
                }
            }
            */

            double max = 600851475143; // * 4;

            for (double deler = 2; deler < max; deler++)
            {
                if (max % deler == 0)
                {
                    max = max / deler;
                    Console.Write(deler + " * ");
                }
            }
            Console.Write(max); // geef restgetal weer, hier dus die 6857.
            //Output is 71 * 839 * 1471 * 6857. 6857 was het goede antwoord.
            
            /*
            //Testcode om te zien of het priemgetallen zijn.
            if (isPriem(71))
            {
                Console.WriteLine(71);
            }
            if (isPriem(839))
            {
                Console.WriteLine(839);
            }
            if (isPriem(1471))
            {
                Console.WriteLine(1471);
            }
            if (isPriem(6857))
            {
                Console.WriteLine(6857);
            }
            */

            Console.ReadLine();
        }
        /*
        public static bool isPriem(double getal)
        {
            //Priemgetal kan door 1 en door zichzelf delen. Als ik de teller bij 2 laat beginnen scheelt dat code en rekentijd (want geen getal kan door 0 delen, en ieder getal kan door 1).
            //Het gaat door tot teller < getal + 1, oftewel teller == getal.
            //Ik gebruik maar meteen doubles omdat double max een groot getal is, dus prime factors kunnen mogelijk groot worden.

            bool isEenPriem = true;

            for (double teller = 2; teller < getal + 1; teller++)
            {
                if (getal % teller == 0 && !(getal == teller))
                {
                    isEenPriem = false;
                }
            }
            return isEenPriem;
            //Kostte me een uur of twee. Ik kreeg steeds niet-priem terug als wel priem (bijvoorbeeld 4).
            //Kwam er uiteindelijk achter dat als ik 
            //      if(getal % teller == 0 && getal == teller)
            //gebruik, dat dan 4 % 4 == 0 && 4 == 4 waar is, dus geeft het true terug. Wat ik dus niet wil.
            //Ik wil enkel weten of "(getal / teller) 0 als restwaarde heeft, zolang getal & teller niet hetzelfde zijn".
        }
        */

        //Uiteindelijk hele isPriem class niet gebruikt.
        //Nog geprobeerd of ik geluk had met het antwoord (de * 4 bij max) omdat alle getallen ook priemgetallen waren. Maar dat was niet zo, omdat * 4 uiteenvalt in * 2 * 2.
        //Wat een omwegen. Logisch gezien loop ik natuurlijk vanzelf grote priemgetallen aan, omdat de niet-priemgetallen uiteenvallen in kleinere getallen.
        //Dus om nou priemgetallen te printen is overdreven, maar wel leerzaam. Blijkt dat ik een double in een bool class kan invoeren, en een bool terug kan sturen.
    }
}
