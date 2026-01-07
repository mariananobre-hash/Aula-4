using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Nível 2");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
