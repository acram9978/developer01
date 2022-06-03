using System;

namespace unit02_hilo
{
    class Card
    {
        public int _card;

        public int updateCard() 
        {
            Random rnd = new Random();
            return rnd.Next(1, 13);
        }

        public string compareCard(int num1, int num2)
        {
            string outcome = "";
            if (num1 > num2) {
                outcome = "lower";
            }
            else if (num1 < num2) {
                outcome = "higher";
            }
            else {
                outcome = "same";
            }

            return outcome;
        }

        public int compareGuess(string guess, string outcome) {
            int scoreUpdate;
            if (guess == "l" && outcome == "lower") {
                scoreUpdate = 2;
                return scoreUpdate;
            }
            else if (guess == "h" && outcome == "higher") {
                scoreUpdate = 2;
                return scoreUpdate;
            }
            else if (outcome == "same") {
                scoreUpdate = 0;
                return scoreUpdate;
            }
            else {
                scoreUpdate = 1;
                return scoreUpdate;
            }
        }
    }
}