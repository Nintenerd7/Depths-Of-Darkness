using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class FrameRate : MonoBehaviour
{
    public TMP_Dropdown FPS_DropDown, Quality_Dropdown;
    private void Awake()
    {
        
        if (PlayerPrefs.HasKey("FrameSettings"))
        {
            LoadFrames();
        }
        else
        {
            FramesChanged(0);
            Quality(0);
        }
    }
    public void FramesChanged(int FrameIndex)
    {
        switch (FrameIndex)
        {
            case 0: Application.targetFrameRate = 60; ; break;
            case 1: Application.targetFrameRate = 30;break;
            case 2: Application.targetFrameRate = 15;break;
        }
      PlayerPrefs.SetInt("FrameSettings", FrameIndex);
    }
    public void LoadFrames()
    {
        FPS_DropDown.value = PlayerPrefs.GetInt("FrameSettings");
        Quality_Dropdown.value = PlayerPrefs.GetInt("QualitySettings");
    }

    public void Quality(int QualityIndex)
    {
        QualitySettings.SetQualityLevel(QualityIndex);//sets quality of the graphics
        PlayerPrefs.SetInt("QualitySettings", QualityIndex);
    }
}
