// See https://aka.ms/new-console-template for more information

using System;
using coursTestUnitaire.Constant;


namespace coursTestUnitaire
{
    class Echauffement
    {
        const string lang = "En";
        private static bool boucle = true;
        
        static void Main()
        {
            string? input = "";
            string output = "";
            string hello = "";
            string goodEvening = "";
            string bye = "";
            string goodSay = "";
            if (lang == "En")
            {
                hello = En.hello;
                goodEvening = En.goodEvening;
                bye = En.bye;
                goodSay = En.goodSay;
            }
            else if (lang == "Fr")
            {
                hello = Fr.hello;
                goodEvening = Fr.goodEvening;
                bye = Fr.bye;
                goodSay = Fr.goodSay;
            }
            DateTime now = DateTime.Now;
            if(now.Hour >= 18)
            {
                Console.WriteLine(goodEvening);
            }
            else
            {
                Console.WriteLine(hello);
            }
            while (boucle)
            {
                input = Console.ReadLine();
                if (input==""){input=null;}
                if (input != null)
                {
                    for(int i = input.Length-1; i >= 0; i = i-1)
                    {
                        output = output + input[i];
                    }
                    if (output == input)
                    {
                        Console.WriteLine(goodSay);
                    }
                    else
                    {
                        Console.WriteLine(output);
                    }
                }
                else
                {
                    Console.WriteLine(bye);
                    boucle = false;
                }
                input = "";
                output = "";
            }
        }
    }
}