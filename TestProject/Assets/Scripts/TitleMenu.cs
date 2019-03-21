using UnityEngine;
using UnityEngine.SceneManagement;


public class TitleMenu : MonoBehaviour
{
    [SerializeField]
    private string gameSceneName;

    public void LoadGameScene()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    public void ExitScene()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}
