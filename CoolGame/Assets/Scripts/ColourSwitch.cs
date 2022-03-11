using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourSwitch : MonoBehaviour
{
    private SpriteRenderer playerSprite;

    bool isRed, isBlue;
    // Start is called before the first frame update
    void Start()
    {
        playerSprite = GetComponent<SpriteRenderer>();
        playerSprite.color = Color.blue; 

        isBlue = true;
        isRed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Switch(){
        if(isRed){
            playerSprite.color = Color.blue; 
            isBlue = true;
            isRed = false;
        }
        else if(isBlue){
            playerSprite.color = Color.red;
            isRed = true;
            isBlue = false;
        }
       
    }
}
