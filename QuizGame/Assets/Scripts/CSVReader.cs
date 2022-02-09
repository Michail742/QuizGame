using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CSVReader : MonoBehaviour
{
    List<Songs> songsList = new List<Songs>();
    void Start()
    {
        TextAsset SongList = Resources.Load<TextAsset>("SongList");
        string[] data = SongList.text.Split(new char[] { '\n'});

        for (int i = 1; i< data.Length; i++)
        {
            string[] row  = data[i].Split(new char[] { ',' });
            Songs songs = new Songs();
            songs.artist = row[0];
            songs.songs = row[1];

            songsList.Add(songs);
        }
        foreach(Songs songs in songsList)
        {
            Debug.Log(songs.artist +"-"+ songs.songs);
        }
    }
   
    
}
