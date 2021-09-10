using TMPro;
using UnityEngine;


public class Countdown : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;

    [SerializeField]
    TextMeshProUGUI countdownText;

    void Start()
    {
        currentTime = startingTime;
    }
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        

        if (currentTime <= 0)
        {
            currentTime = 0;
            
            Vibrator.Vibrate(250);
            Vibrator.Vibrate(0);
            

        }
        
    }

}
