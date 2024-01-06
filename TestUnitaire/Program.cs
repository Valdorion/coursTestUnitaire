using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Test;

public class Program
{
    public static string langueSysteme = CultureInfo.CurrentCulture.Name;
    public static int date = DateTime.Now.Hour;
    
    public static void Main(string[] args)
    {
        try
        {
            string test1 = "kayak";
            string test2 = "Bonjour";

            if (!CheckPalindrome(test1) || CheckPalindrome(test2))
            {
                throw new Exception("Erreur 01 : Test don't work");
            }
            else
            {
                Script();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        
    }

    public static void Script()
    {
        List<string> lang = selectLangue();
        Console.WriteLine(lang[0]);
        string mot = Console.ReadLine();
        if(CheckPalindrome(mot))
        {
            Console.WriteLine(Palindrome(mot));
            Console.WriteLine(lang[2]);
        }
        Console.WriteLine(lang[1]);
    }
    
    public static List<string> selectLangue()
    {
        List<string> lang = new List<string>();
        if (langueSysteme == "fr-FR")
        {
            if (date >= 8 && date < 12)
            {
                lang.Add("bonjour_am");
                lang.Add("auRevoir_am");
            }
            else if (date >= 12 && date < 18)
            {
                lang.Add("bonjour_pm");
                lang.Add("auRevoir_pm");
            }
            else if (date >= 18 && date < 21)
            {
                lang.Add("bonjour_soir");
                lang.Add("auRevoir_soir");
            }
            else
            {
                lang.Add("bonjour_nuit");
                lang.Add("auRevoir_nuit");
            }
            lang.Add("bien dit");
        }
        else if (langueSysteme == "en-US")
        {
            if (date >= 8 && date < 12)
            {
                lang.Add("Good morning");
                lang.Add("bye_am");
            }
            else if (date >= 12 && date < 18)
            {
                lang.Add("Good afternoon");
                lang.Add("bye_pm");
            }
            else if (date >= 18 && date < 21)
            {
                lang.Add("hello_evening");
                lang.Add("Good evening");
            }
            else
            {
                lang.Add("hello_nuit");
                lang.Add("Goodnight");
            }
            lang.Add("well said");
        }
        else if (langueSysteme == "es-ES")
        {
            if (date >= 8 && date < 12)
            {
                lang.Add("hola_am");
                lang.Add("adiós_am");
            }
            else if (date >= 12 && date < 18)
            {
                lang.Add("hola_pm");
                lang.Add("adiós_pm");
            }
            else if (date >= 18 && date < 21)
            {
                lang.Add("hola_soir");
                lang.Add("adiós_soir");
            }
            else
            {
                lang.Add("hola_nuit");
                lang.Add("adiós_nuit");
            }
            lang.Add("bien dicho");
        }
        return lang;
    }
    
    public static string Palindrome(string mot)
    {
        string palindrome = "";
        for(int i = mot.Length - 1; i >= 0; i--)
        {
            palindrome += mot[i];
        } 
        return palindrome;
    }
    
    public static bool CheckPalindrome(string mot)
    {
        string palindrome = Palindrome(mot);
        if(palindrome == mot)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}