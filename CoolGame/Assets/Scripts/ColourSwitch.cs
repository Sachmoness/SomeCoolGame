using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourSwitch : MonoBehaviour
{
    private SpriteRenderer objectSprite;

    public bool isRed, isBlue;
    // Start is called before the first frame update
    void Start()
    {
        objectSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        setColour();
    }

    public void Switch(){
        if(isRed){
            isBlue = true;
            isRed = false;
        }
        else if(isBlue){
            isRed = true;
            isBlue = false;
        }
       
    }

    void setColour(){
        if(isRed){
            objectSprite.color = Color.red;
        }
        else if(isBlue){
            objectSprite.color = Color.blue;
        }
    }
}
