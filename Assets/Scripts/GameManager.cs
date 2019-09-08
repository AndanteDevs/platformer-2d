using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    void Update()
    {
        if ( Input.GetButton("Cancel") )
        {
            ResetToMenu();
        }

        if (Input.GetKey("r"))
        {
            ResetScene();
        }
    }

    public void StartGame()
    {
        Debug.Log("Starting game...");
        LoadNextScene();
        Debug.Log("Game started");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
        Debug.Log("Game quit");
    }

    void LoadNextScene()
    {
        Debug.Log("Loading next scene in sequence...");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void ResetToMenu()
    {
        Debug.Log("Unloading " + SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("menu");
    }

    public void ResetScene()
    {
        Debug.Log("Resetting " + SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log(SceneManager.GetActiveScene().name + " reset");
    }

}
