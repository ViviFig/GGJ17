using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    #region AudioClipRegion
    AudioSource audioSource;
    public AudioClip BonusTaken;
    public AudioClip Crawling;
    public AudioClip Walking;
    public AudioClip Throwing;
    public AudioClip Jumping;
    public AudioClip LevelEnd;
    public AudioClip HudHeartBeat;
    public AudioClip LevelBackGround;
    public AudioClip MainMenu;
    public AudioClip Pushing;
    public AudioClip TrapStart;
    public AudioClip Impact;
    public AudioClip ScanSouns;
    public AudioClip Death;
    #endregion
    public Sounds DefaultSound; 
    
    void Awake()
    {
        #region Iscrizione Eventi
        GameManager.instance.OnBonusTaken += HandleOnBonusTaken;//Musica quando prende i Cuori
        GameManager.instance.OnCrawling += HandleOnCrawling;//Suono mentre striscia
        GameManager.instance.OnWalking += HandleOnWalking;//Suono mentre Cammina
        GameManager.instance.OnThrowing += HandleOnThrowing;//Suono quando lancia un oggetto
        GameManager.instance.OnJumping += HandleOnJumping;//Suono mentre Salta
        GameManager.instance.OnLevelEnd += HandleOnLevelEnd;//Musica di fine gioco
        GameManager.instance.OnHudHeartBeat += HandleOnHudHeartBeat;//Suono del 
        GameManager.instance.OnLevelBackGround += HandleLevelBackGround;//Suono mentre Cammina
        GameManager.instance.OnMainMenu += HandleMainMenu;//Suono quando lancia un oggetto
        GameManager.instance.OnPushing += HandlePushing;//Suono mentre Salta
        GameManager.instance.OnTrapStart += HandleOnTrapStart;//Suono del battitoCardiaco
        GameManager.instance.OnImpact += HandleOnImpact;// Suono dell'impatto 
        #endregion


    }

    #region HandleRegion
    void HandleOnCrawling()
    {
        PlaySound(Sounds.Crawling);
    }

    void HandleOnWalking()
    {
        PlaySound(Sounds.Walking);
    }

    void HandleOnThrowing()
    {
        PlaySound(Sounds.Throwing);
    }

    void HandleOnJumping()
    {
        PlaySound(Sounds.Jumping);
    }

    void HandleOnLevelEnd()
    {
        PlaySound(Sounds.LevelEnd);
    }

    void HandleOnHudHeartBeat()
    {
        PlaySound(Sounds.HudHeartBeat);
    }

    void HandleLevelBackGround()
    {
        PlaySound(Sounds.LevelBackGround);
    }

    void HandleMainMenu()
    {
        PlaySound(Sounds.MainMenu);
    }

    void HandlePushing()
    {
        PlaySound(Sounds.Pushing);
    }

    void HandleOnTrapStart()
    {
        PlaySound(Sounds.TrapStart);
    }

    void HandleOnImpact()
    {
        PlaySound(Sounds.Impact);
    }

    void HandleOnBonusTaken()
    {
        PlaySound(Sounds.BonusTaken);
    } 
    #endregion




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
            case Sounds.TrapStart:
                audioSource.clip = TrapStart;
                break;
            case Sounds.Impact:
                audioSource.clip = Impact;
                break;
            case Sounds.Death:
                audioSource.clip = Death;
                break;
        }

        audioSource.Play();
    }
}
    public enum Sounds
    {
        Crawling,
        Walking,
        Throwing,
        Jumping,
        LevelEnd,
        BonusTaken,
        HudHeartBeat,
        LevelBackGround,
        MainMenu,
        Pushing,
        TrapStart,
        Impact,
        Death
}


