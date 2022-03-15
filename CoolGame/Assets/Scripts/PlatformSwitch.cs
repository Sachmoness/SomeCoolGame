using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSwitch : MonoBehaviour
{
    private BoxCollider2D platformCollider;
    public bool isRed;
    public bool isBlue;
    // Start is called before the first frame update
    void Start()
    {
        platformCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable() {  // Listen for events, turn red/blue platform colliders on/off depending on player colour.
        if(isRed){
            EventHandler.PlayerRed += EnableCollider;
            EventHandler.PlayerBlue += DisableCollider;
        }
        else if(isBlue){
            EventHandler.PlayerBlue += EnableCollider;
            EventHandler.PlayerRed += DisableCollider;
        }
    }

    private void OnDisable() {
           if(isRed){
            EventHandler.PlayerRed -= EnableCollider;
            EventHandler.PlayerBlue -= DisableCollider;
        }
        else if(isBlue){
            EventHandler.PlayerBlue -= EnableCollider;
            EventHandler.PlayerRed -= DisableCollider;
        }
    }

    void DisableCollider(){  // turn box collider off
        platformCollider.isTrigger = true;
    }

    void EnableCollider(){ // turn box collider on
        platformCollider.isTrigger = false;
    }
}
