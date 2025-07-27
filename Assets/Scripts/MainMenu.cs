using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LevelSelect()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void ToMainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void Level1()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void Level2()
    {
        SceneManager.LoadSceneAsync(5);
    }

    public void Level1Load()
    {
        SceneManager.LoadSceneAsync(6);
    }

}
