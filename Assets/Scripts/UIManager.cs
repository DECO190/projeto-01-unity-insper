using UnityEngine;

public class UIManager : MonoBehaviour
{
   public GameObject gameOverPanel;
   public GameObject winPanel;
   
    void FixedUpdate()
    {
        if (GameController.gameOver)
        {
            gameOverPanel.SetActive(true);
        }

        if (GameController.win)
        {
            winPanel.SetActive(true);
        }
    }
}
