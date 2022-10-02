using System;

public class Class1
{
	public Class1()
	{
        static void Main()
        {
            Console.WriteLine("Enter a word and we will convert to the TIMELESS language PigLatin:");

            // allows user to choose their own word, it is run through a separate method, and printed to console by the Main.

            string pickWord = Console.ReadLine();
            string pigLatin = ToPigLatin(pickWord);
            Console.WriteLine(pigLatin);
        }
        static string ToPigLatin(string pickWord)
        {
            string firstLetter,
                   endOfWord,
                   vowels = "aeiouAEIOU";
            int currentLetter;

            foreach (string word in pickWord.Split())
            {
                firstLetter = pickWord.Substring(0, 1);
                endOfWord = pickWord.Substring(1, pickWord.Length - 1);
                currentLetter = vowels.IndexOf(firstLetter);

                if (currentLetter == -1)
                {
                    pickWord = endOfWord + firstLetter + "ay";
                }
                else
                {
                    pickWord = word + "way";
                }
            }
            return pickWord;
        }
}
