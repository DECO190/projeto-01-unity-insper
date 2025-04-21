using UnityEngine;
using TMPro;


public class Timer : MonoBehaviour {
    [SerializeField] TextMeshProUGUI timerText;
    
    void Update()
    {
        GameController.elapsedTime -= Time.deltaTime;
        
        int minutes = Mathf.FloorToInt(GameController.elapsedTime / 60);
        int seconds = Mathf.FloorToInt(GameController.elapsedTime % 60);
        
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
