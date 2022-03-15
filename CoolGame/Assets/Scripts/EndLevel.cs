using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{

    private GameObject _gameManager;

    IEnumerator NextLevel() // coroutine to delay loading of next level so sound can finish playing
    {
        yield return new WaitForSeconds(0.3f);
        _gameManager.GetComponent<GameManagement>().NextLevel();
    }


    // Start is called before the first frame update
    void Start()
    {
        _gameManager = GameObject.FindGameObjectWithTag("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Coin"){
            EventHandler.CoinReached();
            StartCoroutine("NextLevel");
        }
    }
}
