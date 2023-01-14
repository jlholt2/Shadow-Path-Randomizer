// Shadow Race Path Decider
// Code written by Zwataketa (Logan Holt)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundManager : MonoBehaviour
{
    public Color chromaKeyColor;

    public Image bgImageComponent;

    public Sprite[] bgImages;

    public void ChangeBG(int val)
    {
        try
        {
            switch (val)
            {
                case 0:
                    bgImageComponent.sprite = null;
                    bgImageComponent.color = chromaKeyColor;
                    break;
                default:
                    bgImageComponent.sprite = bgImages[val-1];
                    bgImageComponent.color = Color.white;
                    break;
            }
        }
        catch
        {
            Debug.LogError("Caught Error: BG image not found at index "+(val-1)+"!");
        }
    }
}
