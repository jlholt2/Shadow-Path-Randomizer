// Shadow Race Path Decider
// Code written by Zwataketa (Logan Holt)

//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Stagemap : MonoBehaviour
{
    [SerializeField] string stagePath = "";
    [SerializeField] string alignmentPath = "";
    [SerializeField] AudioSource buttonSound;

    [SerializeField] Sprite[] cellImages;

    [SerializeField] Color[] stageColors;

    [SerializeField] Image stage1Cell;
    [SerializeField] Image[] stage2Cells;
    [SerializeField] Image[] stage3Cells;
    [SerializeField] Image[] stage4Cells;
    [SerializeField] Image[] stage5Cells;
    [SerializeField] Image[] stage6Cells;

    int lastUsedCellImage = -1;
    int lastLastUsedCellImage = -1;
    int alignmentVal = 0;
    int stageNum = 0;

    public PathNameSelector pathNameSelector;

    void Start()
    {
        GameObject.Find("PathNameText").GetComponent<TextMeshProUGUI>().text = "";
        pathNameSelector = new PathNameSelector();
        RandomizeCellImages();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            UpdateBoard();
        }
    }

    void PlayButtonSound()
    {
        buttonSound.Play();
    }

    void RandomizeCellImages()
    {
        stage1Cell.sprite = cellImages[SelectCellImage()];
        for (int i = 0; i < stage2Cells.Length; i++)
        {
            stage2Cells[i].sprite = cellImages[SelectCellImage()];
        }
        for (int i = 0; i < stage3Cells.Length; i++)
        {
            stage3Cells[i].sprite = cellImages[SelectCellImage()];
        }
        for (int i = 0; i < stage4Cells.Length; i++)
        {
            stage4Cells[i].sprite = cellImages[SelectCellImage()];
        }
        for (int i = 0; i < stage5Cells.Length; i++)
        {
            stage5Cells[i].sprite = cellImages[SelectCellImage()];
        }
        for (int i = 0; i < stage6Cells.Length; i++)
        {
            stage6Cells[i].sprite = cellImages[SelectCellImage()];
        }
    }

    int SelectCellImage() 
    {
        int chosenVal = Random.Range(0, cellImages.Length);
        //int iteration = 0;
        if(cellImages.Length > 1)
        {
            while ((chosenVal == lastUsedCellImage || chosenVal == lastLastUsedCellImage)/* && iteration < 30*/)
            {
                chosenVal = Random.Range(0, cellImages.Length);
                //iteration++;
            }
        }
        lastLastUsedCellImage = lastUsedCellImage;
        lastUsedCellImage = chosenVal;
        return chosenVal;
    }

    public void NewStagePath()
    {
        PlayButtonSound();
        stagePath = GetStagePath();
        UpdateBoard();
    }

    public void UpdateBoard()
    {
        int pathID = pathNameSelector.GetPathID(stagePath);

        GameObject.Find("PathNameText").GetComponent<TextMeshProUGUI>().text = pathID.ToString("000")+". "+pathNameSelector.pathStrings[pathID];
        GetAlignmentMap();
        DrawStagePath();
    }

    public void DrawStagePath()
    {
        ClearStagePath();

        for (int i = 0; i < stagePath.Length; i++)
        {
            switch (stagePath[i])
            {
                case 'D':
                    if (i == 0)
                    {
                        stage1Cell.color = stageColors[2];
                    }
                    else if(i == 1)
                    {
                        stage2Cells[int.Parse(alignmentPath[i-1].ToString())].color = stageColors[2];
                    }
                    else if (i == 2)
                    {
                        stage3Cells[int.Parse(alignmentPath[i - 1].ToString())].color = stageColors[2];
                    }
                    else if (i == 3)
                    {
                        stage4Cells[int.Parse(alignmentPath[i - 1].ToString())].color = stageColors[2];
                    }
                    else if (i == 4)
                    {
                        stage5Cells[int.Parse(alignmentPath[i - 1].ToString())].color = stageColors[2];
                    }
                    else if (i == 5)
                    {
                        stage6Cells[int.Parse(alignmentPath[i - 1].ToString())].color = stageColors[2];
                    }
                    break;
                case 'H':
                    if (i == 0)
                    {
                        stage1Cell.color = stageColors[3];
                    }
                    else if (i == 1)
                    {
                        stage2Cells[int.Parse(alignmentPath[i - 1].ToString())].color = stageColors[3];
                    }
                    else if (i == 2)
                    {
                        stage3Cells[int.Parse(alignmentPath[i - 1].ToString())].color = stageColors[3];
                    }
                    else if (i == 3)
                    {
                        stage4Cells[int.Parse(alignmentPath[i - 1].ToString())].color = stageColors[3];
                    }
                    else if (i == 4)
                    {
                        stage5Cells[int.Parse(alignmentPath[i - 1].ToString())].color = stageColors[3];
                    }
                    else if (i == 5)
                    {
                        stage6Cells[int.Parse(alignmentPath[i - 1].ToString())].color = stageColors[3];
                    }
                    break;
                default:
                    if (i == 0)
                    {
                        stage1Cell.color = stageColors[1];
                    }
                    else if (i == 1)
                    {
                        stage2Cells[int.Parse(alignmentPath[i - 1].ToString())].color = stageColors[1];
                    }
                    else if (i == 2)
                    {
                        stage3Cells[int.Parse(alignmentPath[i - 1].ToString())].color = stageColors[1];
                    }
                    else if (i == 3)
                    {
                        stage4Cells[int.Parse(alignmentPath[i - 1].ToString())].color = stageColors[1];
                    }
                    else if (i == 4)
                    {
                        stage5Cells[int.Parse(alignmentPath[i - 1].ToString())].color = stageColors[1];
                    }
                    else if (i == 5)
                    {
                        stage6Cells[int.Parse(alignmentPath[i - 1].ToString())].color = stageColors[1];
                    }
                    break;
            }
        }
    }

    public void ClearStagePath()
    {
        stage1Cell.color = stageColors[0];
        for (int i = 0; i < 5; i++)
        {
            if(i < 3)
            {
                stage2Cells[i].color = stageColors[0];
                stage3Cells[i].color = stageColors[0];
            }
            stage4Cells[i].color = stageColors[0];
            stage5Cells[i].color = stageColors[0];
            stage6Cells[i].color = stageColors[0];
        }
    }

    string GetStagePath()
    {
        string newStagePath = "";
        alignmentVal = 0;
        for (stageNum = 0; stageNum < 6; stageNum++)
        {
            if(stageNum > 1)
            {
                newStagePath += CheckMission(-2, 2);
            }
            else
            {
                newStagePath += CheckMission(-1, 1);
            }
        }
        return newStagePath;
    }

    char CheckMission(int min, int max)
    {
        char returnMission = MissionSelect();
        alignmentVal = Mathf.Clamp(alignmentVal, min, max);
        if(alignmentVal >= max)
        {
            while(returnMission == 'N' && stageNum != 4 || returnMission == 'H' && stageNum == 4)
            {
                returnMission = MissionSelect();
            }
        }
        else if (alignmentVal <= min)
        {
            while (returnMission == 'N' && stageNum != 4 || returnMission == 'D' && stageNum == 4)
            {
                returnMission = MissionSelect();
            }
        }
        while(stageNum == 5 && returnMission == 'N')
        {
            returnMission = MissionSelect();
        }
        if(returnMission == 'D' && alignmentVal < max || stageNum == 4 && alignmentVal <= min && returnMission == 'N')
        {
            alignmentVal++;
        }
        else if (returnMission == 'H' && alignmentVal > min || stageNum == 4 && alignmentVal >= max && returnMission == 'N')
        {
            alignmentVal--;
        }
        return returnMission;
    }

    char MissionSelect()
    {
        switch (Random.Range(0, 3))
        {
            case 0:
                return 'D';
            case 1:
                return 'H';
            default:
                return 'N';
        }
    }

    void GetAlignmentMap()
    {
        /// IMPORTANT! Make sure The Ark and Lost Impact's Neutral Missions path properly


        alignmentPath = "";

        try
        {
            switch (stagePath[0])
            {
                case 'D':
                    alignmentPath += '2';
                    break;
                case 'H':
                    alignmentPath += '0';
                    break;
                default:
                    alignmentPath += '1';
                    break;
            }
            switch (stagePath[1])
            {
                case 'D':
                    if (alignmentPath[alignmentPath.Length - 1] == '2' || alignmentPath[alignmentPath.Length - 1] == '1')
                    {
                        alignmentPath += '2';
                    }
                    else
                    {
                        alignmentPath += '1';
                    }
                    break;
                case 'H':
                    if (alignmentPath[alignmentPath.Length - 1] == '0' || alignmentPath[alignmentPath.Length - 1] == '1')
                    {
                        alignmentPath += '0';
                    }
                    else
                    {
                        alignmentPath += '1';
                    }
                    break;
                default:
                    alignmentPath += '1';
                    break;
            }

            switch (stagePath[2])
            {
                case 'D':
                    alignmentPath += (int.Parse(alignmentPath[alignmentPath.Length - 1].ToString()) + 2).ToString();
                    break;
                case 'H':
                    alignmentPath += (int.Parse(alignmentPath[alignmentPath.Length - 1].ToString())).ToString();
                    break;
                default:
                    alignmentPath += (int.Parse(alignmentPath[alignmentPath.Length - 1].ToString()) + 1).ToString();
                    break;
            }

            for (int i = 3; i < 5; i++)
            {
                switch (stagePath[i])
                {
                    case 'D':
                        if (int.Parse(alignmentPath[i - 1].ToString()) > 2)
                        {
                            alignmentPath += '4';
                        }
                        else if (int.Parse(alignmentPath[i - 1].ToString()) <= 2)
                        {
                            alignmentPath += (int.Parse(alignmentPath[i - 1].ToString()) + 1).ToString();
                        }
                        break;
                    case 'H':
                        if (int.Parse(alignmentPath[i - 1].ToString()) < 2)
                        {
                            alignmentPath += '0';
                        }
                        else if (int.Parse(alignmentPath[i - 1].ToString()) >= 2)
                        {
                            alignmentPath += (int.Parse(alignmentPath[i - 1].ToString()) - 1).ToString();
                        }
                        break;
                    default:
                        if(i == 4)
                        {
                            if (int.Parse(alignmentPath[i - 1].ToString()) >= 4)
                            {
                                alignmentPath += (int.Parse(alignmentPath[i - 1].ToString()) - 1).ToString();
                            }
                            else if (int.Parse(alignmentPath[i - 1].ToString()) <= 0)
                            {
                                alignmentPath += (int.Parse(alignmentPath[i - 1].ToString()) + 1).ToString();
                            }
                            else
                            {
                                alignmentPath += alignmentPath[i - 1];
                            }
                        }
                        else
                        {
                            alignmentPath += alignmentPath[i - 1];
                        }
                        break;
                }
            }
        }
        catch
        {
            GameObject.Find("PathNameText").GetComponent<TextMeshProUGUI>().text = "ERROR: Bad Path loaded!";
        }
    }
}
