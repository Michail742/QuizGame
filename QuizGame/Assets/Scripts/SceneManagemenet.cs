using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagemenet : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
