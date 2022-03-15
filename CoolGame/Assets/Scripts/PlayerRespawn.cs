using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    private GameObject _spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        _spawnPoint = GameObject.FindGameObjectWithTag("Respawn");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Fall"){ // if player fall off platforms respawn them at start
            transform.position = _spawnPoint.transform.position;
            EventHandler.PlayerFell();
        }
    }
}
