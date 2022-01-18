using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;
    
    void Update()
    {
        scoreText.text = score.ToString();
    }
    public void AddScore()
    {
        score++;
    }
    public void MinusScore()
    {
        score--;
    }
}
