using UnityEngine;
using System.Collections;

public static class Dice {
    private static System.Random rng = new System.Random();

    public static int Roll6()
    {
        return rng.Next(1,6);
    }

    public static int Roll10()
    {
        return rng.Next(1,10);
    }
}
