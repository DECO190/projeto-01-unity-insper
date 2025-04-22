using UnityEngine;
using TMPro;

public class EndPanel : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI remainingSecondsText;
    
    void FixedUpdate()
    {
        remainingSecondsText.text = "Tempo restante: " + GameController.elapsedTime.ToString()  + "s"; 
    }
}
