using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class RandomSongs : MonoBehaviour
{
    public TextMeshProUGUI myText;

    public void BtnAction()
    {
        PickRandomSong();
    }
    private void PickRandomSong()
    {
        string[] songs = new string[] { "snik", "light", "mad clip", "lex", "toquel" };
        string randomSong = songs[Random.Range(0, songs.Length)];
        myText.text = randomSong;
        
    }
}
