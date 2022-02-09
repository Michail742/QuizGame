using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CustomSongs : MonoBehaviour
{
    public Button addsong;
    public Canvas can;
    public TMP_InputField songtext;
    public TMP_InputField artisttext;
    public string[] songs;
    public int currentIndex; //This keeps track of the index

    public void Start()
    {
        
        songs = new string[100];
        currentIndex = 0; //Make sure we start at 0
    }

    public void CustomSong()
    {
        //With each click of the button the song in the inputfield is added to the array
        songs[currentIndex] = songtext.text; //Add the word at the current index

        if (currentIndex < 9)
        {
            currentIndex++; //Increase the index to the next position in the array
        }
        else
        {
            //Change this code to handle the full array
            currentIndex = 0; //Reset back to 0 and start filling the array from the start
        }
    }
}
