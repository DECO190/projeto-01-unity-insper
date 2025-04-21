using UnityEngine;
using TMPro;

public class HeartCountDisplay : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;

    void Start()
    {
        text.text = "".PadLeft(GameController.heartCount, '|');
    }
    
    void FixedUpdate()
    {
        text.text = "".PadLeft(GameController.heartCount, '|');
    }


   
}