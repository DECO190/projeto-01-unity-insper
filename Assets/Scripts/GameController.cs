using UnityEngine;

public static class GameController
{
    private static int collectableCount = 10;
    public static int heartCount = 3;
    public static float elapsedTime = 90;
 
    public static void removeHeart() 
    {
        heartCount--;
    }
    
    public static bool gameOver 
    {
        get
        {
            return collectableCount <= 0 || heartCount <= 0 || elapsedTime <= 0;
        }
    }

    public static void Init()
    {
        heartCount = 3;
        collectableCount = 10;
        elapsedTime = 180;
    }

   

    public static void Collect()
    {
        collectableCount--;
    }
}
