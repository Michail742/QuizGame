using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;


public class RandomSongs : MonoBehaviour
{
    public TextMeshProUGUI myText;
    
    public void BtnAction()
    {
        PickRandomSong();
    }
    public void PickRandomSong()
    {
        string[] songs = new string[] { "Snik \n Seniorita", "Light", "Mad Clip", "Lex", "Toquel", "Hawk", "Immune", "Rack", "Fly Lo", "Bob Marley \n Get Up Stand Up" };
        string randomSong = songs[Random.Range(0, songs.Length)];
        myText.text = randomSong;

    }
}


