using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private bool _aPressed, _dPressed, _spacePressed; // keeping track of which key is pressed
    private Rigidbody2D _playerBody;

    private const float _jumpHeight = 2.0f;
    private const float _movementSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        _playerBody =  GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        GetUserInput();
    }

    void FixedUpdate() {
        if(_aPressed){
            _playerBody.MovePosition(transform.position + Vector3.left * Time.fixedDeltaTime * _movementSpeed);
        }

        if(_dPressed){
            _playerBody.MovePosition(transform.position + Vector3.right * Time.fixedDeltaTime * _movementSpeed);
        }

        if(_spacePressed){
            _playerBody.AddForce(Vector2.up * _jumpHeight, ForceMode2D.Impulse);
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

         if(Input.GetKey(KeyCode.Space)){ // detect spacebar being pressed
            _spacePressed = true;
        }
        else{
            _spacePressed = false;
        }
    }
}