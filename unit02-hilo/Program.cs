using System;

namespace unit02_hilo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool play = true;
            string guess = "";
            Score score1 = new Score();
            score1._score = 300;

            while (play == true) 
            {
                Card card1 = new Card();
                card1._card = card1.updateCard();

                Console.WriteLine($"\nThe card number is: {card1._card}");
                Console.WriteLine("Higher or Lower [h/l]: ");
                guess = Console.ReadLine();
                //Console.WriteLine($"{guess}");

                Card card2 = new Card();
                card2._card = card2.updateCard();
                Console.WriteLine($"Next card was: {card2._card}");

                string compare = "";
                compare = card1.compareCard(card1._card, card2._card);
                //Console.WriteLine($"{compare}");

                int step = card1.compareGuess(guess, compare);
                //Console.WriteLine($"{step}");

                // Score score1 = new Score();
                // score1._score = 300;

                switch (step) {
                    case 2:
                        score1._score = score1.addPoints(score1._score, 100);
                        break;
                    case 1:
                        score1._score = score1.minusPoints(score1._score, 100);
                        break;
                    case 0:
                        break;
                }

                Console.WriteLine($"Your score is: {score1._score}");
                Console.WriteLine("\nWould you like to play again [y/n]: ");
                string user = "";
                user = Console.ReadLine();
                if (user == "y") {

                }
                else if (user == "n") {
                    break;
                }
                else {
                    Console.WriteLine("Sorry that didn't register. Please try again.");
                }

            }
        }
    }
}
