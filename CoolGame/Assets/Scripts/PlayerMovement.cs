using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private bool _aPressed, _dPressed, _spacePressed; // keeping track of which key is pressed

    private bool _grounded; // keep track of whether player is in the air or on a platform
    private Rigidbody2D _playerBody;

    private const float _jumpHeight = 7.0f;
    private const float _movementSpeed = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        _playerBody =  GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        GetUserInput();
        Jump();
    }

    void FixedUpdate() {
        if(_aPressed){
            _playerBody.AddForce(Vector2.left * _movementSpeed * Time.fixedDeltaTime, ForceMode2D.Impulse);
        }

        if(_dPressed){
            _playerBody.AddForce(Vector2.right * _movementSpeed * Time.fixedDeltaTime, ForceMode2D.Impulse);
        }

    }

    void GetUserInput(){
        if(Input.GetKey(KeyCode.A)){ // detect A key being held down
            _aPressed = true;
        }
        else{
            _aPressed = false;
        }

        if(Input.GetKey(KeyCode.D)){ // detect D key being held down
            _dPressed = true;
        }
        else{
            _dPressed = false;
        } 
    }

    void Jump(){

        if(Input.GetKeyUp(KeyCode.Space)){ // detect spacebar being pressed and released
            _spacePressed = true;
        }
        else{
            _spacePressed = false;
        }

        if(_spacePressed && _grounded){ // Jump
            _playerBody.AddForce(Vector2.up * _jumpHeight, ForceMode2D.Impulse);
            gameObject.GetComponent<ColourSwitch>().Switch();
            EventHandler.PlayerJumped();
        }  
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Platform"){
            _grounded = true;
        }    
    }

   private void OnCollisionExit2D(Collision2D other) {
       if(other.gameObject.tag == "Platform"){
            _grounded = false;
        } 
   }
}
