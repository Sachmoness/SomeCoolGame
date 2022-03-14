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
        if(Input.GetKeyDown(KeyCode.Escape)){
            ExitGame();
        }
    }

    public void NextLevel(){
        SceneManager.LoadScene(currentLevel+1);
    }

    void ExitGame(){
        Application.Quit();
    }
}
