using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    private AudioSource _soundSource;

    private AudioClip _coinSound;

    private AudioClip _jumpSound;

    // Start is called before the first frame update
    void Start()
    {
        _soundSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
