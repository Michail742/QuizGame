using System;
using System.Collections;
using TMPro;
using UnityEngine;


public class Countdown : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;

    [SerializeField]
    TextMeshProUGUI countdownText;
    
    //public bool coroutineAllowed;

    void Start()
    {
        currentTime = startingTime;
        //coroutineAllowed = true;
        //Vibration.Vibrate(2000);
    }
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        

        if (currentTime <= 0)
        {
            currentTime = 0;
            //VibrateCoroutine();
            //Vibration.Vibrate(2000);
            //Vibration.Cancel();
            

        }
        
    }
    
}
