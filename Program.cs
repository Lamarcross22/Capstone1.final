using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Capstone1.final
{
    public class PigLatinClass
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("Welcome to the Pig Latin Translator!");
            String sentence = "";
            Pigtalk(sentence);
        }

         static void Pigtalk (string sentence)
        {
            
            try
            {
                bool repeat = true;
                while (repeat)
                {
                    
                    string firstLetter;
                    string afterFirst;
                    string pigLatinOut = "";
                    int x;
                    string vowel = "AEIOUaeiou";

                    Console.WriteLine("enter a t convert into piglatin");

                    sentence = Console.ReadLine();
                    string[] pieces = sentence.Split();

                    foreach (string piece in pieces)
                    {
                        afterFirst = piece.Substring(1);
                        firstLetter = piece.Substring(0, 1);
                        x = vowel.IndexOf(firstLetter);

                        if (x == -1)
                        {
                            pigLatinOut = (afterFirst + firstLetter + "ay ");
                        }
                        else
                        {
                            pigLatinOut = (firstLetter + afterFirst + "way ");
                        }

                        Console.Write(pigLatinOut);
                    }


                    Console.WriteLine("Press Enter to flip the word back.");
                    Console.ReadKey(true);
                    string clonedString = null;
                    clonedString = (String)sentence.Clone();
                    Console.WriteLine(clonedString);


                    Console.WriteLine("Translate another line? Type Y or N.");
                    string userResponse = Console.ReadLine();

                    if (userResponse == "Y" || userResponse == "y")
                    {
                        repeat = true;
                    }
                    else if (userResponse == "N" || userResponse == "n")
                    {
                        repeat = false;
                    }
                }
            }


            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
             
        }
    }
}
