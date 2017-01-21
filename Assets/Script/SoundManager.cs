using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    AudioSource audioSource;
    public AudioClip BonusTaken;
    public AudioClip Crawling;
    public AudioClip Walking;
    public AudioClip Throwing;
    public AudioClip Jumping;
    public AudioClip LevelEnd;
    public AudioClip HudHeartBeat;
    public AudioClip OnPlayLevel;
    public AudioClip LevelBackGround;
    public AudioClip MainMenu;
    public AudioClip Pushing;
    public AudioClip OnTrap;
    public Sounds DefaultSound;

    void Awake()
    {
        GameManager.instance.OnLevelEnd += OnLevelEnd;// Music per la fine del livello
        GameManager.instance.OnGameWin += HandleOnGameWin;// Musica di fine Livello
        GameManager.instance.OnPlayLevel += HandleOnPLayLevel;//Enviromen Music
        GameManager.instance.OnBonusTaken += HandleOnBonusTaken;//Musica quando prende i Cuori
    }

    void HandleOnPLayLevel() {
    }
    void HandleOnBonusTaken()
    {
        PlaySound(Sounds.LevelBackGround);
    }

    void HandleOnGameWin()
    {
        PlaySound(Sounds.LevelEnd);
    }

    void OnLevelEnd()
    {
        PlaySound(Sounds.Jumping);
    }


    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        PlaySound(DefaultSound);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlaySound(Sounds _soundToPlay)
    {
        switch (_soundToPlay)
        {
            case Sounds.Crawling:
                audioSource.clip = Crawling;
                break;
            case Sounds.Walking:
                audioSource.clip = Walking;
                break;
            case Sounds.Throwing:
                audioSource.clip = Throwing;
                break;
            case Sounds.Jumping:
                audioSource.clip = Jumping;
                break;
            case Sounds.LevelEnd:
                audioSource.clip = LevelEnd;
                break;
            case Sounds.BonusTaken:
                audioSource.clip = BonusTaken;
                break;
            case Sounds.HudHeartBeat:
                audioSource.clip = HudHeartBeat;
                break;
            case Sounds.LevelBackGround:
                audioSource.clip = LevelBackGround;
                break;
            case Sounds.MainMenu:
                audioSource.clip = MainMenu;
                break;
            case Sounds.Pushing:
                audioSource.clip = Pushing;
                break;
            case Sounds.OnTrap:
                audioSource.clip = OnTrap;
                break;
        }

        audioSource.Play();
    }
}
    public enum Sounds
    {
        Crawling,//  
        Walking,
        Throwing,
        Jumping,
        LevelEnd,
        BonusTaken,
        HudHeartBeat,
        LevelBackGround,
        MainMenu,
        Pushing,
        OnTrap
    }


