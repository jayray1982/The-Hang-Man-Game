using System.ComponentModel.Design;

namespace The_Hang_Man_Game
{
    internal class Program
    {
        const int TOTAL_USER_ATEMPTS = 10;
        const int userGuess = 0;

        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");

            var mysteryWords = new List<string>() { "Apple", "Bagel", "Cookie", "Donught", "Eggs", "Fries", "Grapes", "Hamburger", "Icing", "Jams" };
            Random rNb = new Random();
            int randomNumber = rNb.Next(0, 9);
            string guessWord = mysteryWords[randomNumber];
            // The following code is used to check work as I work.
            Console.WriteLine("list count is " + mysteryWords.Count + ".");
            Console.WriteLine(guessWord);
            Console.WriteLine(guessWord[0]);
            int userGuess = 0;
            Console.WriteLine(guessWord.Length);

            // building an array of user guessletters
            var userGuessLetter = new List<char>();
            // Console.WriteLine("_____");

            // loop to write out guessword in a hidden form.
            for (int l = 0; l < guessWord.Length; l++)
            {
                Console.Write("_ ");
               
            }
            Console.Write("\r\n");


            //TODO build the word as array of chars
            char[] hiddenWord = new char[guessWord.Length];
            for(int i=0; i < hiddenWord.Length; i++)
            {
                hiddenWord[i] = '_';
            }

            for (int l = 0; l < guessWord.Length; l++)
            {
                Console.Write(hiddenWord[l]);

            }


            //Make a loop to compare each letter of Array if the guess word to the user guess.
            //Loop states if userletterGuess is in hiddenWord Array, then find each location and display.

            // building blockof code to check users guess to the actual guessword.
            while (userGuess != TOTAL_USER_ATEMPTS) 
            {
                
                Console.Write("\n Letters guessed so far..");
                foreach (char letterGuess in userGuessLetter)
                {
                    Console.Write(letterGuess + " ");
                }
                string word = guessWord;
                var letterGuess = Console.ReadLine();
                userGuess++;
                if (guessWord.Contains(letterGuess))
                
                {
                    hiddenWord[4] = Convert.ToChar(letterGuess);
                    Console.WriteLine(guessWord + letterGuess);
                    Console.WriteLine("Awesome!");

                }
                else
                {
                    Console.WriteLine("Sorry, try again.");
                    userGuess++;
                }
                
            }
        }
    }
}
