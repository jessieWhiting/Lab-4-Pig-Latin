using System.Reflection.Metadata.Ecma335;

namespace Lab_4_Pig_Latin
{
    public class Program
    {
        static void Main()
        {

            // Happy for ALL feedback with this one! I chose to keep everything within one method and build a case to determine the language. What would you have done??


            bool goOn = true;

            // While goOn is true; initiate runthrough of translation. Will run through once.

            while (goOn)
            {
                Console.WriteLine(" Pig Latin Translator.");
                Console.WriteLine(" \n Enter a Word: \n");
                string words = Console.ReadLine().ToLower();

                int VowelPosition = -1;

                // Check each letter in words for the following characters.

                foreach (char letter in words)
                {
                    VowelPosition = VowelPosition + 1;
                    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                    {
                        break;
                    }

                }

                string endLetters = "";
                string fLetters = "";
                string pigLatin = "";

                switch (VowelPosition)
                {
                    // Add way

                    case 0:
                        pigLatin = words + "way";
                        break;

                    // Move first letter to end and add "ay"

                    case 1:
                        fLetters = words.Substring(0, 1);
                        endLetters = words.Substring(1);
                        pigLatin = endLetters + fLetters + "ay";
                        break;

                    // Two Consonants to add at end and add "ay"

                    case 2:
                        fLetters = words.Substring(0, 2);
                        endLetters = words.Substring(2);
                        pigLatin = endLetters + fLetters + "ay";
                        break;

                    // Three Consonants to add at end and "ay"

                    case 3:
                        fLetters = words.Substring(0, 3);
                        endLetters = words.Substring(3);
                        pigLatin = endLetters + fLetters + "ay";
                        break;

                    // Four Consonants to add at end and "ay"

                    case 4:
                        fLetters = words.Substring(0, 4);
                        endLetters = words.Substring(4);
                        pigLatin = endLetters + fLetters + "ay";
                        break;

                    // For if unable to translate == any word with more than 4 consonants... most likely jibberish.

                    default:
                        pigLatin = " not able to be translated.";
                        break;
                }
                    // Final word written here:

                Console.WriteLine(" \n The tranlation for " + words + " is: " + pigLatin);

                    // Creates a loop to run again.

                bool askAgain = true;
                while (askAgain)
                {
                    Console.WriteLine(" \n Would you like to learn another word? Type:\"Y/N\"");
                    string input = Console.ReadLine().ToUpper();

                    if (input == "Y")
                    {
                        goOn = true;
                        askAgain = false;
                    }
                    else if (input == "N")
                    {
                        goOn = false;
                        askAgain = false;
                    }
                    else
                    {
                        Console.WriteLine(" Invalid response. Please try again... ");
                        askAgain = true;

                        // When askAgain is true, re-run this While loop.
                    }
                }
            }


        }

        
    }
}

    



            



            