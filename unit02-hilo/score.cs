using System;

namespace unit02_hilo
{
    class Score
    {
        public int _score;

        public int addPoints(int origScore, int points)
        {
            origScore = origScore + points;
            return origScore;
        }

        public int minusPoints(int origScore, int points)
        {
            origScore = origScore - points;
            return origScore;
        }
    }
}