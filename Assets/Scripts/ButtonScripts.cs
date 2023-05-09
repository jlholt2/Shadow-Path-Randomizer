// Shadow Race Path Decider
// Code written by Zwataketa (Logan Holt)

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
    [SerializeField] TMP_Dropdown langDropdown;
    [SerializeField] Toggle hideToggle;

    [SerializeField] Image[] uiToHide;

    void Start()
    {
        optionsPanel.SetActive(false);
        OnBGDropdownValueChanged();
        OnSoundDropdownValueChanged();
    }

    private void Update()
    {
        if (!optionsPanel.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.N))
            {
                OnClickNewStagePathButton();
            }
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            optionsPanel.SetActive(!optionsPanel.activeInHierarchy);
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            hideToggle.isOn = !hideToggle.isOn;
            OnHideButtonsToggleChange();
        }

    }

    public void OnHideButtonsToggleChange()
    {
        HideButtonFunction(!hideToggle.isOn);
    }

    private void HideButtonFunction(bool turnOn)
    {
        for (int i = 0; i < uiToHide.Length; i++)
        {
            float alphaVal = 1;
            if (!turnOn)
            {
                alphaVal = 0;
            }

            uiToHide[i].enabled = turnOn;
            uiToHide[i].color = new Color(1, 1, 1, alphaVal);
            uiToHide[i].GetComponent<Button>().interactable = turnOn;
            if (uiToHide[i].GetComponentInChildren<TextMeshProUGUI>())
            {
                Color textColor = uiToHide[i].GetComponentInChildren<TextMeshProUGUI>().color;

                uiToHide[i].GetComponentInChildren<TextMeshProUGUI>().color = new Color(1, 1, 1, alphaVal);
            }
        }
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
    public void OnLanguageDropdownValueChanged()
    {
        // update language files for dict
    }
}
