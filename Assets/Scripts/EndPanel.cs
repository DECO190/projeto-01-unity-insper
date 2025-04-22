using UnityEngine;
using TMPro;

public class EndPanel : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI remainingSecondsText;
    
    void FixedUpdate()
    {
        int seconds = Mathf.FloorToInt(GameController.elapsedTime);

        remainingSecondsText.text = "Tempo restante: \n" + seconds.ToString()  + "s"; 
    }
}
