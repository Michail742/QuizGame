using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaveInputfield : MonoBehaviour
{
    public TMP_InputField customSongText;
    string customSong;
    private void Start()
    {
        customSong = PlayerPrefs.GetString("tutorialTextKeyName");
        customSongText.text = customSong;
    }
    public void SaveSong()
    {
        customSong = customSongText.text;
        PlayerPrefs.GetString("tutorialTextKeyName", customSong);
    }
}
