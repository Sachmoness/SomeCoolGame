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
        _coinSound = Resources.Load("mixkit-unlock-game-notification-253") as AudioClip; //load sounds from resource folder
        _jumpSound = Resources.Load("mixkit-quick-jump-arcade-game-239") as AudioClip;
        _deathSound = Resources.Load("mixkit-failure-arcade-alert-notification-240") as AudioClip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable() { // listen for events indicating a sound need to be played.
        EventHandler.PlayerFell += PlayDeathSound;
        EventHandler.CoinReached += PlayCoinSound;
        EventHandler.PlayerJumped += PlayJumpSound;
    }

    private void OnDisable() {
        EventHandler.PlayerFell -= PlayDeathSound;
        EventHandler.CoinReached -= PlayCoinSound;
        EventHandler.PlayerJumped -= PlayJumpSound;
    }

    // Methods for playing audioclips:
    
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
