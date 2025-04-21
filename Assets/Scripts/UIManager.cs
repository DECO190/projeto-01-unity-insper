using UnityEngine;

public class UIManager : MonoBehaviour
{
   public GameObject endGamePanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (GameController.gameOver)
        {
            endGamePanel.SetActive(true);
        }
    }
}
