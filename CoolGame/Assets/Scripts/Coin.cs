using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate() {
        Spin(); // rotate "coin" 
    }

    void Spin(){
        transform.Rotate(0f,2f,0f,Space.World);
    }
}
