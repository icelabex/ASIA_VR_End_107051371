using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
   public void RestartGame()
    {
        SceneManager.LoadScene("Stage");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
