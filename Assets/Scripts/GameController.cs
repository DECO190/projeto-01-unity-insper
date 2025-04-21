using UnityEngine;

public static class GameController
{
    public static int collectableCount = 0;
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
            return heartCount <= 0 || elapsedTime <= 0;
        }
    }
    
    public static bool win 
    {
        get
        {
            return heartCount > 0 && elapsedTime > 0 && collectableCount >= 10;
        }
    }

    public static void Init()
    {
        heartCount = 3;
        collectableCount = 0;
        elapsedTime = 180;
    }

    public static void Collect()
    {
        collectableCount++;
    }
}
