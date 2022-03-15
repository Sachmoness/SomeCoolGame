using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    int currentLevel;
    // Start is called before the first frame update
    void Start()
    {
        currentLevel = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){  // close game Esc key
            ExitGame();
        }
    }

    public void NextLevel(){ // load next scene in build
        SceneManager.LoadScene(currentLevel+1);
    }

    public void OpenMainMenu(){  // load menu scene
         SceneManager.LoadScene("Menu");
    }
 
    public void OpenHelp(){ // load help scene
        SceneManager.LoadScene("Help");
    }

    void ExitGame(){ // quit application
        Application.Quit();
    }
}
