using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementObject : MonoBehaviour
{
    [Header("Achievement Details")]
    [SerializeField] string hash; //Unique identifier for this achievement
    [SerializeField] float progress = 0; //Range from 1 - 200 //100 indicates a level 2 medal

    [Header("UI Objects")]
    [SerializeField] Image medal; //A medal to indicate the level of progress
    [SerializeField] Image maskedImage; //To show the progress
    [SerializeField] Sprite medal2; //The Level 2 Medal

    public void CheckProgress()
    {
        if(PlayerPrefs.HasKey(hash) != true) //Achievement has not been registered!
        {
            SaveAchievement();
        }

        progress = PlayerPrefs.GetFloat(hash + "_progress"); //Retrieve the progress
    }

    public void SaveAchievement()
    {
        PlayerPrefs.SetFloat(hash + "_progress", progress); //Store the progress
    }

    public void UpdateUI()
    {
        CheckProgress();
        float percentage;

        //Clamp the progress
        if(progress >= 200)
        {
            progress = 200;
        }

        if(progress <= 0)
        {
            progress = 0;
        }


        if(progress > 100) //Level 2
        {
            medal.sprite = medal2;
            percentage = progress - 100; //Reset the progress percentage for the new medal
        }
        else
        {
            percentage = progress;
        }

        //Set the Masked Image fill amount
        maskedImage.fillAmount = percentage / 100;
    }
}
