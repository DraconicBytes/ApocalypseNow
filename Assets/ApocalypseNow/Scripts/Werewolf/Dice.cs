using System.Collections.Generic;

namespace ApocalypseNow.Werewolf
{
    public static class Dice
    {
        private static System.Random rng = new System.Random();

        public static int Roll6()
        {
            return rng.Next(1, 6);
        }

        public static int Roll10()
        {
            return rng.Next(1, 10);
        }

        public static int RollDice(int pool, int difficulty, bool reroll)
        {
            if (difficulty > 10 || pool < 1) // Check if roll is necessary
                return 0;

            int successes = 0;
            List<int> results = new List<int>();
            while (pool > 0)
            {
                List<int> currentResults = new List<int>();
                // Roll dices
                for (int i = 0; i < pool; i++)
                    currentResults.Add(Roll10());
                pool = 0;

                //Sort list
                currentResults.Sort();

                // Deduct 1s with the higest dices from the pool
                while (currentResults[0] == 1)
                {
                    currentResults.Remove(0);
                    if (currentResults.Count >= 1)
                        currentResults.Remove(currentResults.Count - 1);
                    if (currentResults.Count < 1)
                        break;
                }

                // Merge results of this round with the overall results
                results.AddRange(currentResults);

                // Estimate the number of rerolls
                if (reroll)
                {
                    foreach (int die in currentResults)
                        if (die == 10)
                            pool++;
                }
            }

            // Count successes
            foreach (int die in results)
                if (die >= difficulty)
                    successes++;
            return successes;
        }
    }
}
