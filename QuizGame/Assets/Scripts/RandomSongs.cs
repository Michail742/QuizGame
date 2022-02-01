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
        string[] songs = new string[] { "snik \n seniorita", "light", "mad clip", "lex", "toquel", "hawk", "immune", "rack", "fly lo", "bob marley \n get up stand up" };
        string randomSong = songs[Random.Range(0, songs.Length)];
        myText.text = randomSong;

    }
}


