using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuScreen;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
                SceneManager.LoadScene(1);

    }

    private void Awake()
    {
    }

    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }

    public void Restart()
    {
        SceneManager.LoadScene(2);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    
    public void Quit()  
    {
        Application.Quit(); // only for build
    }

}
