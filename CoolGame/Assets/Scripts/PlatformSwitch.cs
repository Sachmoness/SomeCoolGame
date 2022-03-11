using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSwitch : MonoBehaviour
{
    private BoxCollider2D platformCollider;
    // Start is called before the first frame update
    void Start()
    {
        platformCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable() {
        EventHandler.PlayerJumped += DisableCollider;
    }

    private void OnDisable() {
        EventHandler.PlayerJumped -= DisableCollider;
    }

    void DisableCollider(){
        platformCollider.isTrigger = true;
    }
}
