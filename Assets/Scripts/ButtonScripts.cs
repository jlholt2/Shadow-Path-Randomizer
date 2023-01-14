// Shadow Race Path Decider
// Code written by Zwataketa (Logan Holt)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonScripts : MonoBehaviour
{
    [SerializeField] Stagemap stagemap;
    [SerializeField] BackgroundManager backgroundManager;
    [SerializeField] SoundManager soundManager;
    [SerializeField] GameObject optionsPanel;
    [SerializeField] TMP_Dropdown bgDropdown;
    [SerializeField] TMP_Dropdown sndDropdown;

    void Start()
    {
        optionsPanel.SetActive(false);
        OnBGDropdownValueChanged();
        OnSoundDropdownValueChanged();
    }

    public void OnClickNewStagePathButton()
    {
        stagemap.NewStagePath();
    }

    public void OnClickOptionsBackButton()
    {
        optionsPanel.SetActive(false);
    }

    public void OnClickOptionsButton()
    {
        optionsPanel.SetActive(true);
    }

    public void OnClickExitButton()
    {
        //Debug.Log("Quit");
        Application.Quit();
    }

    public void OnBGDropdownValueChanged()
    {
        backgroundManager.ChangeBG(bgDropdown.value);
    }
    public void OnSoundDropdownValueChanged()
    {
        soundManager.UpdateAudioClip(sndDropdown.value);
    }
}
