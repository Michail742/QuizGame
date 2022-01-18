using AndroidNativeCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class Android : MonoBehaviour {

    
    private long[] vibratePattren = {0,100,1000 };
   

    public void vibrate()
    {
        Vibrator.Vibrate(500);
    }
    public void vibratorPattren()
    {
        Vibrator.Vibrate(vibratePattren,0);
    }
    public void vibrateCansel()
    {
        Vibrator.Cansel();
    }

   
}
