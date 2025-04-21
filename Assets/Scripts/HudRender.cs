using UnityEngine;
using TMPro;

public class HudRender : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI heartText;
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] TextMeshProUGUI coinsText;


    void Start()
    {
        heartText.text = "".PadLeft(GameController.heartCount, '|');
    }
    
    void FixedUpdate()
    {
        heartText.text = "".PadLeft(GameController.heartCount, '|');

        coinsText.text = GameController.collectableCount + "/10";
    }
    
    void Update()
    {
        GameController.elapsedTime -= Time.deltaTime;
        
        int minutes = Mathf.FloorToInt(GameController.elapsedTime / 60);
        int seconds = Mathf.FloorToInt(GameController.elapsedTime % 60);
        
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }  
}