using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class AddSongs : MonoBehaviour
{
    TouchScreenKeyboard keyboard;

    void OpenKeyboard()
    {
        keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, true, false, false, false);
    }
}
