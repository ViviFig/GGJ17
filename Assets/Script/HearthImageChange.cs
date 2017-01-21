using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HearthImageChange : MonoBehaviour {

   [HideInInspector] public Image BackgroundSprite;
    public HearthImage ActualHearthImage;//TODO   [HideInInspector] 

    public void OnHearthTaken()
    {
        switch (ActualHearthImage)
        {
            case HearthImage.Empty:
                BackgroundSprite.sprite = Resources.Load<Sprite>("Empty");
                break;
            case HearthImage.Incomplete:
                BackgroundSprite.sprite = Resources.Load<Sprite>("Incomplete");
                break;
            case HearthImage.Half:
                BackgroundSprite.sprite = Resources.Load<Sprite>("Half");
                break;
            case HearthImage.Full:
                BackgroundSprite.sprite = Resources.Load<Sprite>("Full");
                break;
            default:
                break;
        }
    }
    
}
public enum HearthImage{
    Empty,
    Incomplete,
    Half,
    Full
}
