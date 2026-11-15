using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leveltask.Tasks.new_redesign._25_Hangman
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hangman!");
            Console.Write("Enter a word to guess: ");
            string wordToGuess = Console.ReadLine();
            Hangman hangman = new Hangman(wordToGuess);
            while (hangman.AttemptsLeft > 0 && hangman.CurrentWordState.Contains('_'))
            {
                Console.WriteLine($"Current word state: {hangman.CurrentWordState}");
                Console.WriteLine($"Attempts left: {hangman.AttemptsLeft}");
                Console.WriteLine($"Wrong letters: {hangman.wrongLetters}");
                Console.Write("Guess a letter: ");
                char guessedLetter = Console.ReadKey().KeyChar;
                Console.WriteLine();
                hangman.GuessLetter(guessedLetter);
            }
            if (hangman.CurrentWordState == wordToGuess)
            {
                Console.WriteLine($"Congratulations! You've guessed the word: {wordToGuess}");
            }
            else
            {
                Console.WriteLine($"Game over! The word was: {wordToGuess}");
            }

        }

    }



    public class Hangman
    {
        private string WordToGuess { get; set; }
        public string CurrentWordState { get; private set; }
        public int MaxAttempts { get; private set; } = 6;
        public char[] GuessedLetters { get; private set; }
        public int AttemptsLeft { get; private set; }
        public string wrongLetters { get; private set; }
        public Hangman(string wordToGuess)
        {
            WordToGuess = wordToGuess;
            CurrentWordState = new string('_', wordToGuess.Length);
        }
        public void GuessLetter(char letter)
        {
            if (WordToGuess.Contains(letter))
            {
                for (int i = 0; i < WordToGuess.Length; i++)
                {
                    if (WordToGuess[i] == letter)
                    {
                        CurrentWordState = CurrentWordState.Remove(i, 1).Insert(i, letter.ToString());
                    }
                }
            }
            else
            {
                wrongLetters += letter;
                AttemptsLeft--;
            }
        }


    }
}
