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
        string[] songs = new string[] { "snik", "light", "mad clip", "lex", "toquel", "hawk", "immune", "rack", "fly lo", "bob marley" };
        string randomSong = songs[Random.Range(0, songs.Length)];
        myText.text = randomSong;
        
    }
}
