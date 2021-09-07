using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class AddSongs : MonoBehaviour
{
    public string stringToEdit = "Hello World";
    private TouchScreenKeyboard keyboard;

    // Opens native keyboard
    void OnGUI()
    {
        stringToEdit = GUI.TextField(new Rect(100, 100, 200, 300), stringToEdit, 300);

        if (GUI.Button(new Rect(10, 50, 200, 100), "Default"))
        {
            keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
        }
        if (GUI.Button(new Rect(10, 150, 200, 100), "ASCIICapable"))
        {
            keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.ASCIICapable);
        }
        
    }
}
