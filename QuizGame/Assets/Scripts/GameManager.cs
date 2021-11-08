using UnityEngine;
using Random = UnityEngine.Random;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    //RandomSongs
    public TextMeshProUGUI myText;

    //CustomSongs
    public Button addsong;
    public Canvas canvas;
    public TMP_InputField songtext;
    public string[] songs;
    public int currentIndex; //This keeps track of the index

    //Countdown
    float currentTime = 0f;
    float startingTime = 10f;
    [SerializeField]
    TextMeshProUGUI countdownText;

    //ScoreSystem
    public int score;
    public TextMeshProUGUI scoreText;

    void Start(){
        //CustomSongs
        addsong = addsong.GetComponent<Button>();
        canvas = canvas.GetComponent<Canvas>();
        songtext = songtext.GetComponent<TMP_InputField>();
        songs = new string[100];
        currentIndex = 0; //Make sure we start at 0
        //Countdown
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update(){
        //Countdown

        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");


        if (currentTime <= 0)
        {
            currentTime = 0;

            Vibrator.Vibrate(250);
        }
        //CustomSongs

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

        

        //ExitApp
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();

        //ScoreSystem
        scoreText.text = score.ToString();
    }
    public void BtnAction(){
        PickRandomSong();
    }
    public void PickRandomSong(){
        string[] songs = new string[] { "snik", "light", "mad clip", "lex", "toquel", "hawk", "immune", "rack", "fly lo", "bob marley" };
        string randomSong = songs[Random.Range(0, songs.Length)];
        myText.text = randomSong;

    }
    public void AddScore(){
        score++;
    }
    //SceneManagement
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
