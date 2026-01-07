using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Aula 2");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Jogo fechado"); 
    }
}
