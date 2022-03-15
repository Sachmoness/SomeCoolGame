using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    private AudioSource _soundSource;

    private AudioClip _coinSound;

    private AudioClip _jumpSound;

    public AudioClip _deathSound;

    // Start is called before the first frame update
    void Start()
    {
        _soundSource = GetComponent<AudioSource>();
        _coinSound = Resources.Load("mixkit-unlock-game-notification-253") as AudioClip;
        _jumpSound = Resources.Load("mixkit-quick-jump-arcade-game-239") as AudioClip;
        _deathSound = Resources.Load("mixkit-failure-arcade-alert-notification-240") as AudioClip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayCoinSound(){
        _soundSource.PlayOneShot(_coinSound);
    }

    public void PlayJumpSound(){
        _soundSource.PlayOneShot(_jumpSound);
    }

     public void PlayDeathSound(){
        _soundSource.PlayOneShot(_deathSound);
    }

}
